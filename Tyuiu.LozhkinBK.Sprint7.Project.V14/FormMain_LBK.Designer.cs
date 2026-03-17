namespace Tyuiu.LozhkinBK.Sprint7.Project.V14.Forms
{
    partial class FormMain_LBK
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLoadCsv_LBK = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveCsv_LBK = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem_LBK = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem_LBK = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem_LBK = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_LBK = new System.Windows.Forms.Panel();
            this.buttonShowStatistics_LBK = new System.Windows.Forms.Button();
            this.buttonSortByTravelTime_LBK = new System.Windows.Forms.Button();
            this.buttonResetFilter_LBK = new System.Windows.Forms.Button();
            this.buttonEditTransport_LBK = new System.Windows.Forms.Button();
            this.buttonDeleteTransport_LBK = new System.Windows.Forms.Button();
            this.buttonAddTransport_LBK = new System.Windows.Forms.Button();
            this.comboBoxTransportType_LBK = new System.Windows.Forms.ComboBox();
            this.search_LBK = new System.Windows.Forms.Label();
            this.textBoxSearch_LBK = new System.Windows.Forms.TextBox();
            this.dataGridViewTransport_LBK = new System.Windows.Forms.DataGridView();
            this.toolTipSearch_LBK = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAdd_LBK = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDelete_LBK = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDrop_LBK = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel_LBK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport_LBK)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem_LBK});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1279, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonLoadCsv_LBK,
            this.buttonSaveCsv_LBK});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 38);
            this.fileToolStripMenuItem.Text = "Файл";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // buttonLoadCsv_LBK
            // 
            this.buttonLoadCsv_LBK.Name = "buttonLoadCsv_LBK";
            this.buttonLoadCsv_LBK.Size = new System.Drawing.Size(276, 40);
            this.buttonLoadCsv_LBK.Text = "Загрузить CSV";
            this.buttonLoadCsv_LBK.Click += new System.EventHandler(this.buttonLoadCsv_LBK_Click);
            // 
            // buttonSaveCsv_LBK
            // 
            this.buttonSaveCsv_LBK.Name = "buttonSaveCsv_LBK";
            this.buttonSaveCsv_LBK.Size = new System.Drawing.Size(276, 40);
            this.buttonSaveCsv_LBK.Text = "Сохранить CSV";
            this.buttonSaveCsv_LBK.Click += new System.EventHandler(this.buttonSaveCsv_LBK_Click);
            // 
            // helpToolStripMenuItem_LBK
            // 
            this.helpToolStripMenuItem_LBK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem_LBK,
            this.userGuideToolStripMenuItem_LBK});
            this.helpToolStripMenuItem_LBK.Name = "helpToolStripMenuItem_LBK";
            this.helpToolStripMenuItem_LBK.Size = new System.Drawing.Size(111, 38);
            this.helpToolStripMenuItem_LBK.Text = "Справка";
            // 
            // aboutToolStripMenuItem_LBK
            // 
            this.aboutToolStripMenuItem_LBK.Name = "aboutToolStripMenuItem_LBK";
            this.aboutToolStripMenuItem_LBK.Size = new System.Drawing.Size(388, 40);
            this.aboutToolStripMenuItem_LBK.Text = "О программе";
            this.aboutToolStripMenuItem_LBK.Click += new System.EventHandler(this.aboutToolStripMenuItem_LBK_Click);
            // 
            // userGuideToolStripMenuItem_LBK
            // 
            this.userGuideToolStripMenuItem_LBK.Name = "userGuideToolStripMenuItem_LBK";
            this.userGuideToolStripMenuItem_LBK.Size = new System.Drawing.Size(388, 40);
            this.userGuideToolStripMenuItem_LBK.Text = "Руководство пользователя";
            this.userGuideToolStripMenuItem_LBK.Click += new System.EventHandler(this.userGuideToolStripMenuItem_LBK_Click);
            // 
            // panel_LBK
            // 
            this.panel_LBK.Controls.Add(this.buttonShowStatistics_LBK);
            this.panel_LBK.Controls.Add(this.buttonSortByTravelTime_LBK);
            this.panel_LBK.Controls.Add(this.buttonResetFilter_LBK);
            this.panel_LBK.Controls.Add(this.buttonEditTransport_LBK);
            this.panel_LBK.Controls.Add(this.buttonDeleteTransport_LBK);
            this.panel_LBK.Controls.Add(this.buttonAddTransport_LBK);
            this.panel_LBK.Controls.Add(this.comboBoxTransportType_LBK);
            this.panel_LBK.Controls.Add(this.search_LBK);
            this.panel_LBK.Controls.Add(this.textBoxSearch_LBK);
            this.panel_LBK.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_LBK.Location = new System.Drawing.Point(0, 42);
            this.panel_LBK.Name = "panel_LBK";
            this.panel_LBK.Size = new System.Drawing.Size(1279, 144);
            this.panel_LBK.TabIndex = 1;
            // 
            // buttonShowStatistics_LBK
            // 
            this.buttonShowStatistics_LBK.Location = new System.Drawing.Point(1077, 51);
            this.buttonShowStatistics_LBK.Name = "buttonShowStatistics_LBK";
            this.buttonShowStatistics_LBK.Size = new System.Drawing.Size(190, 50);
            this.buttonShowStatistics_LBK.TabIndex = 9;
            this.buttonShowStatistics_LBK.Text = "Статистика";
            this.buttonShowStatistics_LBK.UseVisualStyleBackColor = true;
            this.buttonShowStatistics_LBK.Click += new System.EventHandler(this.buttonShowStatistics_LBK_Click);
            // 
            // buttonSortByTravelTime_LBK
            // 
            this.buttonSortByTravelTime_LBK.Location = new System.Drawing.Point(240, 5);
            this.buttonSortByTravelTime_LBK.Name = "buttonSortByTravelTime_LBK";
            this.buttonSortByTravelTime_LBK.Size = new System.Drawing.Size(199, 126);
            this.buttonSortByTravelTime_LBK.TabIndex = 8;
            this.buttonSortByTravelTime_LBK.Text = "Сортировка по длительности";
            this.buttonSortByTravelTime_LBK.UseVisualStyleBackColor = true;
            this.buttonSortByTravelTime_LBK.Click += new System.EventHandler(this.buttonSortByTravelTime_LBK_Click);
            // 
            // buttonResetFilter_LBK
            // 
            this.buttonResetFilter_LBK.Location = new System.Drawing.Point(674, 58);
            this.buttonResetFilter_LBK.Name = "buttonResetFilter_LBK";
            this.buttonResetFilter_LBK.Size = new System.Drawing.Size(97, 43);
            this.buttonResetFilter_LBK.TabIndex = 7;
            this.buttonResetFilter_LBK.Text = "Сброс";
            this.toolTipDrop_LBK.SetToolTip(this.buttonResetFilter_LBK, "Сбросить параметры поиска, фильтрациии сортировки");
            this.buttonResetFilter_LBK.UseVisualStyleBackColor = true;
            this.buttonResetFilter_LBK.Click += new System.EventHandler(this.buttonResetFilter_LBK_Click);
            // 
            // buttonEditTransport_LBK
            // 
            this.buttonEditTransport_LBK.Location = new System.Drawing.Point(0, 92);
            this.buttonEditTransport_LBK.Name = "buttonEditTransport_LBK";
            this.buttonEditTransport_LBK.Size = new System.Drawing.Size(197, 39);
            this.buttonEditTransport_LBK.TabIndex = 5;
            this.buttonEditTransport_LBK.Text = "Редактировать";
            this.buttonEditTransport_LBK.UseVisualStyleBackColor = true;
            this.buttonEditTransport_LBK.Click += new System.EventHandler(this.buttonEditTransport_LBK_Click);
            // 
            // buttonDeleteTransport_LBK
            // 
            this.buttonDeleteTransport_LBK.Location = new System.Drawing.Point(0, 46);
            this.buttonDeleteTransport_LBK.Name = "buttonDeleteTransport_LBK";
            this.buttonDeleteTransport_LBK.Size = new System.Drawing.Size(197, 40);
            this.buttonDeleteTransport_LBK.TabIndex = 4;
            this.buttonDeleteTransport_LBK.Text = "Удалить";
            this.toolTipDelete_LBK.SetToolTip(this.buttonDeleteTransport_LBK, "Удалить запись о маршруте");
            this.buttonDeleteTransport_LBK.UseVisualStyleBackColor = true;
            this.buttonDeleteTransport_LBK.Click += new System.EventHandler(this.buttonDeleteTransport_LBK_Click);
            // 
            // buttonAddTransport_LBK
            // 
            this.buttonAddTransport_LBK.Location = new System.Drawing.Point(0, 0);
            this.buttonAddTransport_LBK.Name = "buttonAddTransport_LBK";
            this.buttonAddTransport_LBK.Size = new System.Drawing.Size(197, 40);
            this.buttonAddTransport_LBK.TabIndex = 3;
            this.buttonAddTransport_LBK.Text = "Добавить";
            this.toolTipAdd_LBK.SetToolTip(this.buttonAddTransport_LBK, "Добавить запись о маршруте");
            this.buttonAddTransport_LBK.UseVisualStyleBackColor = true;
            this.buttonAddTransport_LBK.Click += new System.EventHandler(this.buttonAddTransport_LBK_Click_1);
            // 
            // comboBoxTransportType_LBK
            // 
            this.comboBoxTransportType_LBK.FormattingEnabled = true;
            this.comboBoxTransportType_LBK.Items.AddRange(new object[] {
            "Автобус",
            "Трамвай",
            "Троллейбус"});
            this.comboBoxTransportType_LBK.Location = new System.Drawing.Point(459, 51);
            this.comboBoxTransportType_LBK.Name = "comboBoxTransportType_LBK";
            this.comboBoxTransportType_LBK.Size = new System.Drawing.Size(191, 32);
            this.comboBoxTransportType_LBK.TabIndex = 2;
            this.comboBoxTransportType_LBK.Text = "Тип транспорта";
            this.comboBoxTransportType_LBK.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransportType_LBK_SelectedIndexChanged);
            // 
            // search_LBK
            // 
            this.search_LBK.AutoSize = true;
            this.search_LBK.Location = new System.Drawing.Point(455, 8);
            this.search_LBK.Name = "search_LBK";
            this.search_LBK.Size = new System.Drawing.Size(195, 25);
            this.search_LBK.TabIndex = 1;
            this.search_LBK.Text = "Поиск по маршруту";
            // 
            // textBoxSearch_LBK
            // 
            this.textBoxSearch_LBK.Location = new System.Drawing.Point(671, 8);
            this.textBoxSearch_LBK.Name = "textBoxSearch_LBK";
            this.textBoxSearch_LBK.Size = new System.Drawing.Size(100, 29);
            this.textBoxSearch_LBK.TabIndex = 0;
            this.toolTipSearch_LBK.SetToolTip(this.textBoxSearch_LBK, "Введите номер маршрута, остановку, тип ТС или примечание");
            this.textBoxSearch_LBK.TextChanged += new System.EventHandler(this.textBoxSearch_LBK_TextChanged);
            // 
            // dataGridViewTransport_LBK
            // 
            this.dataGridViewTransport_LBK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransport_LBK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransport_LBK.Location = new System.Drawing.Point(0, 186);
            this.dataGridViewTransport_LBK.Name = "dataGridViewTransport_LBK";
            this.dataGridViewTransport_LBK.RowHeadersWidth = 72;
            this.dataGridViewTransport_LBK.RowTemplate.Height = 31;
            this.dataGridViewTransport_LBK.Size = new System.Drawing.Size(1279, 741);
            this.dataGridViewTransport_LBK.TabIndex = 2;
            this.dataGridViewTransport_LBK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransport_LBK_CellContentClick);
            // 
            // FormMain_LBK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 927);
            this.Controls.Add(this.dataGridViewTransport_LBK);
            this.Controls.Add(this.panel_LBK);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain_LBK";
            this.Text = "FormMain_LBK";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_LBK.ResumeLayout(false);
            this.panel_LBK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport_LBK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonLoadCsv_LBK;
        private System.Windows.Forms.ToolStripMenuItem buttonSaveCsv_LBK;
        private System.Windows.Forms.Panel panel_LBK;
        private System.Windows.Forms.DataGridView dataGridViewTransport_LBK;
        private System.Windows.Forms.TextBox textBoxSearch_LBK;
        private System.Windows.Forms.ComboBox comboBoxTransportType_LBK;
        private System.Windows.Forms.Label search_LBK;
        private System.Windows.Forms.Button buttonAddTransport_LBK;
        private System.Windows.Forms.Button buttonDeleteTransport_LBK;
        private System.Windows.Forms.Button buttonEditTransport_LBK;
        private System.Windows.Forms.Button buttonResetFilter_LBK;
        private System.Windows.Forms.Button buttonSortByTravelTime_LBK;
        private System.Windows.Forms.Button buttonShowStatistics_LBK;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem_LBK;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem_LBK;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem_LBK;
        private System.Windows.Forms.ToolTip toolTipSearch_LBK;
        private System.Windows.Forms.ToolTip toolTipAdd_LBK;
        private System.Windows.Forms.ToolTip toolTipDelete_LBK;
        private System.Windows.Forms.ToolTip toolTipDrop_LBK;
    }
}