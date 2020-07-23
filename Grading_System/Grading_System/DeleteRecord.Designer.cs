namespace Grading_System
{
    partial class DeleteRecord
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
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rname = new System.Windows.Forms.TextBox();
            this.cencel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(76, 198);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 44);
            this.delete.TabIndex = 0;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Record Name : ";
            // 
            // rname
            // 
            this.rname.Location = new System.Drawing.Point(195, 120);
            this.rname.Name = "rname";
            this.rname.Size = new System.Drawing.Size(183, 22);
            this.rname.TabIndex = 3;
            // 
            // cencel
            // 
            this.cencel.Location = new System.Drawing.Point(230, 198);
            this.cencel.Name = "cencel";
            this.cencel.Size = new System.Drawing.Size(113, 44);
            this.cencel.TabIndex = 4;
            this.cencel.Text = "Cancel";
            this.cencel.UseVisualStyleBackColor = true;
            this.cencel.Click += new System.EventHandler(this.cencel_Click);
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(459, 329);
            this.Controls.Add(this.cencel);
            this.Controls.Add(this.rname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Name = "DeleteRecord";
            this.Text = "DeleteRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rname;
        private System.Windows.Forms.Button cencel;
    }
}