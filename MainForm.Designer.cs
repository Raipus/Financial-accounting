namespace projectMoney
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonNewRecord = new System.Windows.Forms.Button();
            this.TB_Date = new System.Windows.Forms.TextBox();
            this.TB_sum = new System.Windows.Forms.TextBox();
            this.TB_about = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ListView_Data = new System.Windows.Forms.ListView();
            this.CB_ListFilters = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BT_filtgain = new System.Windows.Forms.Button();
            this.BT_stat = new System.Windows.Forms.Button();
            this.CB_ListOfTables = new System.Windows.Forms.ComboBox();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewRecord
            // 
            this.buttonNewRecord.Location = new System.Drawing.Point(240, 429);
            this.buttonNewRecord.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewRecord.Name = "buttonNewRecord";
            this.buttonNewRecord.Size = new System.Drawing.Size(142, 31);
            this.buttonNewRecord.TabIndex = 5;
            this.buttonNewRecord.Text = "Add new record";
            this.buttonNewRecord.UseVisualStyleBackColor = true;
            this.buttonNewRecord.Click += new System.EventHandler(this.buttonNewRecord_Click);
            // 
            // TB_Date
            // 
            this.TB_Date.Location = new System.Drawing.Point(240, 378);
            this.TB_Date.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Date.Multiline = true;
            this.TB_Date.Name = "TB_Date";
            this.TB_Date.Size = new System.Drawing.Size(127, 26);
            this.TB_Date.TabIndex = 17;
            // 
            // TB_sum
            // 
            this.TB_sum.Location = new System.Drawing.Point(381, 378);
            this.TB_sum.Margin = new System.Windows.Forms.Padding(2);
            this.TB_sum.Multiline = true;
            this.TB_sum.Name = "TB_sum";
            this.TB_sum.Size = new System.Drawing.Size(127, 26);
            this.TB_sum.TabIndex = 18;
            // 
            // TB_about
            // 
            this.TB_about.Location = new System.Drawing.Point(528, 378);
            this.TB_about.Margin = new System.Windows.Forms.Padding(2);
            this.TB_about.Multiline = true;
            this.TB_about.Name = "TB_about";
            this.TB_about.Size = new System.Drawing.Size(127, 26);
            this.TB_about.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(281, 351);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(419, 351);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(525, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Description";
            // 
            // ListView_Data
            // 
            this.ListView_Data.GridLines = true;
            this.ListView_Data.HideSelection = false;
            this.ListView_Data.Location = new System.Drawing.Point(135, 39);
            this.ListView_Data.Margin = new System.Windows.Forms.Padding(2);
            this.ListView_Data.Name = "ListView_Data";
            this.ListView_Data.Size = new System.Drawing.Size(646, 249);
            this.ListView_Data.TabIndex = 23;
            this.ListView_Data.UseCompatibleStateImageBehavior = false;
            this.ListView_Data.View = System.Windows.Forms.View.Details;
            // 
            // CB_ListFilters
            // 
            this.CB_ListFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_ListFilters.FormattingEnabled = true;
            this.CB_ListFilters.Items.AddRange(new object[] {
            "По дате",
            "По сумме"});
            this.CB_ListFilters.Location = new System.Drawing.Point(345, 309);
            this.CB_ListFilters.Margin = new System.Windows.Forms.Padding(2);
            this.CB_ListFilters.Name = "CB_ListFilters";
            this.CB_ListFilters.Size = new System.Drawing.Size(107, 28);
            this.CB_ListFilters.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(281, 309);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Filter";
            // 
            // BT_filtgain
            // 
            this.BT_filtgain.Location = new System.Drawing.Point(478, 309);
            this.BT_filtgain.Margin = new System.Windows.Forms.Padding(2);
            this.BT_filtgain.Name = "BT_filtgain";
            this.BT_filtgain.Size = new System.Drawing.Size(108, 27);
            this.BT_filtgain.TabIndex = 34;
            this.BT_filtgain.Text = "Filter out";
            this.BT_filtgain.UseVisualStyleBackColor = true;
            this.BT_filtgain.Click += new System.EventHandler(this.BT_filt_Click);
            // 
            // BT_stat
            // 
            this.BT_stat.Location = new System.Drawing.Point(-1, 1);
            this.BT_stat.Margin = new System.Windows.Forms.Padding(2);
            this.BT_stat.Name = "BT_stat";
            this.BT_stat.Size = new System.Drawing.Size(132, 37);
            this.BT_stat.TabIndex = 36;
            this.BT_stat.Text = "Show Statistic ";
            this.BT_stat.UseVisualStyleBackColor = true;
            this.BT_stat.Click += new System.EventHandler(this.BT_stat_Click);
            // 
            // CB_ListOfTables
            // 
            this.CB_ListOfTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_ListOfTables.FormattingEnabled = true;
            this.CB_ListOfTables.Items.AddRange(new object[] {
            "Доходы",
            "Расходы"});
            this.CB_ListOfTables.Location = new System.Drawing.Point(260, 7);
            this.CB_ListOfTables.Margin = new System.Windows.Forms.Padding(2);
            this.CB_ListOfTables.Name = "CB_ListOfTables";
            this.CB_ListOfTables.Size = new System.Drawing.Size(179, 28);
            this.CB_ListOfTables.TabIndex = 37;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(502, 4);
            this.buttonLoadData.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(142, 31);
            this.buttonLoadData.TabIndex = 38;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_OnClick);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(513, 429);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(142, 31);
            this.searchButton.TabIndex = 39;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 471);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.CB_ListOfTables);
            this.Controls.Add(this.BT_stat);
            this.Controls.Add(this.BT_filtgain);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CB_ListFilters);
            this.Controls.Add(this.ListView_Data);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_about);
            this.Controls.Add(this.TB_sum);
            this.Controls.Add(this.TB_Date);
            this.Controls.Add(this.buttonNewRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Financial accounting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNewRecord;
        private System.Windows.Forms.TextBox TB_Date;
        private System.Windows.Forms.TextBox TB_sum;
        private System.Windows.Forms.TextBox TB_about;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView ListView_Data;
        private System.Windows.Forms.ComboBox CB_ListFilters;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BT_filtgain;
        private System.Windows.Forms.Button BT_stat;
        private System.Windows.Forms.ComboBox CB_ListOfTables;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button searchButton;
    }
}

