
namespace Library_Management_System
{
    partial class AddMemberss
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MID = new System.Windows.Forms.TextBox();
            this.txt_mname = new System.Windows.Forms.TextBox();
            this.txt_mno = new System.Windows.Forms.TextBox();
            this.txt_mEmail = new System.Windows.Forms.TextBox();
            this.txt_refreshh = new System.Windows.Forms.Button();
            this.txt_saveM = new System.Windows.Forms.Button();
            this.txt_exitm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mobile Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txt_MID
            // 
            this.txt_MID.Location = new System.Drawing.Point(474, 49);
            this.txt_MID.Name = "txt_MID";
            this.txt_MID.Size = new System.Drawing.Size(100, 22);
            this.txt_MID.TabIndex = 4;
            // 
            // txt_mname
            // 
            this.txt_mname.Location = new System.Drawing.Point(474, 109);
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.Size = new System.Drawing.Size(100, 22);
            this.txt_mname.TabIndex = 5;
            // 
            // txt_mno
            // 
            this.txt_mno.Location = new System.Drawing.Point(474, 187);
            this.txt_mno.Name = "txt_mno";
            this.txt_mno.Size = new System.Drawing.Size(100, 22);
            this.txt_mno.TabIndex = 6;
            // 
            // txt_mEmail
            // 
            this.txt_mEmail.Location = new System.Drawing.Point(474, 282);
            this.txt_mEmail.Name = "txt_mEmail";
            this.txt_mEmail.Size = new System.Drawing.Size(100, 22);
            this.txt_mEmail.TabIndex = 7;
            // 
            // txt_refreshh
            // 
            this.txt_refreshh.Location = new System.Drawing.Point(142, 372);
            this.txt_refreshh.Name = "txt_refreshh";
            this.txt_refreshh.Size = new System.Drawing.Size(75, 23);
            this.txt_refreshh.TabIndex = 8;
            this.txt_refreshh.Text = "Refresh";
            this.txt_refreshh.UseVisualStyleBackColor = true;
            // 
            // txt_saveM
            // 
            this.txt_saveM.Location = new System.Drawing.Point(342, 371);
            this.txt_saveM.Name = "txt_saveM";
            this.txt_saveM.Size = new System.Drawing.Size(133, 23);
            this.txt_saveM.TabIndex = 9;
            this.txt_saveM.Text = "Save Details";
            this.txt_saveM.UseVisualStyleBackColor = true;
            // 
            // txt_exitm
            // 
            this.txt_exitm.Location = new System.Drawing.Point(564, 370);
            this.txt_exitm.Name = "txt_exitm";
            this.txt_exitm.Size = new System.Drawing.Size(75, 23);
            this.txt_exitm.TabIndex = 10;
            this.txt_exitm.Text = "Exit";
            this.txt_exitm.UseVisualStyleBackColor = true;
            // 
            // AddMemberss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_exitm);
            this.Controls.Add(this.txt_saveM);
            this.Controls.Add(this.txt_refreshh);
            this.Controls.Add(this.txt_mEmail);
            this.Controls.Add(this.txt_mno);
            this.Controls.Add(this.txt_mname);
            this.Controls.Add(this.txt_MID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMemberss";
            this.Text = "AddMemberss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MID;
        private System.Windows.Forms.TextBox txt_mname;
        private System.Windows.Forms.TextBox txt_mno;
        private System.Windows.Forms.TextBox txt_mEmail;
        private System.Windows.Forms.Button txt_refreshh;
        private System.Windows.Forms.Button txt_saveM;
        private System.Windows.Forms.Button txt_exitm;
    }
}