namespace H_Alarm
{
    partial class Form_Alarm
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
            this.components = new System.ComponentModel.Container();
            this.grup_time = new System.Windows.Forms.GroupBox();
            this.msktxt_contrl = new System.Windows.Forms.MaskedTextBox();
            this.lab_leftTitle = new System.Windows.Forms.Label();
            this.lab_handtitle = new System.Windows.Forms.Label();
            this.cheBox_SetAlarm = new System.Windows.Forms.CheckBox();
            this.lab_time_new = new System.Windows.Forms.Label();
            this.timer_control = new System.Windows.Forms.Timer(this.components);
            this.grup_time.SuspendLayout();
            this.SuspendLayout();
            // 
            // grup_time
            // 
            this.grup_time.Controls.Add(this.msktxt_contrl);
            this.grup_time.Controls.Add(this.lab_leftTitle);
            this.grup_time.Controls.Add(this.lab_handtitle);
            this.grup_time.Controls.Add(this.cheBox_SetAlarm);
            this.grup_time.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grup_time.Location = new System.Drawing.Point(62, 114);
            this.grup_time.Name = "grup_time";
            this.grup_time.Size = new System.Drawing.Size(411, 222);
            this.grup_time.TabIndex = 0;
            this.grup_time.TabStop = false;
            this.grup_time.Text = "Select Time";
            // 
            // msktxt_contrl
            // 
            this.msktxt_contrl.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.msktxt_contrl.Location = new System.Drawing.Point(164, 105);
            this.msktxt_contrl.Name = "msktxt_contrl";
            this.msktxt_contrl.Size = new System.Drawing.Size(125, 30);
            this.msktxt_contrl.TabIndex = 2;
            // 
            // lab_leftTitle
            // 
            this.lab_leftTitle.AutoSize = true;
            this.lab_leftTitle.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_leftTitle.Location = new System.Drawing.Point(44, 108);
            this.lab_leftTitle.Name = "lab_leftTitle";
            this.lab_leftTitle.Size = new System.Drawing.Size(114, 19);
            this.lab_leftTitle.TabIndex = 1;
            this.lab_leftTitle.Text = "Alarm Time:";
            // 
            // lab_handtitle
            // 
            this.lab_handtitle.AutoSize = true;
            this.lab_handtitle.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_handtitle.Location = new System.Drawing.Point(181, 71);
            this.lab_handtitle.Name = "lab_handtitle";
            this.lab_handtitle.Size = new System.Drawing.Size(108, 19);
            this.lab_handtitle.TabIndex = 1;
            this.lab_handtitle.Text = "Alarm Time";
            // 
            // cheBox_SetAlarm
            // 
            this.cheBox_SetAlarm.AutoSize = true;
            this.cheBox_SetAlarm.Location = new System.Drawing.Point(192, 150);
            this.cheBox_SetAlarm.Name = "cheBox_SetAlarm";
            this.cheBox_SetAlarm.Size = new System.Drawing.Size(97, 20);
            this.cheBox_SetAlarm.TabIndex = 0;
            this.cheBox_SetAlarm.Text = "Set Alarm";
            this.cheBox_SetAlarm.UseVisualStyleBackColor = true;
            this.cheBox_SetAlarm.CheckedChanged += new System.EventHandler(this.cheBox_SetAlarm_CheckedChanged);
            // 
            // lab_time_new
            // 
            this.lab_time_new.AutoSize = true;
            this.lab_time_new.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_time_new.Location = new System.Drawing.Point(33, 48);
            this.lab_time_new.Name = "lab_time_new";
            this.lab_time_new.Size = new System.Drawing.Size(124, 24);
            this.lab_time_new.TabIndex = 1;
            this.lab_time_new.Text = "Show Time";
            // 
            // timer_control
            // 
            this.timer_control.Enabled = true;
            this.timer_control.Tick += new System.EventHandler(this.timer_control_Tick);
            // 
            // Form_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 361);
            this.Controls.Add(this.lab_time_new);
            this.Controls.Add(this.grup_time);
            this.Name = "Form_Alarm";
            this.Text = "Form Alarm";
            this.grup_time.ResumeLayout(false);
            this.grup_time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grup_time;
        private System.Windows.Forms.Label lab_handtitle;
        private System.Windows.Forms.CheckBox cheBox_SetAlarm;
        private System.Windows.Forms.Label lab_time_new;
        private System.Windows.Forms.Label lab_leftTitle;
        private System.Windows.Forms.MaskedTextBox msktxt_contrl;
        private System.Windows.Forms.Timer timer_control;
    }
}

