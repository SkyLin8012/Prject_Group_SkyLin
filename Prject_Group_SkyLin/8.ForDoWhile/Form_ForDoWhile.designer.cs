namespace H_0926_ForDoWhile
{
    partial class Form_Method
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
            this.lab_arrynumtitle = new System.Windows.Forms.Label();
            this.txt_EnterNumber = new System.Windows.Forms.TextBox();
            this.btn_statistics_OddEven = new System.Windows.Forms.Button();
            this.btn_enternumber_OddorEven = new System.Windows.Forms.Button();
            this.btn_array_maxlongname = new System.Windows.Forms.Button();
            this.btn_array_MaxMin = new System.Windows.Forms.Button();
            this.btn_CinArray = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lab_Result = new System.Windows.Forms.Label();
            this.lab_Show_Rresult = new System.Windows.Forms.Label();
            this.btn_2Darry_SideLineIs1 = new System.Windows.Forms.Button();
            this.btn_2Darry_SideLineIs0 = new System.Windows.Forms.Button();
            this.btn_2Darry_content01 = new System.Windows.Forms.Button();
            this.txt_From_val = new System.Windows.Forms.TextBox();
            this.txt_To_val = new System.Windows.Forms.TextBox();
            this.txt_Step_val = new System.Windows.Forms.TextBox();
            this.lab_From_title = new System.Windows.Forms.Label();
            this.lab_To_title = new System.Windows.Forms.Label();
            this.lab_Step_title = new System.Windows.Forms.Label();
            this.btn_for = new System.Windows.Forms.Button();
            this.btn_while = new System.Windows.Forms.Button();
            this.btn_do = new System.Windows.Forms.Button();
            this.btn_Swap_int_str = new System.Windows.Forms.Button();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.lab_Rows_title = new System.Windows.Forms.Label();
            this.txt_treeRows_val = new System.Windows.Forms.TextBox();
            this.btn_100_binary = new System.Windows.Forms.Button();
            this.btn_lotto = new System.Windows.Forms.Button();
            this.btn_99Table = new System.Windows.Forms.Button();
            this.btn_rightangle_tree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_arrynumtitle
            // 
            this.lab_arrynumtitle.AutoSize = true;
            this.lab_arrynumtitle.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_arrynumtitle.Location = new System.Drawing.Point(28, 25);
            this.lab_arrynumtitle.Name = "lab_arrynumtitle";
            this.lab_arrynumtitle.Size = new System.Drawing.Size(70, 19);
            this.lab_arrynumtitle.TabIndex = 0;
            this.lab_arrynumtitle.Text = "Number:";
            // 
            // txt_EnterNumber
            // 
            this.txt_EnterNumber.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_EnterNumber.Location = new System.Drawing.Point(95, 21);
            this.txt_EnterNumber.Name = "txt_EnterNumber";
            this.txt_EnterNumber.Size = new System.Drawing.Size(72, 27);
            this.txt_EnterNumber.TabIndex = 1;
            // 
            // btn_statistics_OddEven
            // 
            this.btn_statistics_OddEven.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_statistics_OddEven.Location = new System.Drawing.Point(173, 22);
            this.btn_statistics_OddEven.Name = "btn_statistics_OddEven";
            this.btn_statistics_OddEven.Size = new System.Drawing.Size(193, 50);
            this.btn_statistics_OddEven.TabIndex = 2;
            this.btn_statistics_OddEven.Text = "陣列arr0926[]統計奇偶的數目";
            this.btn_statistics_OddEven.UseVisualStyleBackColor = true;
            this.btn_statistics_OddEven.Click += new System.EventHandler(this.btn_statistics_OddEven_Click);
            // 
            // btn_enternumber_OddorEven
            // 
            this.btn_enternumber_OddorEven.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_enternumber_OddorEven.Location = new System.Drawing.Point(30, 50);
            this.btn_enternumber_OddorEven.Name = "btn_enternumber_OddorEven";
            this.btn_enternumber_OddorEven.Size = new System.Drawing.Size(137, 52);
            this.btn_enternumber_OddorEven.TabIndex = 2;
            this.btn_enternumber_OddorEven.Text = "輸入的數為奇數或偶數?";
            this.btn_enternumber_OddorEven.UseVisualStyleBackColor = true;
            this.btn_enternumber_OddorEven.Click += new System.EventHandler(this.btn_enternumber_OddorEven_Click);
            // 
            // btn_array_maxlongname
            // 
            this.btn_array_maxlongname.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_array_maxlongname.Location = new System.Drawing.Point(173, 78);
            this.btn_array_maxlongname.Name = "btn_array_maxlongname";
            this.btn_array_maxlongname.Size = new System.Drawing.Size(193, 24);
            this.btn_array_maxlongname.TabIndex = 2;
            this.btn_array_maxlongname.Text = "陣列arr0926_Str[]最長的名字";
            this.btn_array_maxlongname.UseVisualStyleBackColor = true;
            this.btn_array_maxlongname.Click += new System.EventHandler(this.btn_array_maxlongname_Click);
            // 
            // btn_array_MaxMin
            // 
            this.btn_array_MaxMin.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_array_MaxMin.Location = new System.Drawing.Point(30, 118);
            this.btn_array_MaxMin.Name = "btn_array_MaxMin";
            this.btn_array_MaxMin.Size = new System.Drawing.Size(175, 25);
            this.btn_array_MaxMin.TabIndex = 2;
            this.btn_array_MaxMin.Text = "陣列arr0926[]最大/最小";
            this.btn_array_MaxMin.UseVisualStyleBackColor = true;
            this.btn_array_MaxMin.Click += new System.EventHandler(this.btn_array_MaxMin_Click);
            // 
            // btn_CinArray
            // 
            this.btn_CinArray.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CinArray.Location = new System.Drawing.Point(30, 149);
            this.btn_CinArray.Name = "btn_CinArray";
            this.btn_CinArray.Size = new System.Drawing.Size(336, 28);
            this.btn_CinArray.TabIndex = 2;
            this.btn_CinArray.Text = "陣列arry0926_Str[]xue\"C\"OR\"c\"的字樣有幾個";
            this.btn_CinArray.UseVisualStyleBackColor = true;
            this.btn_CinArray.Click += new System.EventHandler(this.btn_CinArray_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.Location = new System.Drawing.Point(117, 183);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 60);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "清空結果欄";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lab_Result
            // 
            this.lab_Result.AutoSize = true;
            this.lab_Result.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Result.Location = new System.Drawing.Point(28, 250);
            this.lab_Result.Name = "lab_Result";
            this.lab_Result.Size = new System.Drawing.Size(81, 24);
            this.lab_Result.TabIndex = 0;
            this.lab_Result.Text = "Result:";
            // 
            // lab_Show_Rresult
            // 
            this.lab_Show_Rresult.AutoSize = true;
            this.lab_Show_Rresult.BackColor = System.Drawing.Color.LemonChiffon;
            this.lab_Show_Rresult.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Show_Rresult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lab_Show_Rresult.Location = new System.Drawing.Point(28, 280);
            this.lab_Show_Rresult.Name = "lab_Show_Rresult";
            this.lab_Show_Rresult.Size = new System.Drawing.Size(39, 19);
            this.lab_Show_Rresult.TabIndex = 0;
            this.lab_Show_Rresult.Text = "結果";
            // 
            // btn_2Darry_SideLineIs1
            // 
            this.btn_2Darry_SideLineIs1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_2Darry_SideLineIs1.Location = new System.Drawing.Point(383, 22);
            this.btn_2Darry_SideLineIs1.Name = "btn_2Darry_SideLineIs1";
            this.btn_2Darry_SideLineIs1.Size = new System.Drawing.Size(168, 26);
            this.btn_2Darry_SideLineIs1.TabIndex = 2;
            this.btn_2Darry_SideLineIs1.Text = "[10,10]二維陣列-邊1,內0";
            this.btn_2Darry_SideLineIs1.UseVisualStyleBackColor = true;
            this.btn_2Darry_SideLineIs1.Click += new System.EventHandler(this.btn_2Darry_SideLineIs1_Click);
            // 
            // btn_2Darry_SideLineIs0
            // 
            this.btn_2Darry_SideLineIs0.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_2Darry_SideLineIs0.Location = new System.Drawing.Point(384, 51);
            this.btn_2Darry_SideLineIs0.Name = "btn_2Darry_SideLineIs0";
            this.btn_2Darry_SideLineIs0.Size = new System.Drawing.Size(168, 31);
            this.btn_2Darry_SideLineIs0.TabIndex = 2;
            this.btn_2Darry_SideLineIs0.Text = "[10,10]二維陣列-邊0,內1";
            this.btn_2Darry_SideLineIs0.UseVisualStyleBackColor = true;
            this.btn_2Darry_SideLineIs0.Click += new System.EventHandler(this.btn_2Darry_SideLineIs0_Click);
            // 
            // btn_2Darry_content01
            // 
            this.btn_2Darry_content01.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_2Darry_content01.Location = new System.Drawing.Point(383, 88);
            this.btn_2Darry_content01.Name = "btn_2Darry_content01";
            this.btn_2Darry_content01.Size = new System.Drawing.Size(168, 87);
            this.btn_2Darry_content01.TabIndex = 2;
            this.btn_2Darry_content01.Text = "[10,10]二維陣列 \r\n       101010 \r\n        010101 \r\n            ....";
            this.btn_2Darry_content01.UseVisualStyleBackColor = true;
            this.btn_2Darry_content01.Click += new System.EventHandler(this.btn_2Darry_content01_Click);
            // 
            // txt_From_val
            // 
            this.txt_From_val.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_From_val.Location = new System.Drawing.Point(429, 185);
            this.txt_From_val.Name = "txt_From_val";
            this.txt_From_val.Size = new System.Drawing.Size(62, 27);
            this.txt_From_val.TabIndex = 1;
            // 
            // txt_To_val
            // 
            this.txt_To_val.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_To_val.Location = new System.Drawing.Point(429, 215);
            this.txt_To_val.Name = "txt_To_val";
            this.txt_To_val.Size = new System.Drawing.Size(62, 27);
            this.txt_To_val.TabIndex = 1;
            // 
            // txt_Step_val
            // 
            this.txt_Step_val.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Step_val.Location = new System.Drawing.Point(429, 244);
            this.txt_Step_val.Name = "txt_Step_val";
            this.txt_Step_val.Size = new System.Drawing.Size(62, 27);
            this.txt_Step_val.TabIndex = 1;
            // 
            // lab_From_title
            // 
            this.lab_From_title.AutoSize = true;
            this.lab_From_title.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_From_title.Location = new System.Drawing.Point(384, 188);
            this.lab_From_title.Name = "lab_From_title";
            this.lab_From_title.Size = new System.Drawing.Size(49, 19);
            this.lab_From_title.TabIndex = 0;
            this.lab_From_title.Text = "From:";
            // 
            // lab_To_title
            // 
            this.lab_To_title.AutoSize = true;
            this.lab_To_title.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_To_title.Location = new System.Drawing.Point(384, 218);
            this.lab_To_title.Name = "lab_To_title";
            this.lab_To_title.Size = new System.Drawing.Size(32, 19);
            this.lab_To_title.TabIndex = 0;
            this.lab_To_title.Text = "TO:";
            // 
            // lab_Step_title
            // 
            this.lab_Step_title.AutoSize = true;
            this.lab_Step_title.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Step_title.Location = new System.Drawing.Point(385, 248);
            this.lab_Step_title.Name = "lab_Step_title";
            this.lab_Step_title.Size = new System.Drawing.Size(43, 19);
            this.lab_Step_title.TabIndex = 0;
            this.lab_Step_title.Text = "Step:";
            // 
            // btn_for
            // 
            this.btn_for.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_for.Location = new System.Drawing.Point(497, 185);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(55, 23);
            this.btn_for.TabIndex = 3;
            this.btn_for.Text = "for";
            this.btn_for.UseVisualStyleBackColor = true;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // btn_while
            // 
            this.btn_while.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_while.Location = new System.Drawing.Point(497, 214);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(55, 23);
            this.btn_while.TabIndex = 3;
            this.btn_while.Text = "while";
            this.btn_while.UseVisualStyleBackColor = true;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // btn_do
            // 
            this.btn_do.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_do.Location = new System.Drawing.Point(497, 245);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(55, 23);
            this.btn_do.TabIndex = 3;
            this.btn_do.Text = "do";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // btn_Swap_int_str
            // 
            this.btn_Swap_int_str.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Swap_int_str.Location = new System.Drawing.Point(567, 23);
            this.btn_Swap_int_str.Name = "btn_Swap_int_str";
            this.btn_Swap_int_str.Size = new System.Drawing.Size(275, 31);
            this.btn_Swap_int_str.TabIndex = 2;
            this.btn_Swap_int_str.Text = "Swap[int,int] and [str,str]";
            this.btn_Swap_int_str.UseVisualStyleBackColor = true;
            this.btn_Swap_int_str.Click += new System.EventHandler(this.btn_Swap_int_str_Click);
            // 
            // btn_Sum
            // 
            this.btn_Sum.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Sum.Location = new System.Drawing.Point(567, 61);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(168, 31);
            this.btn_Sum.TabIndex = 2;
            this.btn_Sum.Text = "Sum(陣列arr0926[])";
            this.btn_Sum.UseVisualStyleBackColor = true;
            this.btn_Sum.Click += new System.EventHandler(this.btn_Sum_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Max.Location = new System.Drawing.Point(567, 98);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(168, 31);
            this.btn_Max.TabIndex = 2;
            this.btn_Max.Text = "Max(陣列arr0926[])";
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Min.Location = new System.Drawing.Point(568, 137);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(168, 31);
            this.btn_Min.TabIndex = 2;
            this.btn_Min.Text = "Min(陣列arr0926[])";
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // lab_Rows_title
            // 
            this.lab_Rows_title.AutoSize = true;
            this.lab_Rows_title.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Rows_title.Location = new System.Drawing.Point(565, 184);
            this.lab_Rows_title.Name = "lab_Rows_title";
            this.lab_Rows_title.Size = new System.Drawing.Size(42, 19);
            this.lab_Rows_title.TabIndex = 0;
            this.lab_Rows_title.Text = "樹高:";
            // 
            // txt_treeRows_val
            // 
            this.txt_treeRows_val.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_treeRows_val.Location = new System.Drawing.Point(618, 179);
            this.txt_treeRows_val.Name = "txt_treeRows_val";
            this.txt_treeRows_val.Size = new System.Drawing.Size(92, 27);
            this.txt_treeRows_val.TabIndex = 1;
            // 
            // btn_100_binary
            // 
            this.btn_100_binary.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_100_binary.Location = new System.Drawing.Point(568, 217);
            this.btn_100_binary.Name = "btn_100_binary";
            this.btn_100_binary.Size = new System.Drawing.Size(142, 25);
            this.btn_100_binary.TabIndex = 2;
            this.btn_100_binary.Text = "100的二進位是?";
            this.btn_100_binary.UseVisualStyleBackColor = true;
            this.btn_100_binary.Click += new System.EventHandler(this.btn_100_binary_Click);
            // 
            // btn_lotto
            // 
            this.btn_lotto.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_lotto.Location = new System.Drawing.Point(718, 218);
            this.btn_lotto.Name = "btn_lotto";
            this.btn_lotto.Size = new System.Drawing.Size(131, 52);
            this.btn_lotto.TabIndex = 2;
            this.btn_lotto.Text = "樂透int[]號碼不重複";
            this.btn_lotto.UseVisualStyleBackColor = true;
            this.btn_lotto.Click += new System.EventHandler(this.btn_lotto_Click);
            // 
            // btn_99Table
            // 
            this.btn_99Table.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_99Table.Location = new System.Drawing.Point(568, 246);
            this.btn_99Table.Name = "btn_99Table";
            this.btn_99Table.Size = new System.Drawing.Size(142, 25);
            this.btn_99Table.TabIndex = 2;
            this.btn_99Table.Text = "九九乘法表";
            this.btn_99Table.UseVisualStyleBackColor = true;
            this.btn_99Table.Click += new System.EventHandler(this.btn_99Table_Click);
            // 
            // btn_rightangle_tree
            // 
            this.btn_rightangle_tree.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_rightangle_tree.Location = new System.Drawing.Point(716, 178);
            this.btn_rightangle_tree.Name = "btn_rightangle_tree";
            this.btn_rightangle_tree.Size = new System.Drawing.Size(133, 30);
            this.btn_rightangle_tree.TabIndex = 2;
            this.btn_rightangle_tree.Text = "直角聖誕樹";
            this.btn_rightangle_tree.UseVisualStyleBackColor = true;
            this.btn_rightangle_tree.Click += new System.EventHandler(this.btn_rightangle_tree_Click);
            // 
            // Form_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 511);
            this.Controls.Add(this.btn_do);
            this.Controls.Add(this.btn_while);
            this.Controls.Add(this.btn_for);
            this.Controls.Add(this.btn_enternumber_OddorEven);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_CinArray);
            this.Controls.Add(this.btn_array_MaxMin);
            this.Controls.Add(this.btn_array_maxlongname);
            this.Controls.Add(this.btn_2Darry_content01);
            this.Controls.Add(this.btn_2Darry_SideLineIs0);
            this.Controls.Add(this.btn_rightangle_tree);
            this.Controls.Add(this.btn_99Table);
            this.Controls.Add(this.btn_lotto);
            this.Controls.Add(this.btn_100_binary);
            this.Controls.Add(this.btn_Min);
            this.Controls.Add(this.btn_Max);
            this.Controls.Add(this.btn_Sum);
            this.Controls.Add(this.btn_Swap_int_str);
            this.Controls.Add(this.btn_2Darry_SideLineIs1);
            this.Controls.Add(this.btn_statistics_OddEven);
            this.Controls.Add(this.txt_Step_val);
            this.Controls.Add(this.txt_To_val);
            this.Controls.Add(this.txt_treeRows_val);
            this.Controls.Add(this.txt_From_val);
            this.Controls.Add(this.txt_EnterNumber);
            this.Controls.Add(this.lab_Show_Rresult);
            this.Controls.Add(this.lab_Result);
            this.Controls.Add(this.lab_Step_title);
            this.Controls.Add(this.lab_Rows_title);
            this.Controls.Add(this.lab_To_title);
            this.Controls.Add(this.lab_From_title);
            this.Controls.Add(this.lab_arrynumtitle);
            this.Name = "Form_Method";
            this.Text = "H0926_Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_arrynumtitle;
        private System.Windows.Forms.TextBox txt_EnterNumber;
        private System.Windows.Forms.Button btn_statistics_OddEven;
        private System.Windows.Forms.Button btn_enternumber_OddorEven;
        private System.Windows.Forms.Button btn_array_maxlongname;
        private System.Windows.Forms.Button btn_array_MaxMin;
        private System.Windows.Forms.Button btn_CinArray;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lab_Result;
        private System.Windows.Forms.Label lab_Show_Rresult;
        private System.Windows.Forms.Button btn_2Darry_SideLineIs1;
        private System.Windows.Forms.Button btn_2Darry_SideLineIs0;
        private System.Windows.Forms.Button btn_2Darry_content01;
        private System.Windows.Forms.TextBox txt_From_val;
        private System.Windows.Forms.TextBox txt_To_val;
        private System.Windows.Forms.TextBox txt_Step_val;
        private System.Windows.Forms.Label lab_From_title;
        private System.Windows.Forms.Label lab_To_title;
        private System.Windows.Forms.Label lab_Step_title;
        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.Button btn_Swap_int_str;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Label lab_Rows_title;
        private System.Windows.Forms.TextBox txt_treeRows_val;
        private System.Windows.Forms.Button btn_100_binary;
        private System.Windows.Forms.Button btn_lotto;
        private System.Windows.Forms.Button btn_99Table;
        private System.Windows.Forms.Button btn_rightangle_tree;
    }
}

