namespace Assignment
{
    partial class Form3
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.newCheck1 = new Assignment.Class1();
            this.SuspendLayout();
            // 
            // newCheck1
            // 
            this.newCheck1.Appearance = System.Windows.Forms.Appearance.Button;
            this.newCheck1.AutoSize = true;
            this.newCheck1.Location = new System.Drawing.Point(402, 15);
            this.newCheck1.MinimumSize = new System.Drawing.Size(30, 30);
            this.newCheck1.Name = "newCheck1";
            this.newCheck1.Size = new System.Drawing.Size(30, 30);
            this.newCheck1.TabIndex = 12;
            this.newCheck1.Text = "12";
            this.newCheck1.UseVisualStyleBackColor = true;
            
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 382);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        //private Assignment.NewCheck newCheck1;
    }
}