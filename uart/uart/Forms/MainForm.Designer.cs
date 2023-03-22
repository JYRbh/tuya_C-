namespace uart
{

    partial class MainForm
    {
        const int TX_LENTH = 8;
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuItemForFile = new System.Windows.Forms.ToolStripMenuItem();
			this.sonOfmenuItemForOpenFile = new System.Windows.Forms.ToolStripMenuItem();
			this.sonOfmenuItemForSaveFile = new System.Windows.Forms.ToolStripMenuItem();
			this.sonOfmenuItemForCloseFile = new System.Windows.Forms.ToolStripMenuItem();
			this.恢复默认ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemForComSet = new System.Windows.Forms.ToolStripMenuItem();
			this.sonOfmenuItemForStopBit = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBoxForStopBit = new System.Windows.Forms.ToolStripComboBox();
			this.sonOfmenuItemForDataBit = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBoxForDataBit = new System.Windows.Forms.ToolStripComboBox();
			this.sonOfmenuItemForCheck = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBoxForCheck = new System.Windows.Forms.ToolStripComboBox();
			this.menuItemForMulTxView = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemForHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.更多帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aSCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.示波器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemForCheck = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBoxForBaudRate = new System.Windows.Forms.ComboBox();
			this.comboBoxForComSelect = new System.Windows.Forms.ComboBox();
			this.buttonForRxAreaClear = new System.Windows.Forms.Button();
			this.buttonForComSwitch = new System.Windows.Forms.Button();
			this.Com = new System.IO.Ports.SerialPort(this.components);
			this.buttonForTxSend = new System.Windows.Forms.Button();
			this.buttonForTxAreaClear = new System.Windows.Forms.Button();
			this.checkBoxForTxHex = new System.Windows.Forms.CheckBox();
			this.checkBoxForTxNewLine = new System.Windows.Forms.CheckBox();
			this.checkBoxForTxTimer = new System.Windows.Forms.CheckBox();
			this.textBoxForTxTimer = new System.Windows.Forms.TextBox();
			this.checkBoxForRxAutoClear = new System.Windows.Forms.CheckBox();
			this.checkBoxForRxHex = new System.Windows.Forms.CheckBox();
			this.checkBoxForRxTimeDisplay = new System.Windows.Forms.CheckBox();
			this.checkBoxForRxNewLine = new System.Windows.Forms.CheckBox();
			this.labelForTxTimer = new System.Windows.Forms.Label();
			this.groupBoxForRx = new System.Windows.Forms.GroupBox();
			this.groupBoxForTx = new System.Windows.Forms.GroupBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.textBoxForTxArea = new System.Windows.Forms.TextBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.textBoxForFrameHead = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxForFrameOvertime = new System.Windows.Forms.TextBox();
			this.radioButtonForFrameHead = new System.Windows.Forms.RadioButton();
			this.radioButtonForFrameOvertime = new System.Windows.Forms.RadioButton();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBoxForSumCheckLenth = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxForSumCheckStartAddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxForCrcCheckLenth = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxForCrcCheckStartAddress = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBoxForSumCheck = new System.Windows.Forms.CheckBox();
			this.checkBoxForCrcCheck = new System.Windows.Forms.CheckBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBoxForRxArea = new System.Windows.Forms.TextBox();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.checkBoxForMulTxView = new System.Windows.Forms.CheckBox();
			this.textBoxForMulTxNum = new System.Windows.Forms.TextBox();
			this.buttonForMulTxBorn = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripMenuItemForNotepad = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemForCalculator = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.menuStrip1.SuspendLayout();
			this.groupBoxForRx.SuspendLayout();
			this.groupBoxForTx.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemForFile,
            this.menuItemForComSet,
            this.menuItemForMulTxView,
            this.menuItemForHelp,
            this.aSCIIToolStripMenuItem,
            this.示波器ToolStripMenuItem,
            this.ToolStripMenuItemForCheck});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(734, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuItemForFile
			// 
			this.menuItemForFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sonOfmenuItemForOpenFile,
            this.sonOfmenuItemForSaveFile,
            this.sonOfmenuItemForCloseFile,
            this.恢复默认ToolStripMenuItem});
			this.menuItemForFile.Name = "menuItemForFile";
			this.menuItemForFile.Size = new System.Drawing.Size(44, 21);
			this.menuItemForFile.Text = "文件";
			// 
			// sonOfmenuItemForOpenFile
			// 
			this.sonOfmenuItemForOpenFile.Name = "sonOfmenuItemForOpenFile";
			this.sonOfmenuItemForOpenFile.Size = new System.Drawing.Size(124, 22);
			this.sonOfmenuItemForOpenFile.Text = "打开文件";
			this.sonOfmenuItemForOpenFile.Click += new System.EventHandler(this.sonOfmenuItemForOpenFile_Click);
			// 
			// sonOfmenuItemForSaveFile
			// 
			this.sonOfmenuItemForSaveFile.Name = "sonOfmenuItemForSaveFile";
			this.sonOfmenuItemForSaveFile.Size = new System.Drawing.Size(124, 22);
			this.sonOfmenuItemForSaveFile.Text = "保存文件";
			this.sonOfmenuItemForSaveFile.Click += new System.EventHandler(this.sonOfmenuItemForSaveFile_Click);
			// 
			// sonOfmenuItemForCloseFile
			// 
			this.sonOfmenuItemForCloseFile.Name = "sonOfmenuItemForCloseFile";
			this.sonOfmenuItemForCloseFile.Size = new System.Drawing.Size(124, 22);
			this.sonOfmenuItemForCloseFile.Text = "关闭文件";
			// 
			// 恢复默认ToolStripMenuItem
			// 
			this.恢复默认ToolStripMenuItem.Name = "恢复默认ToolStripMenuItem";
			this.恢复默认ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.恢复默认ToolStripMenuItem.Text = "恢复默认";
			this.恢复默认ToolStripMenuItem.Click += new System.EventHandler(this.恢复默认ToolStripMenuItem_Click);
			// 
			// menuItemForComSet
			// 
			this.menuItemForComSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sonOfmenuItemForStopBit,
            this.sonOfmenuItemForDataBit,
            this.sonOfmenuItemForCheck});
			this.menuItemForComSet.Name = "menuItemForComSet";
			this.menuItemForComSet.Size = new System.Drawing.Size(68, 21);
			this.menuItemForComSet.Text = "串口设置";
			// 
			// sonOfmenuItemForStopBit
			// 
			this.sonOfmenuItemForStopBit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxForStopBit});
			this.sonOfmenuItemForStopBit.Name = "sonOfmenuItemForStopBit";
			this.sonOfmenuItemForStopBit.Size = new System.Drawing.Size(124, 22);
			this.sonOfmenuItemForStopBit.Text = "停止位";
			// 
			// comboBoxForStopBit
			// 
			this.comboBoxForStopBit.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
			this.comboBoxForStopBit.Name = "comboBoxForStopBit";
			this.comboBoxForStopBit.Size = new System.Drawing.Size(121, 25);
			this.comboBoxForStopBit.Text = "1";
			this.comboBoxForStopBit.Click += new System.EventHandler(this.comboBoxForStopBit_Click);
			// 
			// sonOfmenuItemForDataBit
			// 
			this.sonOfmenuItemForDataBit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxForDataBit});
			this.sonOfmenuItemForDataBit.Name = "sonOfmenuItemForDataBit";
			this.sonOfmenuItemForDataBit.Size = new System.Drawing.Size(124, 22);
			this.sonOfmenuItemForDataBit.Text = "数据位";
			// 
			// comboBoxForDataBit
			// 
			this.comboBoxForDataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
			this.comboBoxForDataBit.Name = "comboBoxForDataBit";
			this.comboBoxForDataBit.Size = new System.Drawing.Size(121, 25);
			this.comboBoxForDataBit.Text = "8";
			this.comboBoxForDataBit.Click += new System.EventHandler(this.comboBoxForDataBit_Click);
			// 
			// sonOfmenuItemForCheck
			// 
			this.sonOfmenuItemForCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxForCheck});
			this.sonOfmenuItemForCheck.Name = "sonOfmenuItemForCheck";
			this.sonOfmenuItemForCheck.Size = new System.Drawing.Size(124, 22);
			this.sonOfmenuItemForCheck.Text = "奇偶校验";
			// 
			// comboBoxForCheck
			// 
			this.comboBoxForCheck.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验",
            "保留为1",
            "保留为0"});
			this.comboBoxForCheck.Name = "comboBoxForCheck";
			this.comboBoxForCheck.Size = new System.Drawing.Size(121, 25);
			this.comboBoxForCheck.Text = "无";
			this.comboBoxForCheck.Click += new System.EventHandler(this.comboBoxForCheck_Click);
			// 
			// menuItemForMulTxView
			// 
			this.menuItemForMulTxView.Name = "menuItemForMulTxView";
			this.menuItemForMulTxView.Size = new System.Drawing.Size(68, 21);
			this.menuItemForMulTxView.Text = "多条发送";
			this.menuItemForMulTxView.Click += new System.EventHandler(this.menuItemForMulTxView_Click);
			// 
			// menuItemForHelp
			// 
			this.menuItemForHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用说明ToolStripMenuItem,
            this.更多帮助ToolStripMenuItem});
			this.menuItemForHelp.Name = "menuItemForHelp";
			this.menuItemForHelp.Size = new System.Drawing.Size(44, 21);
			this.menuItemForHelp.Text = "帮助";
			// 
			// 使用说明ToolStripMenuItem
			// 
			this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
			this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.使用说明ToolStripMenuItem.Text = "使用说明";
			this.使用说明ToolStripMenuItem.Click += new System.EventHandler(this.使用说明ToolStripMenuItem_Click);
			// 
			// 更多帮助ToolStripMenuItem
			// 
			this.更多帮助ToolStripMenuItem.Name = "更多帮助ToolStripMenuItem";
			this.更多帮助ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.更多帮助ToolStripMenuItem.Text = "更多帮助…";
			this.更多帮助ToolStripMenuItem.Click += new System.EventHandler(this.更多帮助ToolStripMenuItem_Click);
			// 
			// aSCIIToolStripMenuItem
			// 
			this.aSCIIToolStripMenuItem.Name = "aSCIIToolStripMenuItem";
			this.aSCIIToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
			this.aSCIIToolStripMenuItem.Text = "ASCII";
			this.aSCIIToolStripMenuItem.Click += new System.EventHandler(this.aSCIIToolStripMenuItem_Click);
			// 
			// 示波器ToolStripMenuItem
			// 
			this.示波器ToolStripMenuItem.Name = "示波器ToolStripMenuItem";
			this.示波器ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
			this.示波器ToolStripMenuItem.Text = "示波器";
			this.示波器ToolStripMenuItem.Click += new System.EventHandler(this.示波器ToolStripMenuItem_Click);
			// 
			// ToolStripMenuItemForCheck
			// 
			this.ToolStripMenuItemForCheck.Name = "ToolStripMenuItemForCheck";
			this.ToolStripMenuItemForCheck.Size = new System.Drawing.Size(44, 21);
			this.ToolStripMenuItemForCheck.Text = "校验";
			this.ToolStripMenuItemForCheck.Click += new System.EventHandler(this.ToolStripMenuItemForCheck_Click);
			// 
			// comboBoxForBaudRate
			// 
			this.comboBoxForBaudRate.FormattingEnabled = true;
			this.comboBoxForBaudRate.Items.AddRange(new object[] {
            "1382400",
            "921600",
            "460800",
            "256000",
            "230400",
            "128000",
            "115200",
            "76800",
            "57600",
            "43000",
            "38400",
            "19200",
            "14400",
            "9600",
            "4800",
            "2400",
            "1200"});
			this.comboBoxForBaudRate.Location = new System.Drawing.Point(12, 54);
			this.comboBoxForBaudRate.Name = "comboBoxForBaudRate";
			this.comboBoxForBaudRate.Size = new System.Drawing.Size(82, 20);
			this.comboBoxForBaudRate.TabIndex = 2;
			this.comboBoxForBaudRate.Text = "115200";
			this.comboBoxForBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxForBaudRate_SelectedIndexChanged);
			// 
			// comboBoxForComSelect
			// 
			this.comboBoxForComSelect.DropDownWidth = 300;
			this.comboBoxForComSelect.FormattingEnabled = true;
			this.comboBoxForComSelect.Location = new System.Drawing.Point(12, 28);
			this.comboBoxForComSelect.MaxDropDownItems = 20;
			this.comboBoxForComSelect.Name = "comboBoxForComSelect";
			this.comboBoxForComSelect.Size = new System.Drawing.Size(82, 20);
			this.comboBoxForComSelect.TabIndex = 3;
			this.comboBoxForComSelect.SelectionChangeCommitted += new System.EventHandler(this.comboBoxForComSelect_SelectionChangeCommitted);
			this.comboBoxForComSelect.Click += new System.EventHandler(this.comboBoxForComSelect_Click);
			// 
			// buttonForRxAreaClear
			// 
			this.buttonForRxAreaClear.Location = new System.Drawing.Point(12, 80);
			this.buttonForRxAreaClear.Name = "buttonForRxAreaClear";
			this.buttonForRxAreaClear.Size = new System.Drawing.Size(82, 23);
			this.buttonForRxAreaClear.TabIndex = 5;
			this.buttonForRxAreaClear.Text = "清除接收";
			this.buttonForRxAreaClear.UseVisualStyleBackColor = true;
			this.buttonForRxAreaClear.Click += new System.EventHandler(this.buttonForRxAreaClear_Click);
			// 
			// buttonForComSwitch
			// 
			this.buttonForComSwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonForComSwitch.Location = new System.Drawing.Point(12, 109);
			this.buttonForComSwitch.Name = "buttonForComSwitch";
			this.buttonForComSwitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonForComSwitch.Size = new System.Drawing.Size(82, 23);
			this.buttonForComSwitch.TabIndex = 4;
			this.buttonForComSwitch.Text = "打开串口";
			this.buttonForComSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonForComSwitch.UseVisualStyleBackColor = true;
			this.buttonForComSwitch.Click += new System.EventHandler(this.buttonForComSwitch_Click);
			// 
			// Com
			// 
			this.Com.BaudRate = 115200;
			this.Com.ReadBufferSize = 40960;
			this.Com.WriteBufferSize = 10240;
			this.Com.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.com_DataReceived);
			// 
			// buttonForTxSend
			// 
			this.buttonForTxSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonForTxSend.Location = new System.Drawing.Point(12, 466);
			this.buttonForTxSend.Name = "buttonForTxSend";
			this.buttonForTxSend.Size = new System.Drawing.Size(82, 23);
			this.buttonForTxSend.TabIndex = 7;
			this.buttonForTxSend.Text = "发送";
			this.buttonForTxSend.UseVisualStyleBackColor = true;
			this.buttonForTxSend.Click += new System.EventHandler(this.buttonForTxSend_Click);
			// 
			// buttonForTxAreaClear
			// 
			this.buttonForTxAreaClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonForTxAreaClear.Location = new System.Drawing.Point(12, 437);
			this.buttonForTxAreaClear.Name = "buttonForTxAreaClear";
			this.buttonForTxAreaClear.Size = new System.Drawing.Size(82, 23);
			this.buttonForTxAreaClear.TabIndex = 8;
			this.buttonForTxAreaClear.Text = "清除发送";
			this.buttonForTxAreaClear.UseVisualStyleBackColor = true;
			this.buttonForTxAreaClear.Click += new System.EventHandler(this.buttonForTxAreaClear_Click);
			// 
			// checkBoxForTxHex
			// 
			this.checkBoxForTxHex.AutoSize = true;
			this.checkBoxForTxHex.Location = new System.Drawing.Point(6, 20);
			this.checkBoxForTxHex.Name = "checkBoxForTxHex";
			this.checkBoxForTxHex.Size = new System.Drawing.Size(66, 16);
			this.checkBoxForTxHex.TabIndex = 10;
			this.checkBoxForTxHex.Text = "HEX发送";
			this.checkBoxForTxHex.UseVisualStyleBackColor = true;
			this.checkBoxForTxHex.CheckedChanged += new System.EventHandler(this.checkBoxForTxHex_CheckedChanged);
			// 
			// checkBoxForTxNewLine
			// 
			this.checkBoxForTxNewLine.AutoSize = true;
			this.checkBoxForTxNewLine.Location = new System.Drawing.Point(6, 42);
			this.checkBoxForTxNewLine.Name = "checkBoxForTxNewLine";
			this.checkBoxForTxNewLine.Size = new System.Drawing.Size(72, 16);
			this.checkBoxForTxNewLine.TabIndex = 11;
			this.checkBoxForTxNewLine.Text = "发送新行";
			this.checkBoxForTxNewLine.UseVisualStyleBackColor = true;
			this.checkBoxForTxNewLine.CheckedChanged += new System.EventHandler(this.checkBoxForTxNewLine_CheckedChanged);
			// 
			// checkBoxForTxTimer
			// 
			this.checkBoxForTxTimer.AutoSize = true;
			this.checkBoxForTxTimer.Location = new System.Drawing.Point(6, 64);
			this.checkBoxForTxTimer.Name = "checkBoxForTxTimer";
			this.checkBoxForTxTimer.Size = new System.Drawing.Size(72, 16);
			this.checkBoxForTxTimer.TabIndex = 12;
			this.checkBoxForTxTimer.Text = "定时发送";
			this.checkBoxForTxTimer.UseVisualStyleBackColor = true;
			this.checkBoxForTxTimer.CheckedChanged += new System.EventHandler(this.checkBoxForTxTimer_CheckedChanged);
			// 
			// textBoxForTxTimer
			// 
			this.textBoxForTxTimer.Location = new System.Drawing.Point(6, 86);
			this.textBoxForTxTimer.Name = "textBoxForTxTimer";
			this.textBoxForTxTimer.Size = new System.Drawing.Size(42, 21);
			this.textBoxForTxTimer.TabIndex = 13;
			this.textBoxForTxTimer.Text = "1000";
			this.textBoxForTxTimer.TextChanged += new System.EventHandler(this.textBoxForTxTimer_TextChanged);
			// 
			// checkBoxForRxAutoClear
			// 
			this.checkBoxForRxAutoClear.AutoSize = true;
			this.checkBoxForRxAutoClear.Location = new System.Drawing.Point(6, 86);
			this.checkBoxForRxAutoClear.Name = "checkBoxForRxAutoClear";
			this.checkBoxForRxAutoClear.Size = new System.Drawing.Size(72, 16);
			this.checkBoxForRxAutoClear.TabIndex = 18;
			this.checkBoxForRxAutoClear.Text = "自动清除";
			this.checkBoxForRxAutoClear.UseVisualStyleBackColor = true;
			this.checkBoxForRxAutoClear.CheckedChanged += new System.EventHandler(this.checkBoxForRxAutoClear_CheckedChanged);
			// 
			// checkBoxForRxHex
			// 
			this.checkBoxForRxHex.AutoSize = true;
			this.checkBoxForRxHex.Location = new System.Drawing.Point(6, 64);
			this.checkBoxForRxHex.Name = "checkBoxForRxHex";
			this.checkBoxForRxHex.Size = new System.Drawing.Size(66, 16);
			this.checkBoxForRxHex.TabIndex = 14;
			this.checkBoxForRxHex.Text = "HEX显示";
			this.checkBoxForRxHex.UseVisualStyleBackColor = true;
			this.checkBoxForRxHex.CheckedChanged += new System.EventHandler(this.checkBoxForRxHex_CheckedChanged);
			// 
			// checkBoxForRxTimeDisplay
			// 
			this.checkBoxForRxTimeDisplay.AutoSize = true;
			this.checkBoxForRxTimeDisplay.Location = new System.Drawing.Point(6, 42);
			this.checkBoxForRxTimeDisplay.Name = "checkBoxForRxTimeDisplay";
			this.checkBoxForRxTimeDisplay.Size = new System.Drawing.Size(60, 16);
			this.checkBoxForRxTimeDisplay.TabIndex = 15;
			this.checkBoxForRxTimeDisplay.Text = "时间戳";
			this.checkBoxForRxTimeDisplay.UseVisualStyleBackColor = true;
			this.checkBoxForRxTimeDisplay.CheckedChanged += new System.EventHandler(this.checkBoxForRxTimeDisplay_CheckedChanged);
			// 
			// checkBoxForRxNewLine
			// 
			this.checkBoxForRxNewLine.AutoSize = true;
			this.checkBoxForRxNewLine.Location = new System.Drawing.Point(6, 20);
			this.checkBoxForRxNewLine.Name = "checkBoxForRxNewLine";
			this.checkBoxForRxNewLine.Size = new System.Drawing.Size(48, 16);
			this.checkBoxForRxNewLine.TabIndex = 17;
			this.checkBoxForRxNewLine.Text = "换行";
			this.checkBoxForRxNewLine.UseVisualStyleBackColor = true;
			this.checkBoxForRxNewLine.CheckedChanged += new System.EventHandler(this.checkBoxForRxNewLine_CheckedChanged);
			// 
			// labelForTxTimer
			// 
			this.labelForTxTimer.AutoSize = true;
			this.labelForTxTimer.Location = new System.Drawing.Point(54, 95);
			this.labelForTxTimer.Name = "labelForTxTimer";
			this.labelForTxTimer.Size = new System.Drawing.Size(17, 12);
			this.labelForTxTimer.TabIndex = 15;
			this.labelForTxTimer.Text = "ms";
			// 
			// groupBoxForRx
			// 
			this.groupBoxForRx.Controls.Add(this.checkBoxForRxAutoClear);
			this.groupBoxForRx.Controls.Add(this.checkBoxForRxNewLine);
			this.groupBoxForRx.Controls.Add(this.checkBoxForRxHex);
			this.groupBoxForRx.Controls.Add(this.checkBoxForRxTimeDisplay);
			this.groupBoxForRx.Location = new System.Drawing.Point(12, 138);
			this.groupBoxForRx.Name = "groupBoxForRx";
			this.groupBoxForRx.Size = new System.Drawing.Size(82, 112);
			this.groupBoxForRx.TabIndex = 22;
			this.groupBoxForRx.TabStop = false;
			this.groupBoxForRx.Text = "接收";
			// 
			// groupBoxForTx
			// 
			this.groupBoxForTx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBoxForTx.Controls.Add(this.labelForTxTimer);
			this.groupBoxForTx.Controls.Add(this.checkBoxForTxHex);
			this.groupBoxForTx.Controls.Add(this.checkBoxForTxNewLine);
			this.groupBoxForTx.Controls.Add(this.textBoxForTxTimer);
			this.groupBoxForTx.Controls.Add(this.checkBoxForTxTimer);
			this.groupBoxForTx.Location = new System.Drawing.Point(12, 278);
			this.groupBoxForTx.Name = "groupBoxForTx";
			this.groupBoxForTx.Size = new System.Drawing.Size(82, 112);
			this.groupBoxForTx.TabIndex = 23;
			this.groupBoxForTx.TabStop = false;
			this.groupBoxForTx.Text = "发送";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer1.Location = new System.Drawing.Point(100, 28);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
			this.splitContainer1.Panel1.Controls.Add(this.textBoxForRxArea);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.AutoScroll = true;
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(634, 461);
			this.splitContainer1.SplitterDistance = 309;
			this.splitContainer1.TabIndex = 25;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabControl1.Location = new System.Drawing.Point(0, 362);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(309, 99);
			this.tabControl1.TabIndex = 7;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Controls.Add(this.textBoxForTxArea);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(301, 73);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "发送";
			// 
			// textBoxForTxArea
			// 
			this.textBoxForTxArea.BackColor = System.Drawing.Color.White;
			this.textBoxForTxArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxForTxArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxForTxArea.Location = new System.Drawing.Point(3, 3);
			this.textBoxForTxArea.Margin = new System.Windows.Forms.Padding(0);
			this.textBoxForTxArea.Multiline = true;
			this.textBoxForTxArea.Name = "textBoxForTxArea";
			this.textBoxForTxArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxForTxArea.Size = new System.Drawing.Size(295, 67);
			this.textBoxForTxArea.TabIndex = 6;
			this.textBoxForTxArea.TextChanged += new System.EventHandler(this.textBoxForTxArea_TextChanged);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.textBoxForFrameHead);
			this.tabPage4.Controls.Add(this.label5);
			this.tabPage4.Controls.Add(this.textBoxForFrameOvertime);
			this.tabPage4.Controls.Add(this.radioButtonForFrameHead);
			this.tabPage4.Controls.Add(this.radioButtonForFrameOvertime);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(301, 73);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "分帧";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// textBoxForFrameHead
			// 
			this.textBoxForFrameHead.Location = new System.Drawing.Point(70, 26);
			this.textBoxForFrameHead.Name = "textBoxForFrameHead";
			this.textBoxForFrameHead.Size = new System.Drawing.Size(100, 21);
			this.textBoxForFrameHead.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(177, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(17, 12);
			this.label5.TabIndex = 3;
			this.label5.Text = "ms";
			// 
			// textBoxForFrameOvertime
			// 
			this.textBoxForFrameOvertime.Location = new System.Drawing.Point(70, 7);
			this.textBoxForFrameOvertime.Name = "textBoxForFrameOvertime";
			this.textBoxForFrameOvertime.Size = new System.Drawing.Size(100, 21);
			this.textBoxForFrameOvertime.TabIndex = 2;
			this.textBoxForFrameOvertime.Text = "20";
			this.textBoxForFrameOvertime.TextChanged += new System.EventHandler(this.textBoxForFrameOvertime_TextChanged);
			// 
			// radioButtonForFrameHead
			// 
			this.radioButtonForFrameHead.AutoSize = true;
			this.radioButtonForFrameHead.Location = new System.Drawing.Point(7, 30);
			this.radioButtonForFrameHead.Name = "radioButtonForFrameHead";
			this.radioButtonForFrameHead.Size = new System.Drawing.Size(47, 16);
			this.radioButtonForFrameHead.TabIndex = 1;
			this.radioButtonForFrameHead.Text = "帧头";
			this.radioButtonForFrameHead.UseVisualStyleBackColor = true;
			// 
			// radioButtonForFrameOvertime
			// 
			this.radioButtonForFrameOvertime.AutoSize = true;
			this.radioButtonForFrameOvertime.Checked = true;
			this.radioButtonForFrameOvertime.Location = new System.Drawing.Point(7, 7);
			this.radioButtonForFrameOvertime.Name = "radioButtonForFrameOvertime";
			this.radioButtonForFrameOvertime.Size = new System.Drawing.Size(47, 16);
			this.radioButtonForFrameOvertime.TabIndex = 0;
			this.radioButtonForFrameOvertime.TabStop = true;
			this.radioButtonForFrameOvertime.Text = "超时";
			this.radioButtonForFrameOvertime.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.White;
			this.tabPage2.Controls.Add(this.textBoxForSumCheckLenth);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.textBoxForSumCheckStartAddress);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.textBoxForCrcCheckLenth);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.textBoxForCrcCheckStartAddress);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.checkBoxForSumCheck);
			this.tabPage2.Controls.Add(this.checkBoxForCrcCheck);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(301, 73);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "协议";
			// 
			// textBoxForSumCheckLenth
			// 
			this.textBoxForSumCheckLenth.Location = new System.Drawing.Point(204, 30);
			this.textBoxForSumCheckLenth.Name = "textBoxForSumCheckLenth";
			this.textBoxForSumCheckLenth.Size = new System.Drawing.Size(29, 21);
			this.textBoxForSumCheckLenth.TabIndex = 9;
			this.textBoxForSumCheckLenth.Text = "0";
			this.textBoxForSumCheckLenth.TextChanged += new System.EventHandler(this.textBoxForSumCheckLenth_TextChanged);
			this.textBoxForSumCheckLenth.MouseHover += new System.EventHandler(this.textBoxForSumCheckLenth_MouseHover);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(170, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "长度：";
			// 
			// textBoxForSumCheckStartAddress
			// 
			this.textBoxForSumCheckStartAddress.Location = new System.Drawing.Point(122, 30);
			this.textBoxForSumCheckStartAddress.Name = "textBoxForSumCheckStartAddress";
			this.textBoxForSumCheckStartAddress.Size = new System.Drawing.Size(29, 21);
			this.textBoxForSumCheckStartAddress.TabIndex = 7;
			this.textBoxForSumCheckStartAddress.Text = "0";
			this.textBoxForSumCheckStartAddress.TextChanged += new System.EventHandler(this.textBoxForSumCheckStartAddress_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(63, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "起始地址：";
			// 
			// textBoxForCrcCheckLenth
			// 
			this.textBoxForCrcCheckLenth.Location = new System.Drawing.Point(204, 4);
			this.textBoxForCrcCheckLenth.Name = "textBoxForCrcCheckLenth";
			this.textBoxForCrcCheckLenth.Size = new System.Drawing.Size(29, 21);
			this.textBoxForCrcCheckLenth.TabIndex = 5;
			this.textBoxForCrcCheckLenth.Text = "0";
			this.textBoxForCrcCheckLenth.TextChanged += new System.EventHandler(this.textBoxForCrcCheckLenth_TextChanged);
			this.textBoxForCrcCheckLenth.MouseHover += new System.EventHandler(this.textBoxForCrcCheckLenth_MouseHover);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(170, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "长度：";
			// 
			// textBoxForCrcCheckStartAddress
			// 
			this.textBoxForCrcCheckStartAddress.Location = new System.Drawing.Point(122, 4);
			this.textBoxForCrcCheckStartAddress.Name = "textBoxForCrcCheckStartAddress";
			this.textBoxForCrcCheckStartAddress.Size = new System.Drawing.Size(29, 21);
			this.textBoxForCrcCheckStartAddress.TabIndex = 3;
			this.textBoxForCrcCheckStartAddress.Text = "0";
			this.textBoxForCrcCheckStartAddress.TextChanged += new System.EventHandler(this.textBoxForCrcCheckStartAddress_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "起始地址：";
			// 
			// checkBoxForSumCheck
			// 
			this.checkBoxForSumCheck.AutoSize = true;
			this.checkBoxForSumCheck.Location = new System.Drawing.Point(3, 35);
			this.checkBoxForSumCheck.Name = "checkBoxForSumCheck";
			this.checkBoxForSumCheck.Size = new System.Drawing.Size(42, 16);
			this.checkBoxForSumCheck.TabIndex = 1;
			this.checkBoxForSumCheck.Text = "SUM";
			this.checkBoxForSumCheck.UseVisualStyleBackColor = true;
			this.checkBoxForSumCheck.CheckedChanged += new System.EventHandler(this.checkBoxForSumCheck_CheckedChanged);
			// 
			// checkBoxForCrcCheck
			// 
			this.checkBoxForCrcCheck.AutoSize = true;
			this.checkBoxForCrcCheck.Location = new System.Drawing.Point(3, 6);
			this.checkBoxForCrcCheck.Name = "checkBoxForCrcCheck";
			this.checkBoxForCrcCheck.Size = new System.Drawing.Size(42, 16);
			this.checkBoxForCrcCheck.TabIndex = 0;
			this.checkBoxForCrcCheck.Text = "CRC";
			this.checkBoxForCrcCheck.UseVisualStyleBackColor = true;
			this.checkBoxForCrcCheck.CheckedChanged += new System.EventHandler(this.checkBoxForCrcCheck_CheckedChanged);
			this.checkBoxForCrcCheck.MouseHover += new System.EventHandler(this.checkBoxForCrcCheck_MouseHover);
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.White;
			this.tabPage3.Controls.Add(this.textBox1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(301, 73);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "声明";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(295, 70);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "当您使用该软件的时候，默认您已经同意了以下协议：\r\n1. 你可以免费传递本软件；\r\n2. 不可以对本软件进行逆向工程；\r\n3. 运行环境： .net framew" +
    "ork 4.0；\r\n4. 该版本（V1.1）软件的基本功能免费使用；\r\n5. 对使用软件所产生的任何后果，由用户自己承担；\r\n6. 最终解释权归作者本人所有。";
			// 
			// textBoxForRxArea
			// 
			this.textBoxForRxArea.AcceptsTab = true;
			this.textBoxForRxArea.AllowDrop = true;
			this.textBoxForRxArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxForRxArea.BackColor = System.Drawing.SystemColors.WindowText;
			this.textBoxForRxArea.ForeColor = System.Drawing.Color.LawnGreen;
			this.textBoxForRxArea.Location = new System.Drawing.Point(0, 0);
			this.textBoxForRxArea.Margin = new System.Windows.Forms.Padding(0);
			this.textBoxForRxArea.Multiline = true;
			this.textBoxForRxArea.Name = "textBoxForRxArea";
			this.textBoxForRxArea.ReadOnly = true;
			this.textBoxForRxArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxForRxArea.Size = new System.Drawing.Size(310, 362);
			this.textBoxForRxArea.TabIndex = 1;
			this.textBoxForRxArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxForRxArea_KeyDown);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.AutoScroll = true;
			this.splitContainer2.Panel1.Controls.Add(this.checkBoxForMulTxView);
			this.splitContainer2.Panel1.Controls.Add(this.textBoxForMulTxNum);
			this.splitContainer2.Panel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_Panel1_MouseWheel);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.AutoScroll = true;
			this.splitContainer2.Panel2.Controls.Add(this.buttonForMulTxBorn);
			this.splitContainer2.Panel2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_Panel2_MouseWheel);
			this.splitContainer2.Size = new System.Drawing.Size(321, 461);
			this.splitContainer2.SplitterDistance = 151;
			this.splitContainer2.TabIndex = 0;
			// 
			// checkBoxForMulTxView
			// 
			this.checkBoxForMulTxView.AutoSize = true;
			this.checkBoxForMulTxView.Location = new System.Drawing.Point(3, 3);
			this.checkBoxForMulTxView.Margin = new System.Windows.Forms.Padding(0);
			this.checkBoxForMulTxView.Name = "checkBoxForMulTxView";
			this.checkBoxForMulTxView.Size = new System.Drawing.Size(15, 14);
			this.checkBoxForMulTxView.TabIndex = 2;
			this.checkBoxForMulTxView.UseVisualStyleBackColor = true;
			// 
			// textBoxForMulTxNum
			// 
			this.textBoxForMulTxNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxForMulTxNum.Location = new System.Drawing.Point(18, 3);
			this.textBoxForMulTxNum.Margin = new System.Windows.Forms.Padding(0);
			this.textBoxForMulTxNum.Name = "textBoxForMulTxNum";
			this.textBoxForMulTxNum.Size = new System.Drawing.Size(111, 21);
			this.textBoxForMulTxNum.TabIndex = 0;
			this.textBoxForMulTxNum.Text = "10";
			this.textBoxForMulTxNum.Enter += new System.EventHandler(this.textBoxForMulTxNum_Enter);
			this.textBoxForMulTxNum.Leave += new System.EventHandler(this.textBoxForMulTxNum_Leave);
			this.textBoxForMulTxNum.MouseHover += new System.EventHandler(this.textBoxForMulTxCount_MouseHover);
			// 
			// buttonForMulTxBorn
			// 
			this.buttonForMulTxBorn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonForMulTxBorn.Location = new System.Drawing.Point(3, 3);
			this.buttonForMulTxBorn.Name = "buttonForMulTxBorn";
			this.buttonForMulTxBorn.Size = new System.Drawing.Size(144, 22);
			this.buttonForMulTxBorn.TabIndex = 0;
			this.buttonForMulTxBorn.Text = "Generate";
			this.buttonForMulTxBorn.UseVisualStyleBackColor = true;
			this.buttonForMulTxBorn.Click += new System.EventHandler(this.buttonForMulTxBorn_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.AutoSize = false;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4});
			this.statusStrip1.Location = new System.Drawing.Point(0, 493);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(734, 28);
			this.statusStrip1.TabIndex = 27;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.AutoSize = false;
			this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemForNotepad,
            this.toolStripMenuItemForCalculator});
			this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(98, 26);
			this.toolStripSplitButton1.Text = " 小工具箱";
			this.toolStripSplitButton1.ToolTipText = "这里有你常用的小软件！";
			// 
			// toolStripMenuItemForNotepad
			// 
			this.toolStripMenuItemForNotepad.Name = "toolStripMenuItemForNotepad";
			this.toolStripMenuItemForNotepad.Size = new System.Drawing.Size(112, 22);
			this.toolStripMenuItemForNotepad.Text = "记事本";
			this.toolStripMenuItemForNotepad.Click += new System.EventHandler(this.toolStripMenuItemForNotepad_Click);
			// 
			// toolStripMenuItemForCalculator
			// 
			this.toolStripMenuItemForCalculator.Name = "toolStripMenuItemForCalculator";
			this.toolStripMenuItemForCalculator.Size = new System.Drawing.Size(112, 22);
			this.toolStripMenuItemForCalculator.Text = "计算器";
			this.toolStripMenuItemForCalculator.Click += new System.EventHandler(this.toolStripMenuItemForCalculator_Click);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.AutoSize = false;
			this.toolStripStatusLabel2.AutoToolTip = true;
			this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 23);
			this.toolStripStatusLabel2.Text = " T：0";
			this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripStatusLabel2.ToolTipText = "已发送的字节数";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.AutoSize = false;
			this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(131, 23);
			this.toolStripStatusLabel3.Text = " R：0";
			this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.AutoSize = false;
			this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(160, 23);
			this.toolStripStatusLabel1.Text = " www.lierda.com";
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.AutoSize = false;
			this.toolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(180, 23);
			this.toolStripStatusLabel4.Text = " Now：2017/12/27 22:22:22";
			this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// timer3
			// 
			this.timer3.Enabled = true;
			this.timer3.Interval = 10;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// programBindingSource
			// 
			this.programBindingSource.DataSource = typeof(uart.Program);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(734, 521);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.groupBoxForTx);
			this.Controls.Add(this.groupBoxForRx);
			this.Controls.Add(this.buttonForTxAreaClear);
			this.Controls.Add(this.buttonForTxSend);
			this.Controls.Add(this.buttonForRxAreaClear);
			this.Controls.Add(this.buttonForComSwitch);
			this.Controls.Add(this.comboBoxForComSelect);
			this.Controls.Add(this.comboBoxForBaudRate);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(750, 560);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "涂鸦门锁模拟器（作者：逻辑）";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBoxForRx.ResumeLayout(false);
			this.groupBoxForRx.PerformLayout();
			this.groupBoxForTx.ResumeLayout(false);
			this.groupBoxForTx.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemForFile;
        private System.Windows.Forms.ToolStripMenuItem sonOfmenuItemForOpenFile;
        private System.Windows.Forms.ToolStripMenuItem sonOfmenuItemForSaveFile;
        private System.Windows.Forms.ToolStripMenuItem sonOfmenuItemForCloseFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemForComSet;
        private System.Windows.Forms.ComboBox comboBoxForBaudRate;
        private System.Windows.Forms.ComboBox comboBoxForComSelect;
        private System.Windows.Forms.ToolStripMenuItem sonOfmenuItemForStopBit;
        private System.Windows.Forms.ToolStripComboBox comboBoxForStopBit;
        private System.Windows.Forms.ToolStripMenuItem sonOfmenuItemForDataBit;
        private System.Windows.Forms.ToolStripComboBox comboBoxForDataBit;
        private System.Windows.Forms.ToolStripMenuItem sonOfmenuItemForCheck;
        private System.Windows.Forms.ToolStripComboBox comboBoxForCheck;
        private System.Windows.Forms.Button buttonForRxAreaClear;
        private System.Windows.Forms.Button buttonForComSwitch;

        public System.IO.Ports.SerialPort Com;
        private System.Windows.Forms.Button buttonForTxSend;
        private System.Windows.Forms.Button buttonForTxAreaClear;
        private System.Windows.Forms.CheckBox checkBoxForTxHex;
        private System.Windows.Forms.CheckBox checkBoxForTxNewLine;
        private System.Windows.Forms.CheckBox checkBoxForTxTimer;
        private System.Windows.Forms.TextBox textBoxForTxTimer;
        private System.Windows.Forms.CheckBox checkBoxForRxAutoClear;
        private System.Windows.Forms.CheckBox checkBoxForRxHex;
        private System.Windows.Forms.CheckBox checkBoxForRxTimeDisplay;
        private System.Windows.Forms.CheckBox checkBoxForRxNewLine;
        private System.Windows.Forms.Label labelForTxTimer;
        private System.Windows.Forms.GroupBox groupBoxForRx;
        private System.Windows.Forms.GroupBox groupBoxForTx;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxForTxArea;
        private System.Windows.Forms.TextBox textBoxForRxArea;
        private System.Windows.Forms.Button buttonForMulTxBorn;
        private System.Windows.Forms.TextBox textBoxForMulTxNum;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem menuItemForMulTxView;
        private System.Windows.Forms.CheckBox checkBoxForMulTxView;
        private System.Windows.Forms.ToolStripMenuItem menuItemForHelp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemForNotepad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemForCalculator;
        private System.Windows.Forms.ToolStripMenuItem 更多帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复默认ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxForSumCheckLenth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxForSumCheckStartAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxForCrcCheckLenth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxForCrcCheckStartAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxForSumCheck;
        private System.Windows.Forms.CheckBox checkBoxForCrcCheck;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.ToolStripMenuItem aSCIIToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton radioButtonForFrameHead;
        private System.Windows.Forms.RadioButton radioButtonForFrameOvertime;
        private System.Windows.Forms.TextBox textBoxForFrameHead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ToolStripMenuItem 示波器ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxForFrameOvertime;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemForCheck;
    }
}

