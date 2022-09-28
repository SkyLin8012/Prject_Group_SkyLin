namespace H_0921_POS
{
    partial class Bar_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bar_POS));
            this.groupBox_Menu = new System.Windows.Forms.GroupBox();
            this.btn_Wine = new System.Windows.Forms.Button();
            this.btn_Whisky = new System.Windows.Forms.Button();
            this.btn_Tequila = new System.Windows.Forms.Button();
            this.btn_Beer = new System.Windows.Forms.Button();
            this.grobox_shopList = new System.Windows.Forms.GroupBox();
            this.btn_clearList = new System.Windows.Forms.Button();
            this.richtxt_List = new System.Windows.Forms.RichTextBox();
            this.grobox_ToPri = new System.Windows.Forms.GroupBox();
            this.txt_ToPri = new System.Windows.Forms.TextBox();
            this.grobox_paymethol = new System.Windows.Forms.GroupBox();
            this.btn_credit = new System.Windows.Forms.Button();
            this.btn_cash = new System.Windows.Forms.Button();
            this.lab_craditInfo = new System.Windows.Forms.Label();
            this.groupBox_Menu.SuspendLayout();
            this.grobox_shopList.SuspendLayout();
            this.grobox_ToPri.SuspendLayout();
            this.grobox_paymethol.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Menu
            // 
            this.groupBox_Menu.Controls.Add(this.btn_Wine);
            this.groupBox_Menu.Controls.Add(this.btn_Whisky);
            this.groupBox_Menu.Controls.Add(this.btn_Tequila);
            this.groupBox_Menu.Controls.Add(this.btn_Beer);
            this.groupBox_Menu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Menu.Location = new System.Drawing.Point(26, 45);
            this.groupBox_Menu.Name = "groupBox_Menu";
            this.groupBox_Menu.Size = new System.Drawing.Size(223, 336);
            this.groupBox_Menu.TabIndex = 0;
            this.groupBox_Menu.TabStop = false;
            this.groupBox_Menu.Text = "菜單Menu";
            // 
            // btn_Wine
            // 
            this.btn_Wine.BackColor = System.Drawing.Color.White;
            this.btn_Wine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Wine.BackgroundImage")));
            this.btn_Wine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Wine.ForeColor = System.Drawing.Color.Black;
            this.btn_Wine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Wine.Location = new System.Drawing.Point(115, 171);
            this.btn_Wine.Name = "btn_Wine";
            this.btn_Wine.Size = new System.Drawing.Size(93, 118);
            this.btn_Wine.TabIndex = 0;
            this.btn_Wine.Text = "紅酒";
            this.btn_Wine.UseVisualStyleBackColor = false;
            this.btn_Wine.Click += new System.EventHandler(this.btn_Wine_Click);
            // 
            // btn_Whisky
            // 
            this.btn_Whisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Whisky.BackgroundImage")));
            this.btn_Whisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Whisky.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Whisky.Location = new System.Drawing.Point(12, 171);
            this.btn_Whisky.Name = "btn_Whisky";
            this.btn_Whisky.Size = new System.Drawing.Size(93, 118);
            this.btn_Whisky.TabIndex = 0;
            this.btn_Whisky.Text = "威士忌";
            this.btn_Whisky.UseVisualStyleBackColor = true;
            this.btn_Whisky.Click += new System.EventHandler(this.btn_Whisky_Click);
            // 
            // btn_Tequila
            // 
            this.btn_Tequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tequila.BackgroundImage")));
            this.btn_Tequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tequila.Location = new System.Drawing.Point(115, 47);
            this.btn_Tequila.Name = "btn_Tequila";
            this.btn_Tequila.Size = new System.Drawing.Size(93, 118);
            this.btn_Tequila.TabIndex = 0;
            this.btn_Tequila.Text = "龍舌蘭";
            this.btn_Tequila.UseVisualStyleBackColor = true;
            this.btn_Tequila.Click += new System.EventHandler(this.btn_Tequila_Click);
            // 
            // btn_Beer
            // 
            this.btn_Beer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Beer.BackgroundImage")));
            this.btn_Beer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Beer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Beer.Location = new System.Drawing.Point(12, 47);
            this.btn_Beer.Name = "btn_Beer";
            this.btn_Beer.Size = new System.Drawing.Size(93, 118);
            this.btn_Beer.TabIndex = 0;
            this.btn_Beer.Text = "啤酒";
            this.btn_Beer.UseVisualStyleBackColor = true;
            this.btn_Beer.Click += new System.EventHandler(this.btn_Beer_Click);
            // 
            // grobox_shopList
            // 
            this.grobox_shopList.Controls.Add(this.btn_clearList);
            this.grobox_shopList.Controls.Add(this.richtxt_List);
            this.grobox_shopList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grobox_shopList.Location = new System.Drawing.Point(532, 46);
            this.grobox_shopList.Name = "grobox_shopList";
            this.grobox_shopList.Size = new System.Drawing.Size(246, 336);
            this.grobox_shopList.TabIndex = 1;
            this.grobox_shopList.TabStop = false;
            this.grobox_shopList.Text = "購物清單 List";
            // 
            // btn_clearList
            // 
            this.btn_clearList.Location = new System.Drawing.Point(117, 295);
            this.btn_clearList.Name = "btn_clearList";
            this.btn_clearList.Size = new System.Drawing.Size(112, 35);
            this.btn_clearList.TabIndex = 1;
            this.btn_clearList.Text = "清除表單";
            this.btn_clearList.UseVisualStyleBackColor = true;
            this.btn_clearList.Click += new System.EventHandler(this.btn_clearList_Click);
            // 
            // richtxt_List
            // 
            this.richtxt_List.Location = new System.Drawing.Point(20, 46);
            this.richtxt_List.Name = "richtxt_List";
            this.richtxt_List.Size = new System.Drawing.Size(209, 242);
            this.richtxt_List.TabIndex = 0;
            this.richtxt_List.Text = "";
            // 
            // grobox_ToPri
            // 
            this.grobox_ToPri.Controls.Add(this.txt_ToPri);
            this.grobox_ToPri.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grobox_ToPri.Location = new System.Drawing.Point(255, 46);
            this.grobox_ToPri.Name = "grobox_ToPri";
            this.grobox_ToPri.Size = new System.Drawing.Size(271, 113);
            this.grobox_ToPri.TabIndex = 1;
            this.grobox_ToPri.TabStop = false;
            this.grobox_ToPri.Text = "總金額 Total Price";
            // 
            // txt_ToPri
            // 
            this.txt_ToPri.BackColor = System.Drawing.Color.Black;
            this.txt_ToPri.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ToPri.ForeColor = System.Drawing.Color.White;
            this.txt_ToPri.Location = new System.Drawing.Point(18, 46);
            this.txt_ToPri.Name = "txt_ToPri";
            this.txt_ToPri.Size = new System.Drawing.Size(234, 33);
            this.txt_ToPri.TabIndex = 0;
            // 
            // grobox_paymethol
            // 
            this.grobox_paymethol.Controls.Add(this.btn_credit);
            this.grobox_paymethol.Controls.Add(this.btn_cash);
            this.grobox_paymethol.Controls.Add(this.lab_craditInfo);
            this.grobox_paymethol.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grobox_paymethol.Location = new System.Drawing.Point(255, 165);
            this.grobox_paymethol.Name = "grobox_paymethol";
            this.grobox_paymethol.Size = new System.Drawing.Size(271, 216);
            this.grobox_paymethol.TabIndex = 1;
            this.grobox_paymethol.TabStop = false;
            this.grobox_paymethol.Text = "付款方式";
            // 
            // btn_credit
            // 
            this.btn_credit.Location = new System.Drawing.Point(142, 51);
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.Size = new System.Drawing.Size(112, 47);
            this.btn_credit.TabIndex = 1;
            this.btn_credit.Text = "信用卡";
            this.btn_credit.UseVisualStyleBackColor = true;
            this.btn_credit.Click += new System.EventHandler(this.btn_credit_Click);
            // 
            // btn_cash
            // 
            this.btn_cash.Location = new System.Drawing.Point(18, 51);
            this.btn_cash.Name = "btn_cash";
            this.btn_cash.Size = new System.Drawing.Size(112, 47);
            this.btn_cash.TabIndex = 1;
            this.btn_cash.Text = "現金";
            this.btn_cash.UseVisualStyleBackColor = true;
            this.btn_cash.Click += new System.EventHandler(this.btn_cash_Click);
            // 
            // lab_craditInfo
            // 
            this.lab_craditInfo.AutoSize = true;
            this.lab_craditInfo.Location = new System.Drawing.Point(138, 121);
            this.lab_craditInfo.Name = "lab_craditInfo";
            this.lab_craditInfo.Size = new System.Drawing.Size(114, 21);
            this.lab_craditInfo.TabIndex = 0;
            this.lab_craditInfo.Text = "信用卡享九折!";
            // 
            // Bar_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.grobox_paymethol);
            this.Controls.Add(this.grobox_ToPri);
            this.Controls.Add(this.grobox_shopList);
            this.Controls.Add(this.groupBox_Menu);
            this.Name = "Bar_POS";
            this.RightToLeftLayout = true;
            this.Text = "Bar POS";
            this.Load += new System.EventHandler(this.Bar_POS_Load);
            this.groupBox_Menu.ResumeLayout(false);
            this.grobox_shopList.ResumeLayout(false);
            this.grobox_ToPri.ResumeLayout(false);
            this.grobox_ToPri.PerformLayout();
            this.grobox_paymethol.ResumeLayout(false);
            this.grobox_paymethol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Menu;
        private System.Windows.Forms.GroupBox grobox_shopList;
        private System.Windows.Forms.GroupBox grobox_ToPri;
        private System.Windows.Forms.GroupBox grobox_paymethol;
        private System.Windows.Forms.Button btn_Wine;
        private System.Windows.Forms.Button btn_Whisky;
        private System.Windows.Forms.Button btn_Tequila;
        private System.Windows.Forms.Button btn_Beer;
        private System.Windows.Forms.RichTextBox richtxt_List;
        private System.Windows.Forms.TextBox txt_ToPri;
        private System.Windows.Forms.Button btn_credit;
        private System.Windows.Forms.Button btn_cash;
        private System.Windows.Forms.Label lab_craditInfo;
        private System.Windows.Forms.Button btn_clearList;
    }
}

