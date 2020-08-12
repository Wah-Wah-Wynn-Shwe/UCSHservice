namespace AndroidServiceIntegration
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTradeMark = new System.Windows.Forms.Label();
            this.txtEntranceID = new System.Windows.Forms.TextBox();
            this.btnGetCode = new System.Windows.Forms.Button();
            this.txtAuthenticationID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(186, 93);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(178, 21);
            this.txtLoginID.TabIndex = 0;
            this.txtLoginID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginID_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCancel.Location = new System.Drawing.Point(186, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(182, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 22);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Service Integration API";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "LoginID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "EntranceID";
            // 
            // lblTradeMark
            // 
            this.lblTradeMark.AutoSize = true;
            this.lblTradeMark.Font = new System.Drawing.Font("Arial", 8F);
            this.lblTradeMark.Location = new System.Drawing.Point(183, 340);
            this.lblTradeMark.Name = "lblTradeMark";
            this.lblTradeMark.Size = new System.Drawing.Size(397, 14);
            this.lblTradeMark.TabIndex = 5;
            this.lblTradeMark.Text = "Support by Wah Wah Wynn Shwe Hlaing! CopyRight © 2019 All Rights Reversed.";
            // 
            // txtEntranceID
            // 
            this.txtEntranceID.Location = new System.Drawing.Point(186, 141);
            this.txtEntranceID.Name = "txtEntranceID";
            this.txtEntranceID.Size = new System.Drawing.Size(178, 21);
            this.txtEntranceID.TabIndex = 1;
            this.txtEntranceID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntranceID_KeyPress);
            // 
            // btnGetCode
            // 
            this.btnGetCode.Font = new System.Drawing.Font("Arial", 10F);
            this.btnGetCode.Location = new System.Drawing.Point(278, 189);
            this.btnGetCode.Name = "btnGetCode";
            this.btnGetCode.Size = new System.Drawing.Size(86, 31);
            this.btnGetCode.TabIndex = 2;
            this.btnGetCode.Text = "Get Code";
            this.btnGetCode.UseVisualStyleBackColor = true;
            this.btnGetCode.Click += new System.EventHandler(this.btnGetCode_Click);
            // 
            // txtAuthenticationID
            // 
            this.txtAuthenticationID.Enabled = false;
            this.txtAuthenticationID.ForeColor = System.Drawing.Color.Green;
            this.txtAuthenticationID.Location = new System.Drawing.Point(186, 241);
            this.txtAuthenticationID.Name = "txtAuthenticationID";
            this.txtAuthenticationID.Size = new System.Drawing.Size(293, 21);
            this.txtAuthenticationID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yours\' Authentication Key";
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCopy.Location = new System.Drawing.Point(486, 238);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(86, 31);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnGetCode;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 363);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAuthenticationID);
            this.Controls.Add(this.btnGetCode);
            this.Controls.Add(this.txtEntranceID);
            this.Controls.Add(this.lblTradeMark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLoginID);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Integration API";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTradeMark;
        private System.Windows.Forms.TextBox txtEntranceID;
        private System.Windows.Forms.Button btnGetCode;
        private System.Windows.Forms.TextBox txtAuthenticationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopy;
    }
}

