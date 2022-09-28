namespace H_0919_Hello
{
    partial class H0919_Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H0919_Hello));
            this.btn_Hello = new System.Windows.Forms.Button();
            this.btn_SayHi = new System.Windows.Forms.Button();
            this.LabName = new System.Windows.Forms.Label();
            this.labEngName = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labStar = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxEName = new System.Windows.Forms.TextBox();
            this.txtBoxSex = new System.Windows.Forms.TextBox();
            this.txtBoxStar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Hello
            // 
            this.btn_Hello.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Hello.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hello.Image")));
            this.btn_Hello.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Hello.Location = new System.Drawing.Point(55, 377);
            this.btn_Hello.Name = "btn_Hello";
            this.btn_Hello.Size = new System.Drawing.Size(100, 30);
            this.btn_Hello.TabIndex = 0;
            this.btn_Hello.Text = "Say Hello!!";
            this.btn_Hello.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Hello.UseVisualStyleBackColor = false;
            this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
            this.btn_Hello.MouseEnter += new System.EventHandler(this.btn_Hello_MouseEnter);
            this.btn_Hello.MouseLeave += new System.EventHandler(this.btn_Hello_MouseLeave);
            // 
            // btn_SayHi
            // 
            this.btn_SayHi.Image = ((System.Drawing.Image)(resources.GetObject("btn_SayHi.Image")));
            this.btn_SayHi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SayHi.Location = new System.Drawing.Point(199, 377);
            this.btn_SayHi.Name = "btn_SayHi";
            this.btn_SayHi.Size = new System.Drawing.Size(100, 30);
            this.btn_SayHi.TabIndex = 0;
            this.btn_SayHi.Text = "Say Hill!!";
            this.btn_SayHi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SayHi.UseVisualStyleBackColor = true;
            this.btn_SayHi.Click += new System.EventHandler(this.btn_SayHi_Click);
            this.btn_SayHi.MouseEnter += new System.EventHandler(this.btn_SayHi_MouseEnter);
            this.btn_SayHi.MouseLeave += new System.EventHandler(this.btn_SayHi_MouseLeave);
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabName.Location = new System.Drawing.Point(50, 70);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(59, 26);
            this.LabName.TabIndex = 1;
            this.LabName.Text = "姓名:";
            // 
            // labEngName
            // 
            this.labEngName.AutoSize = true;
            this.labEngName.BackColor = System.Drawing.Color.Transparent;
            this.labEngName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEngName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labEngName.Location = new System.Drawing.Point(50, 126);
            this.labEngName.Name = "labEngName";
            this.labEngName.Size = new System.Drawing.Size(152, 26);
            this.labEngName.TabIndex = 1;
            this.labEngName.Text = "EnglishName:";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.Color.Transparent;
            this.labGender.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labGender.Location = new System.Drawing.Point(50, 184);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(59, 26);
            this.labGender.TabIndex = 1;
            this.labGender.Text = "性別:";
            // 
            // labStar
            // 
            this.labStar.AutoSize = true;
            this.labStar.BackColor = System.Drawing.Color.Transparent;
            this.labStar.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labStar.Location = new System.Drawing.Point(50, 241);
            this.labStar.Name = "labStar";
            this.labStar.Size = new System.Drawing.Size(59, 26);
            this.labStar.TabIndex = 1;
            this.labStar.Text = "星座:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(199, 70);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxName.TabIndex = 2;
            // 
            // txtBoxEName
            // 
            this.txtBoxEName.Location = new System.Drawing.Point(199, 126);
            this.txtBoxEName.Name = "txtBoxEName";
            this.txtBoxEName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxEName.TabIndex = 2;
            // 
            // txtBoxSex
            // 
            this.txtBoxSex.Location = new System.Drawing.Point(199, 184);
            this.txtBoxSex.Name = "txtBoxSex";
            this.txtBoxSex.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSex.TabIndex = 2;
            // 
            // txtBoxStar
            // 
            this.txtBoxStar.Location = new System.Drawing.Point(199, 241);
            this.txtBoxStar.Name = "txtBoxStar";
            this.txtBoxStar.Size = new System.Drawing.Size(100, 22);
            this.txtBoxStar.TabIndex = 2;
            // 
            // H0919_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.txtBoxStar);
            this.Controls.Add(this.txtBoxSex);
            this.Controls.Add(this.txtBoxEName);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.labStar);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labEngName);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.btn_SayHi);
            this.Controls.Add(this.btn_Hello);
            this.Name = "H0919_Hello";
            this.Text = "你好!C#";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Hello;
        private System.Windows.Forms.Button btn_SayHi;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Label labEngName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labStar;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxEName;
        private System.Windows.Forms.TextBox txtBoxSex;
        private System.Windows.Forms.TextBox txtBoxStar;
    }
}

