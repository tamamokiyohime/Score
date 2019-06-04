namespace Score
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.last5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cutting_word = new System.Windows.Forms.TextBox();
            this.SaveDT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IPath = new System.Windows.Forms.TextBox();
            this.ReadCSV = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OBrowse = new System.Windows.Forms.Button();
            this.OPath = new System.Windows.Forms.TextBox();
            this.IBrowse = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.names_com = new System.Windows.Forms.ComboBox();
            this.Enter = new System.Windows.Forms.Button();
            this.Input_col = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddNewCol = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.NewCol_Name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.limit = new System.Windows.Forms.TextBox();
            this.Input_Limit = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(563, 546);
            this.dataGridView1.TabIndex = 0;
            // 
            // last5
            // 
            this.last5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.last5.Location = new System.Drawing.Point(107, 38);
            this.last5.Name = "last5";
            this.last5.Size = new System.Drawing.Size(120, 25);
            this.last5.TabIndex = 1;
            this.last5.TextChanged += new System.EventHandler(this.last5_TextChanged);
            this.last5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.last5_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "學號後5碼";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "姓名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "成績";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.score.Location = new System.Drawing.Point(107, 126);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(120, 25);
            this.score.TabIndex = 5;
            this.score.KeyDown += new System.Windows.Forms.KeyEventHandler(this.score_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cutting_word);
            this.groupBox1.Controls.Add(this.SaveDT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.IPath);
            this.groupBox1.Controls.Add(this.ReadCSV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.OBrowse);
            this.groupBox1.Controls.Add(this.OPath);
            this.groupBox1.Controls.Add(this.IBrowse);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(592, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(493, 138);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "檔案設定";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "分割字元：";
            // 
            // cutting_word
            // 
            this.cutting_word.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cutting_word.Location = new System.Drawing.Point(114, 59);
            this.cutting_word.Name = "cutting_word";
            this.cutting_word.Size = new System.Drawing.Size(25, 25);
            this.cutting_word.TabIndex = 15;
            this.cutting_word.Text = ",";
            this.cutting_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveDT
            // 
            this.SaveDT.BackColor = System.Drawing.Color.White;
            this.SaveDT.FlatAppearance.BorderSize = 0;
            this.SaveDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDT.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SaveDT.ForeColor = System.Drawing.Color.Black;
            this.SaveDT.Location = new System.Drawing.Point(410, 99);
            this.SaveDT.Name = "SaveDT";
            this.SaveDT.Size = new System.Drawing.Size(50, 25);
            this.SaveDT.TabIndex = 14;
            this.SaveDT.Text = "儲存";
            this.SaveDT.UseVisualStyleBackColor = false;
            this.SaveDT.Click += new System.EventHandler(this.SaveDT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "輸入檔案：";
            // 
            // IPath
            // 
            this.IPath.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IPath.Location = new System.Drawing.Point(114, 26);
            this.IPath.Name = "IPath";
            this.IPath.Size = new System.Drawing.Size(290, 25);
            this.IPath.TabIndex = 1;
            // 
            // ReadCSV
            // 
            this.ReadCSV.BackColor = System.Drawing.Color.White;
            this.ReadCSV.FlatAppearance.BorderSize = 0;
            this.ReadCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadCSV.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ReadCSV.ForeColor = System.Drawing.Color.Black;
            this.ReadCSV.Location = new System.Drawing.Point(145, 59);
            this.ReadCSV.Name = "ReadCSV";
            this.ReadCSV.Size = new System.Drawing.Size(50, 25);
            this.ReadCSV.TabIndex = 7;
            this.ReadCSV.Text = "讀取";
            this.ReadCSV.UseVisualStyleBackColor = false;
            this.ReadCSV.Click += new System.EventHandler(this.ReadCSV_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "輸出檔案：";
            // 
            // OBrowse
            // 
            this.OBrowse.BackColor = System.Drawing.Color.White;
            this.OBrowse.FlatAppearance.BorderSize = 0;
            this.OBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OBrowse.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OBrowse.ForeColor = System.Drawing.Color.Black;
            this.OBrowse.Location = new System.Drawing.Point(354, 99);
            this.OBrowse.Name = "OBrowse";
            this.OBrowse.Size = new System.Drawing.Size(50, 25);
            this.OBrowse.TabIndex = 6;
            this.OBrowse.Text = "瀏覽";
            this.OBrowse.UseVisualStyleBackColor = false;
            this.OBrowse.Click += new System.EventHandler(this.OBrowse_Click);
            // 
            // OPath
            // 
            this.OPath.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OPath.Location = new System.Drawing.Point(114, 99);
            this.OPath.Name = "OPath";
            this.OPath.Size = new System.Drawing.Size(234, 25);
            this.OPath.TabIndex = 4;
            // 
            // IBrowse
            // 
            this.IBrowse.BackColor = System.Drawing.Color.White;
            this.IBrowse.FlatAppearance.BorderSize = 0;
            this.IBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBrowse.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IBrowse.ForeColor = System.Drawing.Color.Black;
            this.IBrowse.Location = new System.Drawing.Point(410, 26);
            this.IBrowse.Name = "IBrowse";
            this.IBrowse.Size = new System.Drawing.Size(50, 25);
            this.IBrowse.TabIndex = 5;
            this.IBrowse.Text = "瀏覽";
            this.IBrowse.UseVisualStyleBackColor = false;
            this.IBrowse.Click += new System.EventHandler(this.IBrowse_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(232, 38);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(50, 25);
            this.search.TabIndex = 11;
            this.search.Text = "搜尋";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            // 
            // names_com
            // 
            this.names_com.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.names_com.FormattingEnabled = true;
            this.names_com.Location = new System.Drawing.Point(107, 81);
            this.names_com.Name = "names_com";
            this.names_com.Size = new System.Drawing.Size(120, 25);
            this.names_com.TabIndex = 12;
            this.names_com.SelectedIndexChanged += new System.EventHandler(this.names_com_SelectedIndexChanged_1);
            this.names_com.KeyDown += new System.Windows.Forms.KeyEventHandler(this.names_com_KeyDown);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.White;
            this.Enter.FlatAppearance.BorderSize = 0;
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Enter.ForeColor = System.Drawing.Color.Black;
            this.Enter.Location = new System.Drawing.Point(232, 125);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(50, 25);
            this.Enter.TabIndex = 13;
            this.Enter.Text = "輸入";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Input_col
            // 
            this.Input_col.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_col.FormattingEnabled = true;
            this.Input_col.Location = new System.Drawing.Point(114, 74);
            this.Input_col.Name = "Input_col";
            this.Input_col.Size = new System.Drawing.Size(120, 25);
            this.Input_col.TabIndex = 15;
            this.Input_col.SelectedIndexChanged += new System.EventHandler(this.Input_col_SelectedIndexChanged);
            this.Input_col.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_col_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "輸入欄位";
            // 
            // AddNewCol
            // 
            this.AddNewCol.BackColor = System.Drawing.Color.White;
            this.AddNewCol.FlatAppearance.BorderSize = 0;
            this.AddNewCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewCol.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AddNewCol.ForeColor = System.Drawing.Color.Black;
            this.AddNewCol.Location = new System.Drawing.Point(239, 32);
            this.AddNewCol.Name = "AddNewCol";
            this.AddNewCol.Size = new System.Drawing.Size(50, 25);
            this.AddNewCol.TabIndex = 18;
            this.AddNewCol.Text = "新增";
            this.AddNewCol.UseVisualStyleBackColor = false;
            this.AddNewCol.Click += new System.EventHandler(this.AddNewCol_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "欄位新增";
            // 
            // NewCol_Name
            // 
            this.NewCol_Name.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NewCol_Name.Location = new System.Drawing.Point(114, 32);
            this.NewCol_Name.Name = "NewCol_Name";
            this.NewCol_Name.Size = new System.Drawing.Size(120, 25);
            this.NewCol_Name.TabIndex = 16;
            this.NewCol_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewCol_Name_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Input_col);
            this.groupBox2.Controls.Add(this.AddNewCol);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.NewCol_Name);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(592, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 123);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "資料設定";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.limit);
            this.groupBox3.Controls.Add(this.Input_Limit);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.last5);
            this.groupBox3.Controls.Add(this.Enter);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.names_com);
            this.groupBox3.Controls.Add(this.score);
            this.groupBox3.Controls.Add(this.search);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(592, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 180);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "資料編修";
            // 
            // limit
            // 
            this.limit.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.limit.Location = new System.Drawing.Point(368, 44);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(92, 25);
            this.limit.TabIndex = 15;
            this.limit.Text = "100";
            this.limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Input_Limit
            // 
            this.Input_Limit.AutoSize = true;
            this.Input_Limit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_Limit.Location = new System.Drawing.Point(368, 23);
            this.Input_Limit.Name = "Input_Limit";
            this.Input_Limit.Size = new System.Drawing.Size(92, 24);
            this.Input_Limit.TabIndex = 14;
            this.Input_Limit.Text = "驗證輸入";
            this.Input_Limit.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Score.Properties.Resources._70101670_p0_master1200;
            this.pictureBox2.InitialImage = global::Score.Properties.Resources.by_nc_sa;
            this.pictureBox2.Location = new System.Drawing.Point(368, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(597, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(360, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Design By Kiyohime - CC BY-NC-SA 3.0 TW";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Score.Properties.Resources.by_nc_sa;
            this.pictureBox1.InitialImage = global::Score.Properties.Resources.by_nc_sa;
            this.pictureBox1.Location = new System.Drawing.Point(971, 499);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1097, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "快速成績輸入系統 V1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox last5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IPath;
        private System.Windows.Forms.Button ReadCSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OBrowse;
        private System.Windows.Forms.TextBox OPath;
        private System.Windows.Forms.Button IBrowse;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox names_com;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cutting_word;
        private System.Windows.Forms.ComboBox Input_col;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddNewCol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NewCol_Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox limit;
        private System.Windows.Forms.CheckBox Input_Limit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

