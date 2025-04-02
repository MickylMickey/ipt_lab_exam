namespace ipt_lab_exam
{
    partial class StudentPage_Individual
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelContact;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Full Name:";

            // labelAddress
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(20, 60);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(100, 23);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address:";

            // labelContact
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(20, 100);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(100, 23);
            this.labelContact.TabIndex = 2;
            this.labelContact.Text = "Contact No:";

            // StudentPage_Individual
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelContact);
            this.Name = "StudentPage_Individual";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentPage_Individual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
