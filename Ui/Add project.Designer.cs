namespace Ui
{
    partial class Add_project
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

        #region Component Designer generated code

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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtteamid = new System.Windows.Forms.TextBox();
            this.txtprojectname = new System.Windows.Forms.TextBox();
            this.txtprojectS_date = new System.Windows.Forms.TextBox();
            this.txtProjectE_Date = new System.Windows.Forms.TextBox();
            this.Txtprojectstatus = new System.Windows.Forms.TextBox();
            this.Btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(36, 261);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 6;
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(91, 32);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(100, 20);
            this.txtempid.TabIndex = 7;
            // 
            // txtteamid
            // 
            this.txtteamid.Location = new System.Drawing.Point(91, 61);
            this.txtteamid.Name = "txtteamid";
            this.txtteamid.Size = new System.Drawing.Size(100, 20);
            this.txtteamid.TabIndex = 8;
            // 
            // txtprojectname
            // 
            this.txtprojectname.Location = new System.Drawing.Point(91, 91);
            this.txtprojectname.Name = "txtprojectname";
            this.txtprojectname.Size = new System.Drawing.Size(100, 20);
            this.txtprojectname.TabIndex = 9;
            // 
            // txtprojectS_date
            // 
            this.txtprojectS_date.Location = new System.Drawing.Point(91, 119);
            this.txtprojectS_date.Name = "txtprojectS_date";
            this.txtprojectS_date.Size = new System.Drawing.Size(100, 20);
            this.txtprojectS_date.TabIndex = 10;
            // 
            // txtProjectE_Date
            // 
            this.txtProjectE_Date.Location = new System.Drawing.Point(91, 145);
            this.txtProjectE_Date.Name = "txtProjectE_Date";
            this.txtProjectE_Date.Size = new System.Drawing.Size(100, 20);
            this.txtProjectE_Date.TabIndex = 11;
            // 
            // Txtprojectstatus
            // 
            this.Txtprojectstatus.Location = new System.Drawing.Point(91, 173);
            this.Txtprojectstatus.Name = "Txtprojectstatus";
            this.Txtprojectstatus.Size = new System.Drawing.Size(100, 20);
            this.Txtprojectstatus.TabIndex = 12;
            // 
            // Btnadd
            // 
            this.Btnadd.Location = new System.Drawing.Point(91, 220);
            this.Btnadd.Name = "Btnadd";
            this.Btnadd.Size = new System.Drawing.Size(75, 23);
            this.Btnadd.TabIndex = 13;
            this.Btnadd.Text = "Add";
            this.Btnadd.UseVisualStyleBackColor = true;
            this.Btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // Add_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btnadd);
            this.Controls.Add(this.Txtprojectstatus);
            this.Controls.Add(this.txtProjectE_Date);
            this.Controls.Add(this.txtprojectS_date);
            this.Controls.Add(this.txtprojectname);
            this.Controls.Add(this.txtteamid);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_project";
            this.Size = new System.Drawing.Size(520, 346);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txtteamid;
        private System.Windows.Forms.TextBox txtprojectname;
        private System.Windows.Forms.TextBox txtprojectS_date;
        private System.Windows.Forms.TextBox txtProjectE_Date;
        private System.Windows.Forms.TextBox Txtprojectstatus;
        private System.Windows.Forms.Button Btnadd;
    }
}
