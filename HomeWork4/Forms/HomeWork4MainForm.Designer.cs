namespace HomeWork4.Forms
{

    partial class HomeWork4MainForm
    {

        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (disposing)
            {
                Presenter.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeWork4MainForm));
            this.namesOfFilesSelectorGroupBox = new System.Windows.Forms.GroupBox();
            this.exchangeNamesOfFilesButton = new System.Windows.Forms.Button();
            this.browseForOutputFileNameButton = new System.Windows.Forms.Button();
            this.browseForInputFileNameButton = new System.Windows.Forms.Button();
            this.outputFileNameLabel = new System.Windows.Forms.Label();
            this.inputFileNameLabel = new System.Windows.Forms.Label();
            this.outputFileNameTextBox = new System.Windows.Forms.TextBox();
            this.inputFileNameTextBox = new System.Windows.Forms.TextBox();
            this.keyGroupBox = new System.Windows.Forms.GroupBox();
            this.keyLoadingResultPanel = new System.Windows.Forms.Panel();
            this.keyLoadingResultLabel = new System.Windows.Forms.Label();
            this.loadKeyButton = new System.Windows.Forms.Button();
            this.clearLoadedKeyButton = new System.Windows.Forms.Button();
            this.IVGroupBox = new System.Windows.Forms.GroupBox();
            this.IVLoadingResultPanel = new System.Windows.Forms.Panel();
            this.IVLoadingResultLabel = new System.Windows.Forms.Label();
            this.clearLoadedIVButton = new System.Windows.Forms.Button();
            this.loadIVButton = new System.Windows.Forms.Button();
            this.cipherModeSelectorGroupBox = new System.Windows.Forms.GroupBox();
            this.outputFeedbackCipherModeRadioButton = new System.Windows.Forms.RadioButton();
            this.cipherFeedbackCipherModeRadioButton = new System.Windows.Forms.RadioButton();
            this.cipherBlockChainingCipherModeRadioButton = new System.Windows.Forms.RadioButton();
            this.electronicCodeBookCipherModeRadioButton = new System.Windows.Forms.RadioButton();
            this.keySizeSelectorGroupBox = new System.Windows.Forms.GroupBox();
            this.keySize256BitRadioButton = new System.Windows.Forms.RadioButton();
            this.keySize192BitRadioButton = new System.Windows.Forms.RadioButton();
            this.keySize128BitRadioButton = new System.Windows.Forms.RadioButton();
            this.blockSizeSelectorGroupBox = new System.Windows.Forms.GroupBox();
            this.blockSize256BitRadioButton = new System.Windows.Forms.RadioButton();
            this.blockSize192BitRadioButton = new System.Windows.Forms.RadioButton();
            this.blockSize128BitRadioButton = new System.Windows.Forms.RadioButton();
            this.keyGeneratorGroupBox = new System.Windows.Forms.GroupBox();
            this.useGeneratedKeyAsLoadedKeyButton = new System.Windows.Forms.Button();
            this.clearGeneratedKeyButton = new System.Windows.Forms.Button();
            this.saveKeyButton = new System.Windows.Forms.Button();
            this.generateKeyButton = new System.Windows.Forms.Button();
            this.generatedKeyPanel = new System.Windows.Forms.Panel();
            this.generatedKeyLabel = new System.Windows.Forms.Label();
            this.showOrHideGeneratedKeyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showOrHideGeneratedKeyContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irreduciblePolynomialSelectorGroupBox = new System.Windows.Forms.GroupBox();
            this.irreduciblePolynomialComboBox = new System.Windows.Forms.ComboBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.cipherExecutionStatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.stopCipherOperationExecutionButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.cipherExecutionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startEncryptionOperationMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startDecryptionOperationMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IVGeneratorGroupBox = new System.Windows.Forms.GroupBox();
            this.useGeneratedIVAsLoadedIVButton = new System.Windows.Forms.Button();
            this.clearGeneratedIVButton = new System.Windows.Forms.Button();
            this.generatedIVPanel = new System.Windows.Forms.Panel();
            this.generatedIVLabel = new System.Windows.Forms.Label();
            this.showOrHideGeneratedIVContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showOrHideGeneratedIVContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveIVButton = new System.Windows.Forms.Button();
            this.generateIVButton = new System.Windows.Forms.Button();
            this.namesOfFilesSelectorGroupBox.SuspendLayout();
            this.keyGroupBox.SuspendLayout();
            this.keyLoadingResultPanel.SuspendLayout();
            this.IVGroupBox.SuspendLayout();
            this.IVLoadingResultPanel.SuspendLayout();
            this.cipherModeSelectorGroupBox.SuspendLayout();
            this.keySizeSelectorGroupBox.SuspendLayout();
            this.blockSizeSelectorGroupBox.SuspendLayout();
            this.keyGeneratorGroupBox.SuspendLayout();
            this.generatedKeyPanel.SuspendLayout();
            this.showOrHideGeneratedKeyContextMenuStrip.SuspendLayout();
            this.irreduciblePolynomialSelectorGroupBox.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.IVGeneratorGroupBox.SuspendLayout();
            this.generatedIVPanel.SuspendLayout();
            this.showOrHideGeneratedIVContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // namesOfFilesSelectorGroupBox
            // 
            this.namesOfFilesSelectorGroupBox.Controls.Add(this.exchangeNamesOfFilesButton);
            this.namesOfFilesSelectorGroupBox.Controls.Add(this.browseForOutputFileNameButton);
            this.namesOfFilesSelectorGroupBox.Controls.Add(this.browseForInputFileNameButton);
            this.namesOfFilesSelectorGroupBox.Controls.Add(this.outputFileNameLabel);
            this.namesOfFilesSelectorGroupBox.Controls.Add(this.inputFileNameLabel);
            this.namesOfFilesSelectorGroupBox.Controls.Add(this.outputFileNameTextBox);
            this.namesOfFilesSelectorGroupBox.Controls.Add(this.inputFileNameTextBox);
            this.namesOfFilesSelectorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namesOfFilesSelectorGroupBox.Location = new System.Drawing.Point(12, 27);
            this.namesOfFilesSelectorGroupBox.Name = "namesOfFilesSelectorGroupBox";
            this.namesOfFilesSelectorGroupBox.Size = new System.Drawing.Size(371, 73);
            this.namesOfFilesSelectorGroupBox.TabIndex = 12;
            this.namesOfFilesSelectorGroupBox.TabStop = false;
            this.namesOfFilesSelectorGroupBox.Text = "Names of files";
            // 
            // exchangeNamesOfFilesButton
            // 
            this.exchangeNamesOfFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exchangeNamesOfFilesButton.Image = global::HomeWork4.Properties.Resources.ExchangeNamesOfFilesLeft;
            this.exchangeNamesOfFilesButton.Location = new System.Drawing.Point(317, 19);
            this.exchangeNamesOfFilesButton.Name = "exchangeNamesOfFilesButton";
            this.exchangeNamesOfFilesButton.Size = new System.Drawing.Size(48, 48);
            this.exchangeNamesOfFilesButton.TabIndex = 0;
            this.exchangeNamesOfFilesButton.TabStop = false;
            this.exchangeNamesOfFilesButton.UseVisualStyleBackColor = true;
            this.exchangeNamesOfFilesButton.Click += new System.EventHandler(this.exchangeNamesOfFilesButton_Click);
            this.exchangeNamesOfFilesButton.MouseEnter += new System.EventHandler(this.exchangeNamesOfFilesButton_MouseEnter);
            this.exchangeNamesOfFilesButton.MouseLeave += new System.EventHandler(this.exchangeNamesOfFilesButton_MouseLeave);
            // 
            // browseForOutputFileNameButton
            // 
            this.browseForOutputFileNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseForOutputFileNameButton.Location = new System.Drawing.Point(259, 46);
            this.browseForOutputFileNameButton.Name = "browseForOutputFileNameButton";
            this.browseForOutputFileNameButton.Size = new System.Drawing.Size(52, 21);
            this.browseForOutputFileNameButton.TabIndex = 1;
            this.browseForOutputFileNameButton.TabStop = false;
            this.browseForOutputFileNameButton.Text = "Browse";
            this.browseForOutputFileNameButton.UseVisualStyleBackColor = true;
            this.browseForOutputFileNameButton.Click += new System.EventHandler(this.browseForOutputFileNameButton_Click);
            // 
            // browseForInputFileNameButton
            // 
            this.browseForInputFileNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseForInputFileNameButton.Location = new System.Drawing.Point(259, 19);
            this.browseForInputFileNameButton.Name = "browseForInputFileNameButton";
            this.browseForInputFileNameButton.Size = new System.Drawing.Size(52, 21);
            this.browseForInputFileNameButton.TabIndex = 2;
            this.browseForInputFileNameButton.TabStop = false;
            this.browseForInputFileNameButton.Text = "Browse";
            this.browseForInputFileNameButton.UseVisualStyleBackColor = true;
            this.browseForInputFileNameButton.Click += new System.EventHandler(this.browseForInputFileNameButton_Click);
            // 
            // outputFileNameLabel
            // 
            this.outputFileNameLabel.AutoSize = true;
            this.outputFileNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputFileNameLabel.Location = new System.Drawing.Point(6, 23);
            this.outputFileNameLabel.Name = "outputFileNameLabel";
            this.outputFileNameLabel.Size = new System.Drawing.Size(34, 13);
            this.outputFileNameLabel.TabIndex = 3;
            this.outputFileNameLabel.Text = "Input:";
            // 
            // inputFileNameLabel
            // 
            this.inputFileNameLabel.AutoSize = true;
            this.inputFileNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputFileNameLabel.Location = new System.Drawing.Point(6, 50);
            this.inputFileNameLabel.Name = "inputFileNameLabel";
            this.inputFileNameLabel.Size = new System.Drawing.Size(42, 13);
            this.inputFileNameLabel.TabIndex = 4;
            this.inputFileNameLabel.Text = "Output:";
            // 
            // outputFileNameTextBox
            // 
            this.outputFileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputFileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputFileNameTextBox.Location = new System.Drawing.Point(54, 46);
            this.outputFileNameTextBox.Name = "outputFileNameTextBox";
            this.outputFileNameTextBox.ReadOnly = true;
            this.outputFileNameTextBox.Size = new System.Drawing.Size(199, 21);
            this.outputFileNameTextBox.TabIndex = 5;
            this.outputFileNameTextBox.TabStop = false;
            // 
            // inputFileNameTextBox
            // 
            this.inputFileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFileNameTextBox.Location = new System.Drawing.Point(54, 19);
            this.inputFileNameTextBox.Name = "inputFileNameTextBox";
            this.inputFileNameTextBox.ReadOnly = true;
            this.inputFileNameTextBox.Size = new System.Drawing.Size(199, 21);
            this.inputFileNameTextBox.TabIndex = 6;
            this.inputFileNameTextBox.TabStop = false;
            // 
            // keyGroupBox
            // 
            this.keyGroupBox.Controls.Add(this.keyLoadingResultPanel);
            this.keyGroupBox.Controls.Add(this.loadKeyButton);
            this.keyGroupBox.Controls.Add(this.clearLoadedKeyButton);
            this.keyGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyGroupBox.Location = new System.Drawing.Point(98, 106);
            this.keyGroupBox.Name = "keyGroupBox";
            this.keyGroupBox.Size = new System.Drawing.Size(72, 104);
            this.keyGroupBox.TabIndex = 11;
            this.keyGroupBox.TabStop = false;
            this.keyGroupBox.Text = "Key";
            // 
            // keyLoadingResultPanel
            // 
            this.keyLoadingResultPanel.Controls.Add(this.keyLoadingResultLabel);
            this.keyLoadingResultPanel.Location = new System.Drawing.Point(6, 46);
            this.keyLoadingResultPanel.Name = "keyLoadingResultPanel";
            this.keyLoadingResultPanel.Size = new System.Drawing.Size(60, 25);
            this.keyLoadingResultPanel.TabIndex = 0;
            // 
            // keyLoadingResultLabel
            // 
            this.keyLoadingResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyLoadingResultLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyLoadingResultLabel.Location = new System.Drawing.Point(0, 0);
            this.keyLoadingResultLabel.Name = "keyLoadingResultLabel";
            this.keyLoadingResultLabel.Size = new System.Drawing.Size(60, 25);
            this.keyLoadingResultLabel.TabIndex = 0;
            this.keyLoadingResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadKeyButton
            // 
            this.loadKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadKeyButton.Location = new System.Drawing.Point(6, 19);
            this.loadKeyButton.Name = "loadKeyButton";
            this.loadKeyButton.Size = new System.Drawing.Size(60, 21);
            this.loadKeyButton.TabIndex = 2;
            this.loadKeyButton.TabStop = false;
            this.loadKeyButton.Text = "Load";
            this.loadKeyButton.UseVisualStyleBackColor = true;
            this.loadKeyButton.Click += new System.EventHandler(this.loadKeyButton_Click);
            // 
            // clearLoadedKeyButton
            // 
            this.clearLoadedKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearLoadedKeyButton.Location = new System.Drawing.Point(6, 77);
            this.clearLoadedKeyButton.Name = "clearLoadedKeyButton";
            this.clearLoadedKeyButton.Size = new System.Drawing.Size(60, 21);
            this.clearLoadedKeyButton.TabIndex = 1;
            this.clearLoadedKeyButton.TabStop = false;
            this.clearLoadedKeyButton.Text = "Clear";
            this.clearLoadedKeyButton.UseVisualStyleBackColor = true;
            this.clearLoadedKeyButton.Click += new System.EventHandler(this.clearLoadedKeyButton_Click);
            // 
            // IVGroupBox
            // 
            this.IVGroupBox.Controls.Add(this.IVLoadingResultPanel);
            this.IVGroupBox.Controls.Add(this.clearLoadedIVButton);
            this.IVGroupBox.Controls.Add(this.loadIVButton);
            this.IVGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IVGroupBox.Location = new System.Drawing.Point(98, 216);
            this.IVGroupBox.Name = "IVGroupBox";
            this.IVGroupBox.Size = new System.Drawing.Size(72, 104);
            this.IVGroupBox.TabIndex = 10;
            this.IVGroupBox.TabStop = false;
            this.IVGroupBox.Text = "IV";
            // 
            // IVLoadingResultPanel
            // 
            this.IVLoadingResultPanel.Controls.Add(this.IVLoadingResultLabel);
            this.IVLoadingResultPanel.Location = new System.Drawing.Point(6, 46);
            this.IVLoadingResultPanel.Name = "IVLoadingResultPanel";
            this.IVLoadingResultPanel.Size = new System.Drawing.Size(60, 25);
            this.IVLoadingResultPanel.TabIndex = 0;
            // 
            // IVLoadingResultLabel
            // 
            this.IVLoadingResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IVLoadingResultLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IVLoadingResultLabel.Location = new System.Drawing.Point(0, 0);
            this.IVLoadingResultLabel.Name = "IVLoadingResultLabel";
            this.IVLoadingResultLabel.Size = new System.Drawing.Size(60, 25);
            this.IVLoadingResultLabel.TabIndex = 0;
            this.IVLoadingResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearLoadedIVButton
            // 
            this.clearLoadedIVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearLoadedIVButton.Location = new System.Drawing.Point(6, 77);
            this.clearLoadedIVButton.Name = "clearLoadedIVButton";
            this.clearLoadedIVButton.Size = new System.Drawing.Size(60, 21);
            this.clearLoadedIVButton.TabIndex = 1;
            this.clearLoadedIVButton.TabStop = false;
            this.clearLoadedIVButton.Text = "Clear";
            this.clearLoadedIVButton.UseVisualStyleBackColor = true;
            this.clearLoadedIVButton.Click += new System.EventHandler(this.clearLoadedIVButton_Click);
            // 
            // loadIVButton
            // 
            this.loadIVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadIVButton.Location = new System.Drawing.Point(6, 19);
            this.loadIVButton.Name = "loadIVButton";
            this.loadIVButton.Size = new System.Drawing.Size(60, 21);
            this.loadIVButton.TabIndex = 2;
            this.loadIVButton.TabStop = false;
            this.loadIVButton.Text = "Load";
            this.loadIVButton.UseVisualStyleBackColor = true;
            this.loadIVButton.Click += new System.EventHandler(this.loadIVButton_Click);
            // 
            // cipherModeSelectorGroupBox
            // 
            this.cipherModeSelectorGroupBox.Controls.Add(this.outputFeedbackCipherModeRadioButton);
            this.cipherModeSelectorGroupBox.Controls.Add(this.cipherFeedbackCipherModeRadioButton);
            this.cipherModeSelectorGroupBox.Controls.Add(this.cipherBlockChainingCipherModeRadioButton);
            this.cipherModeSelectorGroupBox.Controls.Add(this.electronicCodeBookCipherModeRadioButton);
            this.cipherModeSelectorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cipherModeSelectorGroupBox.Location = new System.Drawing.Point(12, 324);
            this.cipherModeSelectorGroupBox.Name = "cipherModeSelectorGroupBox";
            this.cipherModeSelectorGroupBox.Size = new System.Drawing.Size(80, 111);
            this.cipherModeSelectorGroupBox.TabIndex = 9;
            this.cipherModeSelectorGroupBox.TabStop = false;
            this.cipherModeSelectorGroupBox.Text = "Cipher mode";
            // 
            // outputFeedbackCipherModeRadioButton
            // 
            this.outputFeedbackCipherModeRadioButton.AutoSize = true;
            this.outputFeedbackCipherModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputFeedbackCipherModeRadioButton.Location = new System.Drawing.Point(6, 65);
            this.outputFeedbackCipherModeRadioButton.Name = "outputFeedbackCipherModeRadioButton";
            this.outputFeedbackCipherModeRadioButton.Size = new System.Drawing.Size(45, 17);
            this.outputFeedbackCipherModeRadioButton.TabIndex = 0;
            this.outputFeedbackCipherModeRadioButton.Tag = Cryptography.HomeWork4.SymmetricCipherModes.OutputFeedback;
            this.outputFeedbackCipherModeRadioButton.Text = "OFB";
            this.outputFeedbackCipherModeRadioButton.UseVisualStyleBackColor = true;
            this.outputFeedbackCipherModeRadioButton.CheckedChanged += new System.EventHandler(this.anyCipherModeRadioButton_CheckedChanged);
            // 
            // cipherFeedbackCipherModeRadioButton
            // 
            this.cipherFeedbackCipherModeRadioButton.AutoSize = true;
            this.cipherFeedbackCipherModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cipherFeedbackCipherModeRadioButton.Location = new System.Drawing.Point(6, 88);
            this.cipherFeedbackCipherModeRadioButton.Name = "cipherFeedbackCipherModeRadioButton";
            this.cipherFeedbackCipherModeRadioButton.Size = new System.Drawing.Size(44, 17);
            this.cipherFeedbackCipherModeRadioButton.TabIndex = 1;
            this.cipherFeedbackCipherModeRadioButton.Tag = Cryptography.HomeWork4.SymmetricCipherModes.CipherFeedback;
            this.cipherFeedbackCipherModeRadioButton.Text = "CFB";
            this.cipherFeedbackCipherModeRadioButton.UseVisualStyleBackColor = true;
            this.cipherFeedbackCipherModeRadioButton.CheckedChanged += new System.EventHandler(this.anyCipherModeRadioButton_CheckedChanged);
            // 
            // cipherBlockChainingCipherModeRadioButton
            // 
            this.cipherBlockChainingCipherModeRadioButton.AutoSize = true;
            this.cipherBlockChainingCipherModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cipherBlockChainingCipherModeRadioButton.Location = new System.Drawing.Point(6, 42);
            this.cipherBlockChainingCipherModeRadioButton.Name = "cipherBlockChainingCipherModeRadioButton";
            this.cipherBlockChainingCipherModeRadioButton.Size = new System.Drawing.Size(45, 17);
            this.cipherBlockChainingCipherModeRadioButton.TabIndex = 2;
            this.cipherBlockChainingCipherModeRadioButton.Tag = Cryptography.HomeWork4.SymmetricCipherModes.CipherBlockChaining;
            this.cipherBlockChainingCipherModeRadioButton.Text = "CBC";
            this.cipherBlockChainingCipherModeRadioButton.UseVisualStyleBackColor = true;
            this.cipherBlockChainingCipherModeRadioButton.CheckedChanged += new System.EventHandler(this.anyCipherModeRadioButton_CheckedChanged);
            // 
            // electronicCodeBookCipherModeRadioButton
            // 
            this.electronicCodeBookCipherModeRadioButton.AutoSize = true;
            this.electronicCodeBookCipherModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.electronicCodeBookCipherModeRadioButton.Location = new System.Drawing.Point(6, 19);
            this.electronicCodeBookCipherModeRadioButton.Name = "electronicCodeBookCipherModeRadioButton";
            this.electronicCodeBookCipherModeRadioButton.Size = new System.Drawing.Size(45, 17);
            this.electronicCodeBookCipherModeRadioButton.TabIndex = 3;
            this.electronicCodeBookCipherModeRadioButton.Tag = Cryptography.HomeWork4.SymmetricCipherModes.ElectronicCodeBook;
            this.electronicCodeBookCipherModeRadioButton.Text = "ECB";
            this.electronicCodeBookCipherModeRadioButton.UseVisualStyleBackColor = true;
            this.electronicCodeBookCipherModeRadioButton.CheckedChanged += new System.EventHandler(this.anyCipherModeRadioButton_CheckedChanged);
            // 
            // keySizeSelectorGroupBox
            // 
            this.keySizeSelectorGroupBox.Controls.Add(this.keySize256BitRadioButton);
            this.keySizeSelectorGroupBox.Controls.Add(this.keySize192BitRadioButton);
            this.keySizeSelectorGroupBox.Controls.Add(this.keySize128BitRadioButton);
            this.keySizeSelectorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keySizeSelectorGroupBox.Location = new System.Drawing.Point(12, 106);
            this.keySizeSelectorGroupBox.Name = "keySizeSelectorGroupBox";
            this.keySizeSelectorGroupBox.Size = new System.Drawing.Size(80, 104);
            this.keySizeSelectorGroupBox.TabIndex = 8;
            this.keySizeSelectorGroupBox.TabStop = false;
            this.keySizeSelectorGroupBox.Text = "Key size";
            // 
            // keySize256BitRadioButton
            // 
            this.keySize256BitRadioButton.AutoSize = true;
            this.keySize256BitRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keySize256BitRadioButton.Location = new System.Drawing.Point(6, 81);
            this.keySize256BitRadioButton.Name = "keySize256BitRadioButton";
            this.keySize256BitRadioButton.Size = new System.Drawing.Size(56, 17);
            this.keySize256BitRadioButton.TabIndex = 0;
            this.keySize256BitRadioButton.Tag = Cryptography.HomeWork4.RijndaelKeySizes.KeySize256;
            this.keySize256BitRadioButton.Text = "256 bit";
            this.keySize256BitRadioButton.UseVisualStyleBackColor = true;
            this.keySize256BitRadioButton.Click += new System.EventHandler(this.anyKeySizeRadioButton_CheckedChanged);
            // 
            // keySize192BitRadioButton
            // 
            this.keySize192BitRadioButton.AutoSize = true;
            this.keySize192BitRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keySize192BitRadioButton.Location = new System.Drawing.Point(6, 50);
            this.keySize192BitRadioButton.Name = "keySize192BitRadioButton";
            this.keySize192BitRadioButton.Size = new System.Drawing.Size(56, 17);
            this.keySize192BitRadioButton.TabIndex = 1;
            this.keySize192BitRadioButton.Tag = Cryptography.HomeWork4.RijndaelKeySizes.KeySize192;
            this.keySize192BitRadioButton.Text = "192 bit";
            this.keySize192BitRadioButton.UseVisualStyleBackColor = true;
            this.keySize192BitRadioButton.Click += new System.EventHandler(this.anyKeySizeRadioButton_CheckedChanged);
            // 
            // keySize128BitRadioButton
            // 
            this.keySize128BitRadioButton.AutoSize = true;
            this.keySize128BitRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keySize128BitRadioButton.Location = new System.Drawing.Point(6, 19);
            this.keySize128BitRadioButton.Name = "keySize128BitRadioButton";
            this.keySize128BitRadioButton.Size = new System.Drawing.Size(56, 17);
            this.keySize128BitRadioButton.TabIndex = 2;
            this.keySize128BitRadioButton.Tag = Cryptography.HomeWork4.RijndaelKeySizes.KeySize128;
            this.keySize128BitRadioButton.Text = "128 bit";
            this.keySize128BitRadioButton.UseVisualStyleBackColor = true;
            this.keySize128BitRadioButton.CheckedChanged += new System.EventHandler(this.anyKeySizeRadioButton_CheckedChanged);
            // 
            // blockSizeSelectorGroupBox
            // 
            this.blockSizeSelectorGroupBox.Controls.Add(this.blockSize256BitRadioButton);
            this.blockSizeSelectorGroupBox.Controls.Add(this.blockSize192BitRadioButton);
            this.blockSizeSelectorGroupBox.Controls.Add(this.blockSize128BitRadioButton);
            this.blockSizeSelectorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blockSizeSelectorGroupBox.Location = new System.Drawing.Point(12, 216);
            this.blockSizeSelectorGroupBox.Name = "blockSizeSelectorGroupBox";
            this.blockSizeSelectorGroupBox.Size = new System.Drawing.Size(80, 104);
            this.blockSizeSelectorGroupBox.TabIndex = 7;
            this.blockSizeSelectorGroupBox.TabStop = false;
            this.blockSizeSelectorGroupBox.Text = "Block size";
            // 
            // blockSize256BitRadioButton
            // 
            this.blockSize256BitRadioButton.AutoSize = true;
            this.blockSize256BitRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blockSize256BitRadioButton.Location = new System.Drawing.Point(6, 81);
            this.blockSize256BitRadioButton.Name = "blockSize256BitRadioButton";
            this.blockSize256BitRadioButton.Size = new System.Drawing.Size(56, 17);
            this.blockSize256BitRadioButton.TabIndex = 0;
            this.blockSize256BitRadioButton.Tag = Cryptography.HomeWork4.RijndaelBlockSizes.BlockSize256;
            this.blockSize256BitRadioButton.Text = "256 bit";
            this.blockSize256BitRadioButton.UseVisualStyleBackColor = true;
            this.blockSize256BitRadioButton.CheckedChanged += new System.EventHandler(this.anyBlockSizeRadioButton_CheckedChanged);
            // 
            // blockSize192BitRadioButton
            // 
            this.blockSize192BitRadioButton.AutoSize = true;
            this.blockSize192BitRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blockSize192BitRadioButton.Location = new System.Drawing.Point(6, 50);
            this.blockSize192BitRadioButton.Name = "blockSize192BitRadioButton";
            this.blockSize192BitRadioButton.Size = new System.Drawing.Size(56, 17);
            this.blockSize192BitRadioButton.TabIndex = 1;
            this.blockSize192BitRadioButton.Tag = Cryptography.HomeWork4.RijndaelBlockSizes.BlockSize192;
            this.blockSize192BitRadioButton.Text = "192 bit";
            this.blockSize192BitRadioButton.UseVisualStyleBackColor = true;
            this.blockSize192BitRadioButton.CheckedChanged += new System.EventHandler(this.anyBlockSizeRadioButton_CheckedChanged);
            // 
            // blockSize128BitRadioButton
            // 
            this.blockSize128BitRadioButton.AutoSize = true;
            this.blockSize128BitRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blockSize128BitRadioButton.Location = new System.Drawing.Point(6, 19);
            this.blockSize128BitRadioButton.Name = "blockSize128BitRadioButton";
            this.blockSize128BitRadioButton.Size = new System.Drawing.Size(56, 17);
            this.blockSize128BitRadioButton.TabIndex = 2;
            this.blockSize128BitRadioButton.Tag = Cryptography.HomeWork4.RijndaelBlockSizes.BlockSize128;
            this.blockSize128BitRadioButton.Text = "128 bit";
            this.blockSize128BitRadioButton.UseVisualStyleBackColor = true;
            this.blockSize128BitRadioButton.CheckedChanged += new System.EventHandler(this.anyBlockSizeRadioButton_CheckedChanged);
            // 
            // keyGeneratorGroupBox
            // 
            this.keyGeneratorGroupBox.Controls.Add(this.useGeneratedKeyAsLoadedKeyButton);
            this.keyGeneratorGroupBox.Controls.Add(this.clearGeneratedKeyButton);
            this.keyGeneratorGroupBox.Controls.Add(this.saveKeyButton);
            this.keyGeneratorGroupBox.Controls.Add(this.generateKeyButton);
            this.keyGeneratorGroupBox.Controls.Add(this.generatedKeyPanel);
            this.keyGeneratorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyGeneratorGroupBox.Location = new System.Drawing.Point(176, 106);
            this.keyGeneratorGroupBox.Name = "keyGeneratorGroupBox";
            this.keyGeneratorGroupBox.Size = new System.Drawing.Size(207, 104);
            this.keyGeneratorGroupBox.TabIndex = 6;
            this.keyGeneratorGroupBox.TabStop = false;
            this.keyGeneratorGroupBox.Text = "Key generator";
            // 
            // useGeneratedKeyAsLoadedKeyButton
            // 
            this.useGeneratedKeyAsLoadedKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useGeneratedKeyAsLoadedKeyButton.Image = ((System.Drawing.Image)(resources.GetObject("useGeneratedKeyAsLoadedKeyButton.Image")));
            this.useGeneratedKeyAsLoadedKeyButton.Location = new System.Drawing.Point(6, 19);
            this.useGeneratedKeyAsLoadedKeyButton.Name = "useGeneratedKeyAsLoadedKeyButton";
            this.useGeneratedKeyAsLoadedKeyButton.Size = new System.Drawing.Size(21, 52);
            this.useGeneratedKeyAsLoadedKeyButton.TabIndex = 4;
            this.useGeneratedKeyAsLoadedKeyButton.TabStop = false;
            this.useGeneratedKeyAsLoadedKeyButton.UseVisualStyleBackColor = true;
            this.useGeneratedKeyAsLoadedKeyButton.Click += new System.EventHandler(this.useGeneratedKeyAsLoadedKeyButton_Click);
            this.useGeneratedKeyAsLoadedKeyButton.MouseEnter += new System.EventHandler(this.useGeneratedKeyAsLoadedKeyButton_MouseEnter);
            this.useGeneratedKeyAsLoadedKeyButton.MouseLeave += new System.EventHandler(this.useGeneratedKeyAsLoadedKeyButton_MouseLeave);
            // 
            // clearGeneratedKeyButton
            // 
            this.clearGeneratedKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearGeneratedKeyButton.Location = new System.Drawing.Point(140, 77);
            this.clearGeneratedKeyButton.Name = "clearGeneratedKeyButton";
            this.clearGeneratedKeyButton.Size = new System.Drawing.Size(61, 21);
            this.clearGeneratedKeyButton.TabIndex = 1;
            this.clearGeneratedKeyButton.TabStop = false;
            this.clearGeneratedKeyButton.Text = "Clear";
            this.clearGeneratedKeyButton.UseVisualStyleBackColor = true;
            this.clearGeneratedKeyButton.Click += new System.EventHandler(this.clearGeneratedKeyButton_Click);
            // 
            // saveKeyButton
            // 
            this.saveKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveKeyButton.Location = new System.Drawing.Point(73, 77);
            this.saveKeyButton.Name = "saveKeyButton";
            this.saveKeyButton.Size = new System.Drawing.Size(61, 21);
            this.saveKeyButton.TabIndex = 2;
            this.saveKeyButton.TabStop = false;
            this.saveKeyButton.Text = "Save";
            this.saveKeyButton.UseVisualStyleBackColor = true;
            this.saveKeyButton.Click += new System.EventHandler(this.saveKeyButton_Click);
            // 
            // generateKeyButton
            // 
            this.generateKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateKeyButton.Location = new System.Drawing.Point(6, 77);
            this.generateKeyButton.Name = "generateKeyButton";
            this.generateKeyButton.Size = new System.Drawing.Size(61, 21);
            this.generateKeyButton.TabIndex = 3;
            this.generateKeyButton.TabStop = false;
            this.generateKeyButton.Text = "Generate";
            this.generateKeyButton.UseVisualStyleBackColor = true;
            this.generateKeyButton.Click += new System.EventHandler(this.generateKeyButton_Click);
            // 
            // generatedKeyPanel
            // 
            this.generatedKeyPanel.Controls.Add(this.generatedKeyLabel);
            this.generatedKeyPanel.Location = new System.Drawing.Point(33, 19);
            this.generatedKeyPanel.Name = "generatedKeyPanel";
            this.generatedKeyPanel.Size = new System.Drawing.Size(168, 52);
            this.generatedKeyPanel.TabIndex = 0;
            // 
            // generatedKeyLabel
            // 
            this.generatedKeyLabel.ContextMenuStrip = this.showOrHideGeneratedKeyContextMenuStrip;
            this.generatedKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generatedKeyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatedKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.generatedKeyLabel.Name = "generatedKeyLabel";
            this.generatedKeyLabel.Size = new System.Drawing.Size(168, 52);
            this.generatedKeyLabel.TabIndex = 0;
            this.generatedKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showOrHideGeneratedKeyContextMenuStrip
            // 
            this.showOrHideGeneratedKeyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOrHideGeneratedKeyContextMenuStripItem});
            this.showOrHideGeneratedKeyContextMenuStrip.Name = "showOrHideGeneratedKeyContextMenuStrip";
            this.showOrHideGeneratedKeyContextMenuStrip.ShowImageMargin = false;
            this.showOrHideGeneratedKeyContextMenuStrip.Size = new System.Drawing.Size(79, 26);
            this.showOrHideGeneratedKeyContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.showOrHideGeneratedKeyContextMenuStrip_Opening);
            // 
            // showOrHideGeneratedKeyContextMenuStripItem
            // 
            this.showOrHideGeneratedKeyContextMenuStripItem.Name = "showOrHideGeneratedKeyContextMenuStripItem";
            this.showOrHideGeneratedKeyContextMenuStripItem.Size = new System.Drawing.Size(78, 22);
            this.showOrHideGeneratedKeyContextMenuStripItem.Text = "Show";
            this.showOrHideGeneratedKeyContextMenuStripItem.Click += new System.EventHandler(this.showOrHideGeneratedKeyContextMenuStripItem_Click);
            // 
            // irreduciblePolynomialSelectorGroupBox
            // 
            this.irreduciblePolynomialSelectorGroupBox.Controls.Add(this.irreduciblePolynomialComboBox);
            this.irreduciblePolynomialSelectorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.irreduciblePolynomialSelectorGroupBox.Location = new System.Drawing.Point(98, 326);
            this.irreduciblePolynomialSelectorGroupBox.Name = "irreduciblePolynomialSelectorGroupBox";
            this.irreduciblePolynomialSelectorGroupBox.Size = new System.Drawing.Size(285, 109);
            this.irreduciblePolynomialSelectorGroupBox.TabIndex = 5;
            this.irreduciblePolynomialSelectorGroupBox.TabStop = false;
            this.irreduciblePolynomialSelectorGroupBox.Text = "Rijndael irreducible polynomial";
            // 
            // irreduciblePolynomialComboBox
            // 
            this.irreduciblePolynomialComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.irreduciblePolynomialComboBox.DropDownHeight = 60;
            this.irreduciblePolynomialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.irreduciblePolynomialComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.irreduciblePolynomialComboBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.irreduciblePolynomialComboBox.FormattingEnabled = true;
            this.irreduciblePolynomialComboBox.IntegralHeight = false;
            this.irreduciblePolynomialComboBox.Location = new System.Drawing.Point(6, 19);
            this.irreduciblePolynomialComboBox.Name = "irreduciblePolynomialComboBox";
            this.irreduciblePolynomialComboBox.Size = new System.Drawing.Size(273, 23);
            this.irreduciblePolynomialComboBox.TabIndex = 0;
            this.irreduciblePolynomialComboBox.TabStop = false;
            this.irreduciblePolynomialComboBox.SelectedIndexChanged += new System.EventHandler(this.irreduciblePolynomialComboBox_SelectedIndexChanged);
            this.irreduciblePolynomialComboBox.DropDownClosed += new System.EventHandler(this.irreduciblePolynomialComboBox_DropDownClosed);
            this.irreduciblePolynomialComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.irreduciblePolynomialComboBox_KeyDown);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cipherExecutionStatusProgressBar,
            this.stopCipherOperationExecutionButton,
            this.cipherExecutionStatusLabel});
            this.statusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusBar.Location = new System.Drawing.Point(0, 441);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.statusBar.Size = new System.Drawing.Size(395, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 3;
            // 
            // cipherExecutionStatusProgressBar
            // 
            this.cipherExecutionStatusProgressBar.Name = "cipherExecutionStatusProgressBar";
            this.cipherExecutionStatusProgressBar.Size = new System.Drawing.Size(336, 16);
            this.cipherExecutionStatusProgressBar.Step = 1;
            this.cipherExecutionStatusProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // stopCipherOperationExecutionButton
            // 
            this.stopCipherOperationExecutionButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stopCipherOperationExecutionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopCipherOperationExecutionButton.Image = global::HomeWork4.Properties.Resources.StopCipherOperationExecution;
            this.stopCipherOperationExecutionButton.Name = "stopCipherOperationExecutionButton";
            this.stopCipherOperationExecutionButton.ShowDropDownArrow = false;
            this.stopCipherOperationExecutionButton.Size = new System.Drawing.Size(20, 20);
            this.stopCipherOperationExecutionButton.Click += new System.EventHandler(this.stopCipherOperationExecutionButton_Click);
            // 
            // cipherExecutionStatusLabel
            // 
            this.cipherExecutionStatusLabel.Name = "cipherExecutionStatusLabel";
            this.cipherExecutionStatusLabel.Size = new System.Drawing.Size(35, 17);
            this.cipherExecutionStatusLabel.Spring = true;
            this.cipherExecutionStatusLabel.Text = "100%";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMainMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(395, 24);
            this.mainMenu.TabIndex = 4;
            // 
            // fileMainMenuItem
            // 
            this.fileMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startEncryptionOperationMainMenuItem,
            this.startDecryptionOperationMainMenuItem});
            this.fileMainMenuItem.Name = "fileMainMenuItem";
            this.fileMainMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMainMenuItem.Text = "File";
            // 
            // startEncryptionOperationMainMenuItem
            // 
            this.startEncryptionOperationMainMenuItem.Name = "startEncryptionOperationMainMenuItem";
            this.startEncryptionOperationMainMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.startEncryptionOperationMainMenuItem.Size = new System.Drawing.Size(157, 22);
            this.startEncryptionOperationMainMenuItem.Tag = HomeWork4.Enumerations.CipherOperations.Encryption;
            this.startEncryptionOperationMainMenuItem.Text = "Encrypt";
            this.startEncryptionOperationMainMenuItem.Click += new System.EventHandler(this.anyCipherOperationMainMenuItem_Click);
            // 
            // startDecryptionOperationMainMenuItem
            // 
            this.startDecryptionOperationMainMenuItem.Name = "startDecryptionOperationMainMenuItem";
            this.startDecryptionOperationMainMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.startDecryptionOperationMainMenuItem.Size = new System.Drawing.Size(157, 22);
            this.startDecryptionOperationMainMenuItem.Tag = HomeWork4.Enumerations.CipherOperations.Decryption;
            this.startDecryptionOperationMainMenuItem.Text = "Decrypt";
            this.startDecryptionOperationMainMenuItem.Click += new System.EventHandler(this.anyCipherOperationMainMenuItem_Click);
            // 
            // IVGeneratorGroupBox
            // 
            this.IVGeneratorGroupBox.Controls.Add(this.useGeneratedIVAsLoadedIVButton);
            this.IVGeneratorGroupBox.Controls.Add(this.clearGeneratedIVButton);
            this.IVGeneratorGroupBox.Controls.Add(this.generatedIVPanel);
            this.IVGeneratorGroupBox.Controls.Add(this.saveIVButton);
            this.IVGeneratorGroupBox.Controls.Add(this.generateIVButton);
            this.IVGeneratorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IVGeneratorGroupBox.Location = new System.Drawing.Point(176, 216);
            this.IVGeneratorGroupBox.Name = "IVGeneratorGroupBox";
            this.IVGeneratorGroupBox.Size = new System.Drawing.Size(207, 104);
            this.IVGeneratorGroupBox.TabIndex = 2;
            this.IVGeneratorGroupBox.TabStop = false;
            this.IVGeneratorGroupBox.Text = "IV generator";
            // 
            // useGeneratedIVAsLoadedIVButton
            // 
            this.useGeneratedIVAsLoadedIVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useGeneratedIVAsLoadedIVButton.Image = ((System.Drawing.Image)(resources.GetObject("useGeneratedIVAsLoadedIVButton.Image")));
            this.useGeneratedIVAsLoadedIVButton.Location = new System.Drawing.Point(6, 19);
            this.useGeneratedIVAsLoadedIVButton.Name = "useGeneratedIVAsLoadedIVButton";
            this.useGeneratedIVAsLoadedIVButton.Size = new System.Drawing.Size(21, 52);
            this.useGeneratedIVAsLoadedIVButton.TabIndex = 4;
            this.useGeneratedIVAsLoadedIVButton.TabStop = false;
            this.useGeneratedIVAsLoadedIVButton.UseVisualStyleBackColor = true;
            this.useGeneratedIVAsLoadedIVButton.Click += new System.EventHandler(this.useGeneratedIVAsLoadedIVButton_Click);
            this.useGeneratedIVAsLoadedIVButton.MouseEnter += new System.EventHandler(this.useGeneratedIVAsLoadedIVButton_MouseEnter);
            this.useGeneratedIVAsLoadedIVButton.MouseLeave += new System.EventHandler(this.useGeneratedIVAsLoadedIVButton_MouseLeave);
            // 
            // clearGeneratedIVButton
            // 
            this.clearGeneratedIVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearGeneratedIVButton.Location = new System.Drawing.Point(140, 77);
            this.clearGeneratedIVButton.Name = "clearGeneratedIVButton";
            this.clearGeneratedIVButton.Size = new System.Drawing.Size(61, 21);
            this.clearGeneratedIVButton.TabIndex = 1;
            this.clearGeneratedIVButton.TabStop = false;
            this.clearGeneratedIVButton.Text = "Clear";
            this.clearGeneratedIVButton.UseVisualStyleBackColor = true;
            this.clearGeneratedIVButton.Click += new System.EventHandler(this.clearGeneratedIVButton_Click);
            // 
            // generatedIVPanel
            // 
            this.generatedIVPanel.Controls.Add(this.generatedIVLabel);
            this.generatedIVPanel.Location = new System.Drawing.Point(33, 19);
            this.generatedIVPanel.Name = "generatedIVPanel";
            this.generatedIVPanel.Size = new System.Drawing.Size(168, 52);
            this.generatedIVPanel.TabIndex = 0;
            // 
            // generatedIVLabel
            // 
            this.generatedIVLabel.ContextMenuStrip = this.showOrHideGeneratedIVContextMenuStrip;
            this.generatedIVLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generatedIVLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatedIVLabel.Location = new System.Drawing.Point(0, 0);
            this.generatedIVLabel.Name = "generatedIVLabel";
            this.generatedIVLabel.Size = new System.Drawing.Size(168, 52);
            this.generatedIVLabel.TabIndex = 0;
            this.generatedIVLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showOrHideGeneratedIVContextMenuStrip
            // 
            this.showOrHideGeneratedIVContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOrHideGeneratedIVContextMenuStripItem});
            this.showOrHideGeneratedIVContextMenuStrip.Name = "showOrHideGeneratedIVContextMenuStrip";
            this.showOrHideGeneratedIVContextMenuStrip.ShowImageMargin = false;
            this.showOrHideGeneratedIVContextMenuStrip.Size = new System.Drawing.Size(79, 26);
            this.showOrHideGeneratedIVContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.showOrHideGeneratedIVContextMenuStrip_Opening);
            // 
            // showOrHideGeneratedIVContextMenuStripItem
            // 
            this.showOrHideGeneratedIVContextMenuStripItem.Name = "showOrHideGeneratedIVContextMenuStripItem";
            this.showOrHideGeneratedIVContextMenuStripItem.Size = new System.Drawing.Size(78, 22);
            this.showOrHideGeneratedIVContextMenuStripItem.Text = "Show";
            this.showOrHideGeneratedIVContextMenuStripItem.Click += new System.EventHandler(this.showOrHideGeneratedIVContextMenuStripItem_Click);
            // 
            // saveIVButton
            // 
            this.saveIVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveIVButton.Location = new System.Drawing.Point(73, 77);
            this.saveIVButton.Name = "saveIVButton";
            this.saveIVButton.Size = new System.Drawing.Size(61, 21);
            this.saveIVButton.TabIndex = 2;
            this.saveIVButton.TabStop = false;
            this.saveIVButton.Text = "Save";
            this.saveIVButton.UseVisualStyleBackColor = true;
            this.saveIVButton.Click += new System.EventHandler(this.saveIVButton_Click);
            // 
            // generateIVButton
            // 
            this.generateIVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateIVButton.Location = new System.Drawing.Point(6, 77);
            this.generateIVButton.Name = "generateIVButton";
            this.generateIVButton.Size = new System.Drawing.Size(61, 21);
            this.generateIVButton.TabIndex = 3;
            this.generateIVButton.TabStop = false;
            this.generateIVButton.Text = "Generate";
            this.generateIVButton.UseVisualStyleBackColor = true;
            this.generateIVButton.Click += new System.EventHandler(this.generateIVButton_Click);
            // 
            // HomeWork4MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 463);
            this.Controls.Add(this.keyGroupBox);
            this.Controls.Add(this.IVGeneratorGroupBox);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.irreduciblePolynomialSelectorGroupBox);
            this.Controls.Add(this.keyGeneratorGroupBox);
            this.Controls.Add(this.blockSizeSelectorGroupBox);
            this.Controls.Add(this.keySizeSelectorGroupBox);
            this.Controls.Add(this.cipherModeSelectorGroupBox);
            this.Controls.Add(this.IVGroupBox);
            this.Controls.Add(this.namesOfFilesSelectorGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = global::HomeWork4.Properties.Resources.LockIcon;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeWork4MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homework #4";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.HomeWork4MainForm_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeWork4MainForm_FormClosing);
            this.Load += new System.EventHandler(this.HomeWork4MainForm_Load);
            this.namesOfFilesSelectorGroupBox.ResumeLayout(false);
            this.namesOfFilesSelectorGroupBox.PerformLayout();
            this.keyGroupBox.ResumeLayout(false);
            this.keyLoadingResultPanel.ResumeLayout(false);
            this.IVGroupBox.ResumeLayout(false);
            this.IVLoadingResultPanel.ResumeLayout(false);
            this.cipherModeSelectorGroupBox.ResumeLayout(false);
            this.cipherModeSelectorGroupBox.PerformLayout();
            this.keySizeSelectorGroupBox.ResumeLayout(false);
            this.keySizeSelectorGroupBox.PerformLayout();
            this.blockSizeSelectorGroupBox.ResumeLayout(false);
            this.blockSizeSelectorGroupBox.PerformLayout();
            this.keyGeneratorGroupBox.ResumeLayout(false);
            this.generatedKeyPanel.ResumeLayout(false);
            this.showOrHideGeneratedKeyContextMenuStrip.ResumeLayout(false);
            this.irreduciblePolynomialSelectorGroupBox.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.IVGeneratorGroupBox.ResumeLayout(false);
            this.generatedIVPanel.ResumeLayout(false);
            this.showOrHideGeneratedIVContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Controls

        private System.Windows.Forms.GroupBox namesOfFilesSelectorGroupBox;
        private System.Windows.Forms.GroupBox keyGroupBox;
        private System.Windows.Forms.GroupBox IVGroupBox;
        private System.Windows.Forms.GroupBox cipherModeSelectorGroupBox;
        private System.Windows.Forms.GroupBox keySizeSelectorGroupBox;
        private System.Windows.Forms.GroupBox blockSizeSelectorGroupBox;
        private System.Windows.Forms.GroupBox keyGeneratorGroupBox;
        private System.Windows.Forms.Button browseForOutputFileNameButton;
        private System.Windows.Forms.Button browseForInputFileNameButton;
        private System.Windows.Forms.Label outputFileNameLabel;
        private System.Windows.Forms.Label inputFileNameLabel;
        private System.Windows.Forms.TextBox outputFileNameTextBox;
        private System.Windows.Forms.TextBox inputFileNameTextBox;
        private System.Windows.Forms.GroupBox irreduciblePolynomialSelectorGroupBox;
        private System.Windows.Forms.RadioButton outputFeedbackCipherModeRadioButton;
        private System.Windows.Forms.RadioButton cipherFeedbackCipherModeRadioButton;
        private System.Windows.Forms.RadioButton cipherBlockChainingCipherModeRadioButton;
        private System.Windows.Forms.RadioButton electronicCodeBookCipherModeRadioButton;
        private System.Windows.Forms.RadioButton keySize256BitRadioButton;
        private System.Windows.Forms.RadioButton keySize192BitRadioButton;
        private System.Windows.Forms.RadioButton keySize128BitRadioButton;
        private System.Windows.Forms.RadioButton blockSize256BitRadioButton;
        private System.Windows.Forms.RadioButton blockSize192BitRadioButton;
        private System.Windows.Forms.RadioButton blockSize128BitRadioButton;
        private System.Windows.Forms.Label keyLoadingResultLabel;
        private System.Windows.Forms.Button loadKeyButton;
        private System.Windows.Forms.Label IVLoadingResultLabel;
        private System.Windows.Forms.Button loadIVButton;
        private System.Windows.Forms.Button saveKeyButton;
        private System.Windows.Forms.Label generatedKeyLabel;
        private System.Windows.Forms.ComboBox irreduciblePolynomialComboBox;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Button exchangeNamesOfFilesButton;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startEncryptionOperationMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startDecryptionOperationMainMenuItem;
        private System.Windows.Forms.ToolStripProgressBar cipherExecutionStatusProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel cipherExecutionStatusLabel;
        private System.Windows.Forms.ToolStripDropDownButton stopCipherOperationExecutionButton;
        private System.Windows.Forms.Button clearLoadedKeyButton;
        private System.Windows.Forms.Button clearLoadedIVButton;
        private System.Windows.Forms.Button clearGeneratedKeyButton;
        private System.Windows.Forms.Panel keyLoadingResultPanel;
        private System.Windows.Forms.Panel IVLoadingResultPanel;
        private System.Windows.Forms.Panel generatedKeyPanel;
        private System.Windows.Forms.GroupBox IVGeneratorGroupBox;
        private System.Windows.Forms.Panel generatedIVPanel;
        private System.Windows.Forms.Label generatedIVLabel;
        private System.Windows.Forms.Button clearGeneratedIVButton;
        private System.Windows.Forms.Button saveIVButton;
        private System.Windows.Forms.Button generateIVButton;
        private System.Windows.Forms.ContextMenuStrip showOrHideGeneratedKeyContextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip showOrHideGeneratedIVContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showOrHideGeneratedKeyContextMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem showOrHideGeneratedIVContextMenuStripItem;

        #endregion

        private System.Windows.Forms.Button generateKeyButton;
        private System.Windows.Forms.Button useGeneratedKeyAsLoadedKeyButton;
        private System.Windows.Forms.Button useGeneratedIVAsLoadedIVButton;
    }

}