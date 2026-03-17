namespace Tyuiu.LozhkinBK.Sprint7.Project.V14
{
    partial class FormAbout_LBK
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
            this.richTextBoxAbout_LBK = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxAbout_LBK
            // 
            this.richTextBoxAbout_LBK.Location = new System.Drawing.Point(28, 12);
            this.richTextBoxAbout_LBK.Name = "richTextBoxAbout_LBK";
            this.richTextBoxAbout_LBK.Size = new System.Drawing.Size(554, 220);
            this.richTextBoxAbout_LBK.TabIndex = 0;
            this.richTextBoxAbout_LBK.Text = "Система учета городского транспорта\nВерсия: 1.0\nАвтор: LozhkinBogdan";
            this.richTextBoxAbout_LBK.TextChanged += new System.EventHandler(this.richTextBoxAbout_LBK_TextChanged);
            // 
            // FormAbout_LBK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxAbout_LBK);
            this.Name = "FormAbout_LBK";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FormAbout_LBK";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAbout_LBK;
    }
}