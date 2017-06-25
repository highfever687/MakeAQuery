namespace MakeAQuery
{
    partial class About
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "About The Programmer";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "The purpose of this program is to help users build",
            "queries very quickly when the Data comes from a",
            "place outside of this program, such an Excel Document",
            "OR  a TXT Document.",
            "",
            "For Example if you or a user needed to add everyone from ",
            "an excel document to a database using an Insert Or an Update Statement",
            "this program would allow you import the Data from another place",
            "and generate a Where In Clause as Output to be copied and pasted into your",
            "DataBase Engine. Sometimes this needed for Mail Merges and many other pain",
            "in the Arse occasions, like price updates! ",
            "",
            "This is proprietary software but if you want to use it I am fine with that, so lo" +
                "ng",
            "as you don\'t use it to directly make money off of." +
            "-Derek Foulk Copywrite April 2016 " +
            "As Of June 25 2017 this project is active again!" +
            "Current changes include:" +
            "-A Working Exit Button June 25 2017 " +
            "-A Better Method for Creating New DataBases June 25 2017 " +
            "-A ClipBoard Copy Button June 25 2017 " +
            "-A ClipBoard To Main Screen Button June 25 2017 " +
            "-A icon June 25 2017 " +
            "-More changes to come"});
            this.listBox1.Location = new System.Drawing.Point(22, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 147);
            this.listBox1.TabIndex = 4;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 300);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}