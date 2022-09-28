namespace H_0927_MyClac
{
    partial class form_MyClac
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
            this.lab_Num1 = new System.Windows.Forms.Label();
            this.lab_Num2 = new System.Windows.Forms.Label();
            this.lab_dottedLine = new System.Windows.Forms.Label();
            this.lab_Answer = new System.Windows.Forms.Label();
            this.txt_Num1_val = new System.Windows.Forms.TextBox();
            this.txt_Num2_val = new System.Windows.Forms.TextBox();
            this.txt_Answer_val = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_mulitply = new System.Windows.Forms.Button();
            this.btn_Divided = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Num1
            // 
            this.lab_Num1.AutoSize = true;
            this.lab_Num1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Num1.Location = new System.Drawing.Point(80, 70);
            this.lab_Num1.Name = "lab_Num1";
            this.lab_Num1.Size = new System.Drawing.Size(53, 18);
            this.lab_Num1.TabIndex = 0;
            this.lab_Num1.Text = "Num1:";
            // 
            // lab_Num2
            // 
            this.lab_Num2.AutoSize = true;
            this.lab_Num2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Num2.Location = new System.Drawing.Point(80, 104);
            this.lab_Num2.Name = "lab_Num2";
            this.lab_Num2.Size = new System.Drawing.Size(53, 18);
            this.lab_Num2.TabIndex = 0;
            this.lab_Num2.Text = "Num2:";
            // 
            // lab_dottedLine
            // 
            this.lab_dottedLine.AutoSize = true;
            this.lab_dottedLine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_dottedLine.Location = new System.Drawing.Point(73, 138);
            this.lab_dottedLine.Name = "lab_dottedLine";
            this.lab_dottedLine.Size = new System.Drawing.Size(170, 18);
            this.lab_dottedLine.TabIndex = 0;
            this.lab_dottedLine.Text = "==================";
            // 
            // lab_Answer
            // 
            this.lab_Answer.AutoSize = true;
            this.lab_Answer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Answer.Location = new System.Drawing.Point(73, 173);
            this.lab_Answer.Name = "lab_Answer";
            this.lab_Answer.Size = new System.Drawing.Size(60, 18);
            this.lab_Answer.TabIndex = 0;
            this.lab_Answer.Text = "Answer";
            // 
            // txt_Num1_val
            // 
            this.txt_Num1_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num1_val.Location = new System.Drawing.Point(139, 67);
            this.txt_Num1_val.Name = "txt_Num1_val";
            this.txt_Num1_val.Size = new System.Drawing.Size(77, 26);
            this.txt_Num1_val.TabIndex = 1;
            // 
            // txt_Num2_val
            // 
            this.txt_Num2_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num2_val.Location = new System.Drawing.Point(139, 101);
            this.txt_Num2_val.Name = "txt_Num2_val";
            this.txt_Num2_val.Size = new System.Drawing.Size(77, 26);
            this.txt_Num2_val.TabIndex = 1;
            // 
            // txt_Answer_val
            // 
            this.txt_Answer_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Answer_val.Location = new System.Drawing.Point(139, 165);
            this.txt_Answer_val.Name = "txt_Answer_val";
            this.txt_Answer_val.Size = new System.Drawing.Size(77, 26);
            this.txt_Answer_val.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(232, 30);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(50, 31);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "+";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.ForeColor = System.Drawing.Color.Black;
            this.btn_minus.Location = new System.Drawing.Point(232, 64);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(50, 31);
            this.btn_minus.TabIndex = 2;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_mulitply
            // 
            this.btn_mulitply.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mulitply.ForeColor = System.Drawing.Color.Black;
            this.btn_mulitply.Location = new System.Drawing.Point(232, 101);
            this.btn_mulitply.Name = "btn_mulitply";
            this.btn_mulitply.Size = new System.Drawing.Size(50, 31);
            this.btn_mulitply.TabIndex = 2;
            this.btn_mulitply.Text = "*";
            this.btn_mulitply.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_mulitply.UseVisualStyleBackColor = true;
            this.btn_mulitply.Click += new System.EventHandler(this.btn_mulitply_Click);
            // 
            // btn_Divided
            // 
            this.btn_Divided.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Divided.ForeColor = System.Drawing.Color.Black;
            this.btn_Divided.Location = new System.Drawing.Point(232, 165);
            this.btn_Divided.Name = "btn_Divided";
            this.btn_Divided.Size = new System.Drawing.Size(50, 31);
            this.btn_Divided.TabIndex = 2;
            this.btn_Divided.Text = "/";
            this.btn_Divided.UseVisualStyleBackColor = true;
            this.btn_Divided.Click += new System.EventHandler(this.btn_Divided_Click);
            // 
            // form_MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 267);
            this.Controls.Add(this.btn_Divided);
            this.Controls.Add(this.btn_mulitply);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Answer_val);
            this.Controls.Add(this.txt_Num2_val);
            this.Controls.Add(this.txt_Num1_val);
            this.Controls.Add(this.lab_dottedLine);
            this.Controls.Add(this.lab_Answer);
            this.Controls.Add(this.lab_Num2);
            this.Controls.Add(this.lab_Num1);
            this.Name = "form_MyClac";
            this.Text = "MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Num1;
        private System.Windows.Forms.Label lab_Num2;
        private System.Windows.Forms.Label lab_dottedLine;
        private System.Windows.Forms.Label lab_Answer;
        private System.Windows.Forms.TextBox txt_Num1_val;
        private System.Windows.Forms.TextBox txt_Num2_val;
        private System.Windows.Forms.TextBox txt_Answer_val;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_mulitply;
        private System.Windows.Forms.Button btn_Divided;
    }
}

