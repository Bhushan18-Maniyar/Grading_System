namespace Grading_System
{
    partial class Updateprofile
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
            this.label5 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.classname = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Your Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email : ";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(173, 99);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(217, 22);
            this.uname.TabIndex = 5;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(173, 131);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(217, 22);
            this.pass.TabIndex = 6;
            // 
            // classname
            // 
            this.classname.Location = new System.Drawing.Point(173, 165);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(217, 22);
            this.classname.TabIndex = 7;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(173, 202);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(217, 22);
            this.email.TabIndex = 8;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(95, 257);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(102, 45);
            this.update.TabIndex = 9;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(232, 257);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(102, 45);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Updateprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 355);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.update);
            this.Controls.Add(this.email);
            this.Controls.Add(this.classname);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Updateprofile";
            this.Text = "Updateprofile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox classname;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button cancel;
    }
}