using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AndroidServiceIntegration
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private const string _charList = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly char[] _charArray = _charList.ToCharArray();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtLoginID.Clear();
            txtAuthenticationID.Clear();
            txtEntranceID.Clear();
            Clipboard.SetText(string.Empty);
        }
        string DeveloperID = "WahWahWynnShweHlaig";
        string EnviromentFrameWork = "CSharp DOTNET 4.5";
        string TargetUser = "UCSH";


        public string GenerateUID(string userInfo)
        {
            string _id = string.Concat(userInfo, DeveloperID, EnviromentFrameWork, TargetUser);
            byte[] _byteIds = Encoding.UTF8.GetBytes(_id);

            MD5CryptoServiceProvider _md5 = new MD5CryptoServiceProvider();
            byte[] _checksum = _md5.ComputeHash(_byteIds);

            string _part1Id = Encode(BitConverter.ToUInt32(_checksum, 0));
            string _part2Id = Encode(BitConverter.ToUInt32(_checksum, 4));
            string _part3Id = Encode(BitConverter.ToUInt32(_checksum, 8));
            string _part4Id = Encode(BitConverter.ToUInt32(_checksum, 12));

            return string.Format("{0}-{1}-{2}-{3}", _part1Id, _part2Id, _part3Id, _part4Id);
        }
        public static long Decode(string input)
        {
            long _result = 0;
            double _pow = 0;
            for (int _i = input.Length - 1; _i >= 0; _i--)
            {
                char _c = input[_i];
                int pos = _charList.IndexOf(_c);
                if (pos > -1)
                    _result += pos * (long)Math.Pow(_charList.Length, _pow);
                else
                    return -1;
                _pow++;
            }
            return _result;
        }

        public static string Encode(ulong input)
        {
            StringBuilder _sb = new StringBuilder();
            do
            {
                _sb.Append(_charArray[input % (ulong)_charList.Length]);
                input /= (ulong)_charList.Length;
            } while (input != 0);

            return Reverse(_sb.ToString());
        }

        private static string Reverse(string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string SHA256Hasing(string OrgValue)
        {
            string hashedValue = string.Empty;
            SHA256CryptoServiceProvider hashAlgorithm = new SHA256CryptoServiceProvider();

            if (!string.IsNullOrEmpty(OrgValue))
            {
                byte[] hashedData = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(OrgValue));

                foreach (byte b in hashedData)
                {
                    hashedValue += String.Format("{0,2:x2}", b);
                }
            }
            return hashedValue;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtLoginID.Focus(); 
            lblTradeMark.Text = "Support by Wah Wah Wynn Shwe Hlaing!CopyRight © " + DateTime.Now.Year+" All Rights Reversed.";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtAuthenticationID.SelectAll();
            Clipboard.SetText(txtAuthenticationID.Text);
        }

        private void btnGetCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEntranceID.Text) && !string.IsNullOrEmpty(txtLoginID.Text))
            {
                txtAuthenticationID.Text=GenerateUID(txtLoginID.Text + txtEntranceID.Text);
            }
            else MessageBox.Show("Require Variables are not provided.");
        }

        private void txtLoginID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txtEntranceID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
