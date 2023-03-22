namespace uart
{
    partial class FormForCheck
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageForRadixTrans = new System.Windows.Forms.TabPage();
            this.labelForRadixBIN = new System.Windows.Forms.Label();
            this.labelForRadixHEX = new System.Windows.Forms.Label();
            this.labelForRadixDEC = new System.Windows.Forms.Label();
            this.textBoxForRadixBIN = new System.Windows.Forms.TextBox();
            this.textBoxForRadixDEC = new System.Windows.Forms.TextBox();
            this.textBoxForRadixHEX = new System.Windows.Forms.TextBox();
            this.tabPageForCharTrans = new System.Windows.Forms.TabPage();
            this.comboBoxForTransSelect = new System.Windows.Forms.ComboBox();
            this.buttonForTransStart = new System.Windows.Forms.Button();
            this.textBoxForTransRes = new System.Windows.Forms.TextBox();
            this.textBoxForTransData = new System.Windows.Forms.TextBox();
            this.tabPageForAes = new System.Windows.Forms.TabPage();
            this.labelForAesRes = new System.Windows.Forms.Label();
            this.labelForAesData = new System.Windows.Forms.Label();
            this.labelForAesKey = new System.Windows.Forms.Label();
            this.buttonForAesDecry = new System.Windows.Forms.Button();
            this.textBoxForAesRes = new System.Windows.Forms.TextBox();
            this.textBoxForAesKey = new System.Windows.Forms.TextBox();
            this.textBoxForAesData = new System.Windows.Forms.TextBox();
            this.buttonForAesEncry = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageForRadixTrans.SuspendLayout();
            this.tabPageForCharTrans.SuspendLayout();
            this.tabPageForAes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageForRadixTrans);
            this.tabControl.Controls.Add(this.tabPageForCharTrans);
            this.tabControl.Controls.Add(this.tabPageForAes);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(664, 401);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageForRadixTrans
            // 
            this.tabPageForRadixTrans.Controls.Add(this.labelForRadixBIN);
            this.tabPageForRadixTrans.Controls.Add(this.labelForRadixHEX);
            this.tabPageForRadixTrans.Controls.Add(this.labelForRadixDEC);
            this.tabPageForRadixTrans.Controls.Add(this.textBoxForRadixBIN);
            this.tabPageForRadixTrans.Controls.Add(this.textBoxForRadixDEC);
            this.tabPageForRadixTrans.Controls.Add(this.textBoxForRadixHEX);
            this.tabPageForRadixTrans.Location = new System.Drawing.Point(4, 22);
            this.tabPageForRadixTrans.Name = "tabPageForRadixTrans";
            this.tabPageForRadixTrans.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageForRadixTrans.Size = new System.Drawing.Size(656, 375);
            this.tabPageForRadixTrans.TabIndex = 2;
            this.tabPageForRadixTrans.Text = "进制转换";
            this.tabPageForRadixTrans.UseVisualStyleBackColor = true;
            // 
            // labelForRadixBIN
            // 
            this.labelForRadixBIN.AutoSize = true;
            this.labelForRadixBIN.Location = new System.Drawing.Point(30, 210);
            this.labelForRadixBIN.Name = "labelForRadixBIN";
            this.labelForRadixBIN.Size = new System.Drawing.Size(23, 12);
            this.labelForRadixBIN.TabIndex = 5;
            this.labelForRadixBIN.Text = "BIN";
            // 
            // labelForRadixHEX
            // 
            this.labelForRadixHEX.AutoSize = true;
            this.labelForRadixHEX.Location = new System.Drawing.Point(30, 30);
            this.labelForRadixHEX.Name = "labelForRadixHEX";
            this.labelForRadixHEX.Size = new System.Drawing.Size(23, 12);
            this.labelForRadixHEX.TabIndex = 4;
            this.labelForRadixHEX.Text = "HEX";
            // 
            // labelForRadixDEC
            // 
            this.labelForRadixDEC.AutoSize = true;
            this.labelForRadixDEC.Location = new System.Drawing.Point(30, 120);
            this.labelForRadixDEC.Name = "labelForRadixDEC";
            this.labelForRadixDEC.Size = new System.Drawing.Size(23, 12);
            this.labelForRadixDEC.TabIndex = 3;
            this.labelForRadixDEC.Text = "DEC";
            // 
            // textBoxForRadixBIN
            // 
            this.textBoxForRadixBIN.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxForRadixBIN.Location = new System.Drawing.Point(60, 210);
            this.textBoxForRadixBIN.Multiline = true;
            this.textBoxForRadixBIN.Name = "textBoxForRadixBIN";
            this.textBoxForRadixBIN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxForRadixBIN.Size = new System.Drawing.Size(540, 94);
            this.textBoxForRadixBIN.TabIndex = 2;
            this.textBoxForRadixBIN.TextChanged += new System.EventHandler(this.textBoxForRadixBIN_TextChanged);
            this.textBoxForRadixBIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxForRadixBIN_KeyDown);
            // 
            // textBoxForRadixDEC
            // 
            this.textBoxForRadixDEC.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxForRadixDEC.Location = new System.Drawing.Point(60, 120);
            this.textBoxForRadixDEC.Name = "textBoxForRadixDEC";
            this.textBoxForRadixDEC.Size = new System.Drawing.Size(540, 47);
            this.textBoxForRadixDEC.TabIndex = 1;
            this.textBoxForRadixDEC.TextChanged += new System.EventHandler(this.textBoxForRadixDEC_TextChanged);
            this.textBoxForRadixDEC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxForRadixDEC_KeyDown);
            // 
            // textBoxForRadixHEX
            // 
            this.textBoxForRadixHEX.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxForRadixHEX.Location = new System.Drawing.Point(60, 30);
            this.textBoxForRadixHEX.Name = "textBoxForRadixHEX";
            this.textBoxForRadixHEX.Size = new System.Drawing.Size(540, 47);
            this.textBoxForRadixHEX.TabIndex = 0;
            this.textBoxForRadixHEX.TextChanged += new System.EventHandler(this.textBoxForRadixHEX_TextChanged);
            this.textBoxForRadixHEX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxForRadixHEX_KeyDown);
            // 
            // tabPageForCharTrans
            // 
            this.tabPageForCharTrans.Controls.Add(this.comboBoxForTransSelect);
            this.tabPageForCharTrans.Controls.Add(this.buttonForTransStart);
            this.tabPageForCharTrans.Controls.Add(this.textBoxForTransRes);
            this.tabPageForCharTrans.Controls.Add(this.textBoxForTransData);
            this.tabPageForCharTrans.Location = new System.Drawing.Point(4, 22);
            this.tabPageForCharTrans.Name = "tabPageForCharTrans";
            this.tabPageForCharTrans.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageForCharTrans.Size = new System.Drawing.Size(656, 375);
            this.tabPageForCharTrans.TabIndex = 1;
            this.tabPageForCharTrans.Text = "字符转换";
            this.tabPageForCharTrans.UseVisualStyleBackColor = true;
            // 
            // comboBoxForTransSelect
            // 
            this.comboBoxForTransSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxForTransSelect.FormattingEnabled = true;
            this.comboBoxForTransSelect.ItemHeight = 12;
            this.comboBoxForTransSelect.Items.AddRange(new object[] {
            "StringToHex",
            "HexToString"});
            this.comboBoxForTransSelect.Location = new System.Drawing.Point(50, 30);
            this.comboBoxForTransSelect.Name = "comboBoxForTransSelect";
            this.comboBoxForTransSelect.Size = new System.Drawing.Size(550, 20);
            this.comboBoxForTransSelect.TabIndex = 3;
            this.comboBoxForTransSelect.Text = "StringToHex";
            // 
            // buttonForTransStart
            // 
            this.buttonForTransStart.Location = new System.Drawing.Point(200, 320);
            this.buttonForTransStart.Name = "buttonForTransStart";
            this.buttonForTransStart.Size = new System.Drawing.Size(300, 23);
            this.buttonForTransStart.TabIndex = 2;
            this.buttonForTransStart.Text = "转换";
            this.buttonForTransStart.UseVisualStyleBackColor = true;
            this.buttonForTransStart.Click += new System.EventHandler(this.buttonForTransStart_Click);
            // 
            // textBoxForTransRes
            // 
            this.textBoxForTransRes.Location = new System.Drawing.Point(50, 199);
            this.textBoxForTransRes.Multiline = true;
            this.textBoxForTransRes.Name = "textBoxForTransRes";
            this.textBoxForTransRes.Size = new System.Drawing.Size(550, 100);
            this.textBoxForTransRes.TabIndex = 1;
            this.textBoxForTransRes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxForTransRes_KeyDown);
            // 
            // textBoxForTransData
            // 
            this.textBoxForTransData.Location = new System.Drawing.Point(50, 75);
            this.textBoxForTransData.Multiline = true;
            this.textBoxForTransData.Name = "textBoxForTransData";
            this.textBoxForTransData.Size = new System.Drawing.Size(550, 100);
            this.textBoxForTransData.TabIndex = 0;
            this.textBoxForTransData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxForTransData_KeyDown);
            // 
            // tabPageForAes
            // 
            this.tabPageForAes.Controls.Add(this.labelForAesRes);
            this.tabPageForAes.Controls.Add(this.labelForAesData);
            this.tabPageForAes.Controls.Add(this.labelForAesKey);
            this.tabPageForAes.Controls.Add(this.buttonForAesDecry);
            this.tabPageForAes.Controls.Add(this.textBoxForAesRes);
            this.tabPageForAes.Controls.Add(this.textBoxForAesKey);
            this.tabPageForAes.Controls.Add(this.textBoxForAesData);
            this.tabPageForAes.Controls.Add(this.buttonForAesEncry);
            this.tabPageForAes.Location = new System.Drawing.Point(4, 22);
            this.tabPageForAes.Name = "tabPageForAes";
            this.tabPageForAes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageForAes.Size = new System.Drawing.Size(656, 375);
            this.tabPageForAes.TabIndex = 0;
            this.tabPageForAes.Text = "AES加密";
            this.tabPageForAes.UseVisualStyleBackColor = true;
            // 
            // labelForAesRes
            // 
            this.labelForAesRes.AutoSize = true;
            this.labelForAesRes.Location = new System.Drawing.Point(30, 199);
            this.labelForAesRes.Name = "labelForAesRes";
            this.labelForAesRes.Size = new System.Drawing.Size(59, 12);
            this.labelForAesRes.TabIndex = 8;
            this.labelForAesRes.Text = "结果(Hex)";
            // 
            // labelForAesData
            // 
            this.labelForAesData.AutoSize = true;
            this.labelForAesData.Location = new System.Drawing.Point(30, 75);
            this.labelForAesData.Name = "labelForAesData";
            this.labelForAesData.Size = new System.Drawing.Size(59, 12);
            this.labelForAesData.TabIndex = 7;
            this.labelForAesData.Text = "数据(Hex)";
            // 
            // labelForAesKey
            // 
            this.labelForAesKey.AutoSize = true;
            this.labelForAesKey.Location = new System.Drawing.Point(30, 30);
            this.labelForAesKey.Name = "labelForAesKey";
            this.labelForAesKey.Size = new System.Drawing.Size(59, 12);
            this.labelForAesKey.TabIndex = 6;
            this.labelForAesKey.Text = "密钥(Hex)";
            // 
            // buttonForAesDecry
            // 
            this.buttonForAesDecry.Location = new System.Drawing.Point(425, 320);
            this.buttonForAesDecry.Name = "buttonForAesDecry";
            this.buttonForAesDecry.Size = new System.Drawing.Size(75, 23);
            this.buttonForAesDecry.TabIndex = 5;
            this.buttonForAesDecry.Text = "解密";
            this.buttonForAesDecry.UseVisualStyleBackColor = true;
            this.buttonForAesDecry.Click += new System.EventHandler(this.buttonForAesDecry_Click);
            // 
            // textBoxForAesRes
            // 
            this.textBoxForAesRes.Location = new System.Drawing.Point(100, 199);
            this.textBoxForAesRes.Multiline = true;
            this.textBoxForAesRes.Name = "textBoxForAesRes";
            this.textBoxForAesRes.Size = new System.Drawing.Size(500, 100);
            this.textBoxForAesRes.TabIndex = 3;
            this.textBoxForAesRes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxForAesRes_KeyDown);
            // 
            // textBoxForAesKey
            // 
            this.textBoxForAesKey.Location = new System.Drawing.Point(100, 30);
            this.textBoxForAesKey.Name = "textBoxForAesKey";
            this.textBoxForAesKey.Size = new System.Drawing.Size(500, 21);
            this.textBoxForAesKey.TabIndex = 2;
            this.textBoxForAesKey.Text = "01020304050607080910111213141516";
            // 
            // textBoxForAesData
            // 
            this.textBoxForAesData.Location = new System.Drawing.Point(100, 75);
            this.textBoxForAesData.Multiline = true;
            this.textBoxForAesData.Name = "textBoxForAesData";
            this.textBoxForAesData.Size = new System.Drawing.Size(500, 100);
            this.textBoxForAesData.TabIndex = 1;
            this.textBoxForAesData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxForAesData_KeyDown);
            // 
            // buttonForAesEncry
            // 
            this.buttonForAesEncry.Location = new System.Drawing.Point(200, 320);
            this.buttonForAesEncry.Name = "buttonForAesEncry";
            this.buttonForAesEncry.Size = new System.Drawing.Size(75, 23);
            this.buttonForAesEncry.TabIndex = 0;
            this.buttonForAesEncry.Text = "加密";
            this.buttonForAesEncry.UseVisualStyleBackColor = true;
            this.buttonForAesEncry.Click += new System.EventHandler(this.buttonForAesEcb_Click);
            // 
            // FormForCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(664, 401);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 440);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 440);
            this.Name = "FormForCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForCheck";
            this.tabControl.ResumeLayout(false);
            this.tabPageForRadixTrans.ResumeLayout(false);
            this.tabPageForRadixTrans.PerformLayout();
            this.tabPageForCharTrans.ResumeLayout(false);
            this.tabPageForCharTrans.PerformLayout();
            this.tabPageForAes.ResumeLayout(false);
            this.tabPageForAes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageForAes;
        private System.Windows.Forms.TextBox textBoxForAesData;
        private System.Windows.Forms.Button buttonForAesEncry;
        private System.Windows.Forms.TabPage tabPageForCharTrans;
        private System.Windows.Forms.Button buttonForAesDecry;
        private System.Windows.Forms.TextBox textBoxForAesRes;
        private System.Windows.Forms.TextBox textBoxForAesKey;
        private System.Windows.Forms.Label labelForAesData;
        private System.Windows.Forms.Label labelForAesKey;
        private System.Windows.Forms.Label labelForAesRes;
        private System.Windows.Forms.TextBox textBoxForTransRes;
        private System.Windows.Forms.TextBox textBoxForTransData;
        private System.Windows.Forms.Button buttonForTransStart;
        private System.Windows.Forms.ComboBox comboBoxForTransSelect;
        private System.Windows.Forms.TabPage tabPageForRadixTrans;
        private System.Windows.Forms.Label labelForRadixBIN;
        private System.Windows.Forms.Label labelForRadixHEX;
        private System.Windows.Forms.Label labelForRadixDEC;
        private System.Windows.Forms.TextBox textBoxForRadixBIN;
        private System.Windows.Forms.TextBox textBoxForRadixDEC;
        private System.Windows.Forms.TextBox textBoxForRadixHEX;
    }
}