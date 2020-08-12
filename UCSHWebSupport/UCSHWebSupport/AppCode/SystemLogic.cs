using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography;
using System.Text;

public class SystemLogic
{
    public class CollectionHelper
    {
        public static DataTable ConvertTo<T>(IList<T> list)
        {
            if (list != null)
            {
                DataTable table = CreateTable<T>();
                Type entityType = typeof(T);
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

                foreach (T item in list)
                {
                    DataRow row = table.NewRow();

                    foreach (PropertyDescriptor prop in properties)
                    {
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value; ;
                    }

                    table.Rows.Add(row);
                }

                return table;
            }
            else return null;
        }
        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            return table;
        }
    }
    public string SHA256Hasing(string OrgValue)
    {
        string hashedValue = string.Empty;

        SHA256CryptoServiceProvider hashAlgorithm = new SHA256CryptoServiceProvider();

        byte[] hashedData = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(OrgValue));

        foreach (byte b in hashedData)
        {
            hashedValue += String.Format("{0,2:x2}", b);
        }

        return hashedValue;
    }

}