namespace Grading_System
{
    partial class DeleteStudentRecord
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
            this.recordname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enroll = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Student Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Record : ";
            // 
            // recordname
            // 
            this.recordname.FormattingEnabled = true;
            this.recordname.Location = new System.Drawing.Point(190, 104);
            this.recordname.Name = "recordname";
            this.recordname.Size = new System.Drawing.Size(190, 24);
            this.recordname.TabIndex = 2;
            this.recordname.SelectedIndexChanged += new System.EventHandler(this.recordname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Enrollment No : ";
            // 
            // enroll
            // 
            this.enroll.Location = new System.Drawing.Point(190, 155);
            this.enroll.Name = "enroll";
            this.enroll.Size = new System.Drawing.Size(190, 22);
            this.enroll.TabIndex = 4;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(105, 221);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 44);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(252, 221);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(101, 44);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // DeleteStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 339);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.enroll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.recordname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteStudentRecord";
            this.Text = "DeleteStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox recordname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enroll;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button cancel;
    }
}