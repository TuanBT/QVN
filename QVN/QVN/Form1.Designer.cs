namespace QVN
{
    partial class Form1
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.nmrOpacity = new System.Windows.Forms.NumericUpDown();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.lblS2 = new System.Windows.Forms.Label();
            this.nmrSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblS1 = new System.Windows.Forms.Label();
            this.nmrSize = new System.Windows.Forms.NumericUpDown();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnSettingHide = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSettingShow = new System.Windows.Forms.Button();
            this.tmrRun = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMain.Controls.Add(this.pnlSetting);
            this.pnlMain.Controls.Add(this.lbl2);
            this.pnlMain.Controls.Add(this.lblCategory);
            this.pnlMain.Controls.Add(this.lbl1);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.btnSettingShow);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(572, 70);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlSetting
            // 
            this.pnlSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlSetting.Controls.Add(this.nmrOpacity);
            this.pnlSetting.Controls.Add(this.lblOpacity);
            this.pnlSetting.Controls.Add(this.lblS2);
            this.pnlSetting.Controls.Add(this.nmrSpeed);
            this.pnlSetting.Controls.Add(this.lblSpeed);
            this.pnlSetting.Controls.Add(this.lblS1);
            this.pnlSetting.Controls.Add(this.nmrSize);
            this.pnlSetting.Controls.Add(this.lblSize);
            this.pnlSetting.Controls.Add(this.btnSettingHide);
            this.pnlSetting.Location = new System.Drawing.Point(12, 32);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(420, 26);
            this.pnlSetting.TabIndex = 8;
            this.pnlSetting.Visible = false;
            // 
            // nmrOpacity
            // 
            this.nmrOpacity.AutoSize = true;
            this.nmrOpacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmrOpacity.Dock = System.Windows.Forms.DockStyle.Left;
            this.nmrOpacity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrOpacity.Location = new System.Drawing.Point(243, 0);
            this.nmrOpacity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrOpacity.Name = "nmrOpacity";
            this.nmrOpacity.Size = new System.Drawing.Size(41, 16);
            this.nmrOpacity.TabIndex = 18;
            this.nmrOpacity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrOpacity.ValueChanged += new System.EventHandler(this.nmrOpacity_ValueChanged);
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOpacity.Location = new System.Drawing.Point(185, 0);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(58, 13);
            this.lblOpacity.TabIndex = 17;
            this.lblOpacity.Text = "Trong suốt";
            // 
            // lblS2
            // 
            this.lblS2.AutoSize = true;
            this.lblS2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblS2.Location = new System.Drawing.Point(169, 0);
            this.lblS2.Name = "lblS2";
            this.lblS2.Size = new System.Drawing.Size(16, 13);
            this.lblS2.TabIndex = 16;
            this.lblS2.Text = "---";
            // 
            // nmrSpeed
            // 
            this.nmrSpeed.AutoSize = true;
            this.nmrSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmrSpeed.Dock = System.Windows.Forms.DockStyle.Left;
            this.nmrSpeed.Location = new System.Drawing.Point(134, 0);
            this.nmrSpeed.Name = "nmrSpeed";
            this.nmrSpeed.Size = new System.Drawing.Size(35, 16);
            this.nmrSpeed.TabIndex = 15;
            this.nmrSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrSpeed.ValueChanged += new System.EventHandler(this.nmrSpeed_ValueChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSpeed.Location = new System.Drawing.Point(92, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(42, 13);
            this.lblSpeed.TabIndex = 14;
            this.lblSpeed.Text = "Tốc độ";
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblS1.Location = new System.Drawing.Point(76, 0);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(16, 13);
            this.lblS1.TabIndex = 13;
            this.lblS1.Text = "---";
            // 
            // nmrSize
            // 
            this.nmrSize.AutoSize = true;
            this.nmrSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmrSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.nmrSize.Location = new System.Drawing.Point(41, 0);
            this.nmrSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrSize.Name = "nmrSize";
            this.nmrSize.Size = new System.Drawing.Size(35, 16);
            this.nmrSize.TabIndex = 12;
            this.nmrSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmrSize.ValueChanged += new System.EventHandler(this.nmrSize_ValueChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSize.Location = new System.Drawing.Point(0, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(41, 13);
            this.lblSize.TabIndex = 11;
            this.lblSize.Text = "Cỡ chữ";
            // 
            // btnSettingHide
            // 
            this.btnSettingHide.AutoSize = true;
            this.btnSettingHide.BackColor = System.Drawing.Color.Transparent;
            this.btnSettingHide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSettingHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingHide.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingHide.Location = new System.Drawing.Point(391, 0);
            this.btnSettingHide.Name = "btnSettingHide";
            this.btnSettingHide.Size = new System.Drawing.Size(29, 26);
            this.btnSettingHide.TabIndex = 10;
            this.btnSettingHide.Text = "☼";
            this.btnSettingHide.UseVisualStyleBackColor = false;
            this.btnSettingHide.Click += new System.EventHandler(this.btnSettingHide_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(106, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(18, 14);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "►";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCategory.Location = new System.Drawing.Point(61, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(45, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Thể loại";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(47, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(14, 14);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "■";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên báo";
            // 
            // btnSettingShow
            // 
            this.btnSettingShow.AutoSize = true;
            this.btnSettingShow.BackColor = System.Drawing.Color.Transparent;
            this.btnSettingShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSettingShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingShow.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingShow.ForeColor = System.Drawing.Color.Red;
            this.btnSettingShow.Location = new System.Drawing.Point(543, 0);
            this.btnSettingShow.Name = "btnSettingShow";
            this.btnSettingShow.Size = new System.Drawing.Size(29, 70);
            this.btnSettingShow.TabIndex = 9;
            this.btnSettingShow.Text = "☼";
            this.btnSettingShow.UseVisualStyleBackColor = false;
            this.btnSettingShow.Click += new System.EventHandler(this.btnSettingShow_Click);
            // 
            // tmrRun
            // 
            this.tmrRun.Tick += new System.EventHandler(this.tmrRun_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 30000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 70);
            this.Controls.Add(this.pnlMain);
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer tmrRun;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnSettingShow;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Button btnSettingHide;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown nmrSpeed;
        private System.Windows.Forms.Label lblS1;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown nmrSize;
        private System.Windows.Forms.NumericUpDown nmrOpacity;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.Label lblS2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

