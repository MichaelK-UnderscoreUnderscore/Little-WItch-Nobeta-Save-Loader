namespace LWNobeta_Save_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkSkills = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numHP = new System.Windows.Forms.NumericUpDown();
            this.numMP = new System.Windows.Forms.NumericUpDown();
            this.numSTA = new System.Windows.Forms.NumericUpDown();
            this.numSTR = new System.Windows.Forms.NumericUpDown();
            this.numINT = new System.Windows.Forms.NumericUpDown();
            this.numCON = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numSave = new System.Windows.Forms.NumericUpDown();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelErrSkillsOoR = new System.Windows.Forms.Label();
            this.checkDifficulty = new System.Windows.Forms.CheckBox();
            this.numCOUNTER = new System.Windows.Forms.NumericUpDown();
            this.numWIND = new System.Windows.Forms.NumericUpDown();
            this.numLIG = new System.Windows.Forms.NumericUpDown();
            this.numFIR = new System.Windows.Forms.NumericUpDown();
            this.numICE = new System.Windows.Forms.NumericUpDown();
            this.numARC = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelErrSaveFileNotExist = new System.Windows.Forms.Label();
            this.buttonHowTo = new System.Windows.Forms.Button();
            this.comboSPAWNPOINT = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numSPAWN = new System.Windows.Forms.NumericUpDown();
            this.numREGION = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonItems = new System.Windows.Forms.Button();
            this.labelErrSaveLoaded = new System.Windows.Forms.Label();
            this.labelLoad = new System.Windows.Forms.Label();
            this.labelSave = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.numSouls = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.checkHotSave = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fswSave = new System.IO.FileSystemWatcher();
            this.timerWait = new System.Windows.Forms.Timer(this.components);
            this.labelWait = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numINT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCOUNTER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWIND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLIG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numARC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSPAWN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numREGION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSouls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswSave)).BeginInit();
            this.SuspendLayout();
            // 
            // checkSkills
            // 
            this.checkSkills.AutoSize = true;
            this.checkSkills.Location = new System.Drawing.Point(157, 12);
            this.checkSkills.Name = "checkSkills";
            this.checkSkills.Size = new System.Drawing.Size(96, 17);
            this.checkSkills.TabIndex = 0;
            this.checkSkills.Text = "Unlimited Skills";
            this.checkSkills.UseVisualStyleBackColor = true;
            this.checkSkills.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Health";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stamina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Strength";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Intelligence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dexterous";
            // 
            // numHP
            // 
            this.numHP.Location = new System.Drawing.Point(221, 35);
            this.numHP.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHP.Name = "numHP";
            this.numHP.Size = new System.Drawing.Size(87, 20);
            this.numHP.TabIndex = 7;
            this.numHP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMP
            // 
            this.numMP.Location = new System.Drawing.Point(221, 61);
            this.numMP.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numMP.Name = "numMP";
            this.numMP.Size = new System.Drawing.Size(87, 20);
            this.numMP.TabIndex = 8;
            this.numMP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSTA
            // 
            this.numSTA.Location = new System.Drawing.Point(221, 87);
            this.numSTA.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numSTA.Name = "numSTA";
            this.numSTA.Size = new System.Drawing.Size(87, 20);
            this.numSTA.TabIndex = 9;
            this.numSTA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSTR
            // 
            this.numSTR.Location = new System.Drawing.Point(221, 113);
            this.numSTR.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numSTR.Name = "numSTR";
            this.numSTR.Size = new System.Drawing.Size(87, 20);
            this.numSTR.TabIndex = 10;
            this.numSTR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numINT
            // 
            this.numINT.Location = new System.Drawing.Point(221, 139);
            this.numINT.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numINT.Name = "numINT";
            this.numINT.Size = new System.Drawing.Size(87, 20);
            this.numINT.TabIndex = 11;
            this.numINT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCON
            // 
            this.numCON.Location = new System.Drawing.Point(221, 165);
            this.numCON.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numCON.Name = "numCON";
            this.numCON.Size = new System.Drawing.Size(87, 20);
            this.numCON.TabIndex = 12;
            this.numCON.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Save Slot";
            // 
            // numSave
            // 
            this.numSave.Location = new System.Drawing.Point(359, 11);
            this.numSave.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numSave.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSave.Name = "numSave";
            this.numSave.Size = new System.Drawing.Size(42, 20);
            this.numSave.TabIndex = 14;
            this.numSave.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSave.ValueChanged += new System.EventHandler(this.numSave_ValueChanged);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(324, 37);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(106, 23);
            this.buttonLoad.TabIndex = 15;
            this.buttonLoad.Text = "Load Save";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(324, 66);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save Data";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelErrSkillsOoR
            // 
            this.labelErrSkillsOoR.AutoSize = true;
            this.labelErrSkillsOoR.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrSkillsOoR.ForeColor = System.Drawing.Color.Maroon;
            this.labelErrSkillsOoR.Location = new System.Drawing.Point(321, 114);
            this.labelErrSkillsOoR.Name = "labelErrSkillsOoR";
            this.labelErrSkillsOoR.Size = new System.Drawing.Size(157, 28);
            this.labelErrSkillsOoR.TabIndex = 17;
            this.labelErrSkillsOoR.Text = "Skill above 30 or below 1 can\r\ncause unintended behaviour";
            this.labelErrSkillsOoR.Visible = false;
            // 
            // checkDifficulty
            // 
            this.checkDifficulty.AutoSize = true;
            this.checkDifficulty.Location = new System.Drawing.Point(12, 12);
            this.checkDifficulty.Name = "checkDifficulty";
            this.checkDifficulty.Size = new System.Drawing.Size(118, 17);
            this.checkDifficulty.TabIndex = 18;
            this.checkDifficulty.Text = "Advanced Difficulty";
            this.checkDifficulty.UseVisualStyleBackColor = true;
            // 
            // numCOUNTER
            // 
            this.numCOUNTER.Location = new System.Drawing.Point(88, 165);
            this.numCOUNTER.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numCOUNTER.Name = "numCOUNTER";
            this.numCOUNTER.Size = new System.Drawing.Size(42, 20);
            this.numCOUNTER.TabIndex = 30;
            this.numCOUNTER.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numWIND
            // 
            this.numWIND.Location = new System.Drawing.Point(88, 139);
            this.numWIND.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numWIND.Name = "numWIND";
            this.numWIND.Size = new System.Drawing.Size(42, 20);
            this.numWIND.TabIndex = 29;
            this.numWIND.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numLIG
            // 
            this.numLIG.Location = new System.Drawing.Point(88, 113);
            this.numLIG.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numLIG.Name = "numLIG";
            this.numLIG.Size = new System.Drawing.Size(42, 20);
            this.numLIG.TabIndex = 28;
            this.numLIG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numFIR
            // 
            this.numFIR.Location = new System.Drawing.Point(88, 87);
            this.numFIR.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numFIR.Name = "numFIR";
            this.numFIR.Size = new System.Drawing.Size(42, 20);
            this.numFIR.TabIndex = 27;
            this.numFIR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numICE
            // 
            this.numICE.Location = new System.Drawing.Point(88, 61);
            this.numICE.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numICE.Name = "numICE";
            this.numICE.Size = new System.Drawing.Size(42, 20);
            this.numICE.TabIndex = 26;
            this.numICE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numARC
            // 
            this.numARC.Location = new System.Drawing.Point(88, 35);
            this.numARC.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numARC.Name = "numARC";
            this.numARC.Size = new System.Drawing.Size(42, 20);
            this.numARC.TabIndex = 25;
            this.numARC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Counter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Wind";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Lightning";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Fire";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Ice";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Arcane";
            // 
            // labelErrSaveFileNotExist
            // 
            this.labelErrSaveFileNotExist.AutoSize = true;
            this.labelErrSaveFileNotExist.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrSaveFileNotExist.ForeColor = System.Drawing.Color.Maroon;
            this.labelErrSaveFileNotExist.Location = new System.Drawing.Point(321, 92);
            this.labelErrSaveFileNotExist.Name = "labelErrSaveFileNotExist";
            this.labelErrSaveFileNotExist.Size = new System.Drawing.Size(121, 14);
            this.labelErrSaveFileNotExist.TabIndex = 31;
            this.labelErrSaveFileNotExist.Text = "Save File doesn\'t exist";
            this.labelErrSaveFileNotExist.Visible = false;
            // 
            // buttonHowTo
            // 
            this.buttonHowTo.Location = new System.Drawing.Point(324, 145);
            this.buttonHowTo.Name = "buttonHowTo";
            this.buttonHowTo.Size = new System.Drawing.Size(153, 23);
            this.buttonHowTo.TabIndex = 32;
            this.buttonHowTo.Text = "How to use";
            this.buttonHowTo.UseVisualStyleBackColor = true;
            this.buttonHowTo.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboSPAWNPOINT
            // 
            this.comboSPAWNPOINT.FormattingEnabled = true;
            this.comboSPAWNPOINT.Items.AddRange(new object[] {
            "--- Region Game Start (1) ---",
            "Mysty Moon Forest - Okun Shrine",
            "",
            "--- Region Castle (2) ---",
            "0 - Okun Shrine - Entrance Hall",
            "3 - Okun Shrine - Grand Gallery",
            "1 - Okun Shrine - Central Hall",
            "4 - Okun Shrine - Secret Passage",
            "",
            "--- Region Cave / Castle (3) ---",
            "6 - Okun Shrine - Underground Cave",
            "0 - Underground - goddess statue",
            "1 - Okun Shrine - Underground Lobby",
            "5 - Okun Shrine - Underground Prison",
            "",
            "---- Region Lava Castle (4) ---",
            "0 - Lava Ruins - Lobby",
            "1 - Lava Ruins - Dead End",
            "4 - Lava Ruins - Playground",
            "",
            "--------------------------",
            "--- Non Intended ---",
            "--------------------------",
            "",
            "--- Region Title Screen (0) ---",
            "0 - 地下城 (Underground Castle)",
            "",
            "--- Region Castle (2)  ---",
            "5 - Region Entrance",
            "2 - Door to \"Okun Shrine - Underground Lobby\"",
            "",
            "--- Region Cave / Castle (3) ---",
            "7 - Region Entrance, Other side of Mushroom",
            "2 - Door to \"Okun Shrine - Central Hall\"",
            "4 - Door to \"Lava Ruins - Lobby\" (Shortcut)",
            "3 - Door to \"Lava Ruins - Lobby\"",
            "",
            "---- Region Lava Castle (4) ---",
            "5 - Door to  \"Okun Shrine - Underground Prison\"",
            "3 - Door to \"Okun Shrine - Underground Lobby\""});
            this.comboSPAWNPOINT.Location = new System.Drawing.Point(157, 222);
            this.comboSPAWNPOINT.Name = "comboSPAWNPOINT";
            this.comboSPAWNPOINT.Size = new System.Drawing.Size(319, 21);
            this.comboSPAWNPOINT.TabIndex = 33;
            this.comboSPAWNPOINT.Text = "0 - 地下城 (Underground Castle)";
            this.comboSPAWNPOINT.SelectedIndexChanged += new System.EventHandler(this.comboSPAWNPOINT_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(154, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Spawn Point";
            // 
            // numSPAWN
            // 
            this.numSPAWN.Location = new System.Drawing.Point(434, 198);
            this.numSPAWN.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSPAWN.Name = "numSPAWN";
            this.numSPAWN.Size = new System.Drawing.Size(42, 20);
            this.numSPAWN.TabIndex = 38;
            this.numSPAWN.ValueChanged += new System.EventHandler(this.numSPAWN_ValueChanged);
            // 
            // numREGION
            // 
            this.numREGION.Location = new System.Drawing.Point(340, 198);
            this.numREGION.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numREGION.Name = "numREGION";
            this.numREGION.Size = new System.Drawing.Size(42, 20);
            this.numREGION.TabIndex = 37;
            this.numREGION.ValueChanged += new System.EventHandler(this.numREGION_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(293, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Region";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(388, 200);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Spawn";
            // 
            // buttonItems
            // 
            this.buttonItems.Location = new System.Drawing.Point(12, 195);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(126, 23);
            this.buttonItems.TabIndex = 41;
            this.buttonItems.Text = "Items";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // labelErrSaveLoaded
            // 
            this.labelErrSaveLoaded.AutoSize = true;
            this.labelErrSaveLoaded.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrSaveLoaded.ForeColor = System.Drawing.Color.Maroon;
            this.labelErrSaveLoaded.Location = new System.Drawing.Point(321, 92);
            this.labelErrSaveLoaded.Name = "labelErrSaveLoaded";
            this.labelErrSaveLoaded.Size = new System.Drawing.Size(155, 14);
            this.labelErrSaveLoaded.TabIndex = 42;
            this.labelErrSaveLoaded.Text = "Save File needs to be loaded";
            this.labelErrSaveLoaded.Visible = false;
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoad.Location = new System.Drawing.Point(436, 35);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(33, 25);
            this.labelLoad.TabIndex = 43;
            this.labelLoad.Text = "✓";
            this.labelLoad.Visible = false;
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSave.Location = new System.Drawing.Point(436, 64);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(33, 25);
            this.labelSave.TabIndex = 44;
            this.labelSave.Text = "✓";
            this.labelSave.Visible = false;
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 3000;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // timerSave
            // 
            this.timerSave.Interval = 3000;
            this.timerSave.Tick += new System.EventHandler(this.timerSave_Tick);
            // 
            // numSouls
            // 
            this.numSouls.Location = new System.Drawing.Point(51, 223);
            this.numSouls.Maximum = new decimal(new int[] {
            1215750144,
            23,
            0,
            0});
            this.numSouls.Name = "numSouls";
            this.numSouls.Size = new System.Drawing.Size(87, 20);
            this.numSouls.TabIndex = 45;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 225);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "Souls";
            // 
            // checkHotSave
            // 
            this.checkHotSave.AutoSize = true;
            this.checkHotSave.Location = new System.Drawing.Point(407, 12);
            this.checkHotSave.Name = "checkHotSave";
            this.checkHotSave.Size = new System.Drawing.Size(71, 17);
            this.checkHotSave.TabIndex = 47;
            this.checkHotSave.Text = "Hot Save";
            this.toolTip1.SetToolTip(this.checkHotSave, resources.GetString("checkHotSave.ToolTip"));
            this.checkHotSave.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 1000000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // fswSave
            // 
            this.fswSave.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fswSave.Path = "LittleWitchNobeta_Data/Save/";
            this.fswSave.SynchronizingObject = this;
            this.fswSave.Changed += new System.IO.FileSystemEventHandler(this.fswSave_Changed);
            // 
            // timerWait
            // 
            this.timerWait.Interval = 1000;
            this.timerWait.Tick += new System.EventHandler(this.timerWait_Tick);
            // 
            // labelWait
            // 
            this.labelWait.AutoSize = true;
            this.labelWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWait.Location = new System.Drawing.Point(436, 64);
            this.labelWait.Name = "labelWait";
            this.labelWait.Size = new System.Drawing.Size(18, 25);
            this.labelWait.TabIndex = 48;
            this.labelWait.Text = ".";
            this.labelWait.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 249);
            this.Controls.Add(this.labelWait);
            this.Controls.Add(this.checkHotSave);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.numSouls);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.labelLoad);
            this.Controls.Add(this.labelErrSaveLoaded);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numSPAWN);
            this.Controls.Add(this.numREGION);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboSPAWNPOINT);
            this.Controls.Add(this.buttonHowTo);
            this.Controls.Add(this.labelErrSaveFileNotExist);
            this.Controls.Add(this.numCOUNTER);
            this.Controls.Add(this.numWIND);
            this.Controls.Add(this.numLIG);
            this.Controls.Add(this.numFIR);
            this.Controls.Add(this.numICE);
            this.Controls.Add(this.numARC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.checkDifficulty);
            this.Controls.Add(this.labelErrSkillsOoR);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.numSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numCON);
            this.Controls.Add(this.numINT);
            this.Controls.Add(this.numSTR);
            this.Controls.Add(this.numSTA);
            this.Controls.Add(this.numMP);
            this.Controls.Add(this.numHP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkSkills);
            this.Name = "Form1";
            this.Text = "Little Witch Nobeta - Save Editor";
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numINT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCOUNTER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWIND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLIG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numARC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSPAWN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numREGION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSouls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkSkills;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numHP;
        private System.Windows.Forms.NumericUpDown numMP;
        private System.Windows.Forms.NumericUpDown numSTA;
        private System.Windows.Forms.NumericUpDown numSTR;
        private System.Windows.Forms.NumericUpDown numINT;
        private System.Windows.Forms.NumericUpDown numCON;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelErrSkillsOoR;
        private System.Windows.Forms.CheckBox checkDifficulty;
        private System.Windows.Forms.NumericUpDown numCOUNTER;
        private System.Windows.Forms.NumericUpDown numWIND;
        private System.Windows.Forms.NumericUpDown numLIG;
        private System.Windows.Forms.NumericUpDown numFIR;
        private System.Windows.Forms.NumericUpDown numICE;
        private System.Windows.Forms.NumericUpDown numARC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelErrSaveFileNotExist;
        private System.Windows.Forms.Button buttonHowTo;
        private System.Windows.Forms.ComboBox comboSPAWNPOINT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numSPAWN;
        private System.Windows.Forms.NumericUpDown numREGION;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Label labelErrSaveLoaded;
        private System.Windows.Forms.Label labelLoad;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.Timer timerSave;
        private System.Windows.Forms.NumericUpDown numSouls;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox checkHotSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.IO.FileSystemWatcher fswSave;
        private System.Windows.Forms.Timer timerWait;
        private System.Windows.Forms.Label labelWait;
    }
}

