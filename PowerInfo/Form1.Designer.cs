namespace PowerInfo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ACTitle = new System.Windows.Forms.Label();
            this.ACConnect = new System.Windows.Forms.Label();
            this.BatteryTemperature = new System.Windows.Forms.Label();
            this.CurrentCharge = new System.Windows.Forms.Label();
            this.Voltage = new System.Windows.Forms.Label();
            this.BatteryTemperatureTitle = new System.Windows.Forms.Label();
            this.CurrentChargeTitle = new System.Windows.Forms.Label();
            this.VotageTitle = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ACTitle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ACConnect, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BatteryTemperature, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CurrentCharge, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Voltage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BatteryTemperatureTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CurrentChargeTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.VotageTitle, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 221);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ACTitle
            // 
            this.ACTitle.AutoSize = true;
            this.ACTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ACTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ACTitle.Font = new System.Drawing.Font("메이플스토리 OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ACTitle.Location = new System.Drawing.Point(3, 165);
            this.ACTitle.Name = "ACTitle";
            this.ACTitle.Size = new System.Drawing.Size(166, 56);
            this.ACTitle.TabIndex = 9;
            this.ACTitle.Text = "AC 연결";
            this.ACTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ACConnect
            // 
            this.ACConnect.AutoSize = true;
            this.ACConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ACConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ACConnect.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ACConnect.Location = new System.Drawing.Point(175, 165);
            this.ACConnect.Name = "ACConnect";
            this.ACConnect.Size = new System.Drawing.Size(167, 56);
            this.ACConnect.TabIndex = 8;
            this.ACConnect.Text = "-";
            this.ACConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BatteryTemperature
            // 
            this.BatteryTemperature.AutoSize = true;
            this.BatteryTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BatteryTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BatteryTemperature.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BatteryTemperature.Location = new System.Drawing.Point(175, 110);
            this.BatteryTemperature.Name = "BatteryTemperature";
            this.BatteryTemperature.Size = new System.Drawing.Size(167, 55);
            this.BatteryTemperature.TabIndex = 7;
            this.BatteryTemperature.Text = "-";
            this.BatteryTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentCharge
            // 
            this.CurrentCharge.AutoSize = true;
            this.CurrentCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentCharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentCharge.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CurrentCharge.Location = new System.Drawing.Point(175, 55);
            this.CurrentCharge.Name = "CurrentCharge";
            this.CurrentCharge.Size = new System.Drawing.Size(167, 55);
            this.CurrentCharge.TabIndex = 6;
            this.CurrentCharge.Text = "-";
            this.CurrentCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Voltage
            // 
            this.Voltage.AutoSize = true;
            this.Voltage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Voltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Voltage.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Voltage.Location = new System.Drawing.Point(175, 0);
            this.Voltage.Name = "Voltage";
            this.Voltage.Size = new System.Drawing.Size(167, 55);
            this.Voltage.TabIndex = 4;
            this.Voltage.Text = "-";
            this.Voltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BatteryTemperatureTitle
            // 
            this.BatteryTemperatureTitle.AutoSize = true;
            this.BatteryTemperatureTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BatteryTemperatureTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BatteryTemperatureTitle.Font = new System.Drawing.Font("메이플스토리 OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BatteryTemperatureTitle.Location = new System.Drawing.Point(3, 110);
            this.BatteryTemperatureTitle.Name = "BatteryTemperatureTitle";
            this.BatteryTemperatureTitle.Size = new System.Drawing.Size(166, 55);
            this.BatteryTemperatureTitle.TabIndex = 3;
            this.BatteryTemperatureTitle.Text = "배터리 온도";
            this.BatteryTemperatureTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentChargeTitle
            // 
            this.CurrentChargeTitle.AutoSize = true;
            this.CurrentChargeTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentChargeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentChargeTitle.Font = new System.Drawing.Font("메이플스토리 OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CurrentChargeTitle.Location = new System.Drawing.Point(3, 55);
            this.CurrentChargeTitle.Name = "CurrentChargeTitle";
            this.CurrentChargeTitle.Size = new System.Drawing.Size(166, 55);
            this.CurrentChargeTitle.TabIndex = 2;
            this.CurrentChargeTitle.Text = "현재 충전량";
            this.CurrentChargeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VotageTitle
            // 
            this.VotageTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VotageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VotageTitle.Font = new System.Drawing.Font("메이플스토리 OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VotageTitle.Location = new System.Drawing.Point(3, 0);
            this.VotageTitle.Name = "VotageTitle";
            this.VotageTitle.Size = new System.Drawing.Size(166, 55);
            this.VotageTitle.TabIndex = 0;
            this.VotageTitle.Text = "전력량";
            this.VotageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("메이플스토리", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(351, 61);
            this.Title.TabIndex = 1;
            this.Title.Text = "Power Info";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Update
            // 
            this.Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Update.Font = new System.Drawing.Font("메이플스토리 OTF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Update.Location = new System.Drawing.Point(0, 292);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(351, 49);
            this.Update.TabIndex = 2;
            this.Update.Text = "업데이트";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 341);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "전원 상태";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label VotageTitle;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label BatteryTemperature;
        private System.Windows.Forms.Label CurrentCharge;
        private System.Windows.Forms.Label Voltage;
        private System.Windows.Forms.Label BatteryTemperatureTitle;
        private System.Windows.Forms.Label CurrentChargeTitle;
        private System.Windows.Forms.Label ACTitle;
        private System.Windows.Forms.Label ACConnect;
    }
}

