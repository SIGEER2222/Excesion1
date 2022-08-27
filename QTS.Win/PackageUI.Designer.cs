
namespace QTS.Excesion.Win
{
    partial class PackageUI
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
            this.package1 = new QTS.Excesion.Win.Package();
            this.SuspendLayout();
            // 
            // package1
            // 
            this.package1.Location = new System.Drawing.Point(32, 12);
            this.package1.Name = "package1";
            this.package1.Size = new System.Drawing.Size(404, 95);
            this.package1.TabIndex = 0;
            // 
            // PackageUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 247);
            this.Controls.Add(this.package1);
            this.Name = "PackageUI";
            this.Text = "PackageUI";
            this.ResumeLayout(false);

        }

        #endregion

        private Package package1;
    }
}