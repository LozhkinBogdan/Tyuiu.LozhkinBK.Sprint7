namespace Tyuiu.LozhkinBK.Sprint7.Project.V14
{
    partial class FormGuide_LBK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide_LBK));
            this.richTextBoxGuide_LBK = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxGuide_LBK
            // 
            this.richTextBoxGuide_LBK.Location = new System.Drawing.Point(24, 12);
            this.richTextBoxGuide_LBK.Name = "richTextBoxGuide_LBK";
            this.richTextBoxGuide_LBK.Size = new System.Drawing.Size(729, 414);
            this.richTextBoxGuide_LBK.TabIndex = 0;
            this.richTextBoxGuide_LBK.Text = resources.GetString("richTextBoxGuide_LBK.Text");
            // 
            // FormGuide_LBK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxGuide_LBK);
            this.Name = "FormGuide_LBK";
            this.Text = "FormGuide_LBK";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxGuide_LBK;
    }
}