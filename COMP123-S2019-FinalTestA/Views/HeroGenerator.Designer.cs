﻿namespace COMP123_S2019_FinalTestA.Views
{
    partial class HeroGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroGenerator));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.AbilityPage = new System.Windows.Forms.TabPage();
            this.PowersPage = new System.Windows.Forms.TabPage();
            this.CharacterSheet = new System.Windows.Forms.TabPage();
            this.HeroToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.HeroMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.HeroNameTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameLAbel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.FightingDataLabel = new System.Windows.Forms.Label();
            this.FightingLabel = new System.Windows.Forms.Label();
            this.AgilityLabel = new System.Windows.Forms.Label();
            this.AgilityDataLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.EnduranceDataLabel = new System.Windows.Forms.Label();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.ReasonDataLabel = new System.Windows.Forms.Label();
            this.IntuationLabel = new System.Windows.Forms.Label();
            this.IntuationDataLabel = new System.Windows.Forms.Label();
            this.PsycheLabel = new System.Windows.Forms.Label();
            this.PsychedataLabel = new System.Windows.Forms.Label();
            this.PopularLabel = new System.Windows.Forms.Label();
            this.PopularDataLabel = new System.Windows.Forms.Label();
            this.PhysicalAbilitiesLabel = new System.Windows.Forms.Label();
            this.MentalAbilitiesLAbel = new System.Windows.Forms.Label();
            this.AbilityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GenerateAbilitiesButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.AbilityPage.SuspendLayout();
            this.CharacterSheet.SuspendLayout();
            this.HeroToolStrip.SuspendLayout();
            this.HeroMenuStrip.SuspendLayout();
            this.AbilityTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilityPage);
            this.MainTabControl.Controls.Add(this.PowersPage);
            this.MainTabControl.Controls.Add(this.CharacterSheet);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(784, 460);
            this.MainTabControl.TabIndex = 0;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.GenerateNameButton);
            this.IdentityPage.Controls.Add(this.HeroNameTextbox);
            this.IdentityPage.Controls.Add(this.LastNameLabel);
            this.IdentityPage.Controls.Add(this.LastNameDataLabel);
            this.IdentityPage.Controls.Add(this.FirstNameDataLabel);
            this.IdentityPage.Controls.Add(this.FirstNameLAbel);
            this.IdentityPage.Controls.Add(this.HeroNameLabel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 33);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Size = new System.Drawing.Size(776, 423);
            this.IdentityPage.TabIndex = 2;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // AbilityPage
            // 
            this.AbilityPage.Controls.Add(this.AbilityTableLayoutPanel);
            this.AbilityPage.Location = new System.Drawing.Point(4, 33);
            this.AbilityPage.Name = "AbilityPage";
            this.AbilityPage.Padding = new System.Windows.Forms.Padding(3);
            this.AbilityPage.Size = new System.Drawing.Size(776, 423);
            this.AbilityPage.TabIndex = 0;
            this.AbilityPage.Text = "Abilities";
            this.AbilityPage.UseVisualStyleBackColor = true;
            // 
            // PowersPage
            // 
            this.PowersPage.Location = new System.Drawing.Point(4, 33);
            this.PowersPage.Name = "PowersPage";
            this.PowersPage.Padding = new System.Windows.Forms.Padding(3);
            this.PowersPage.Size = new System.Drawing.Size(752, 423);
            this.PowersPage.TabIndex = 1;
            this.PowersPage.Text = "Powers";
            this.PowersPage.UseVisualStyleBackColor = true;
            // 
            // CharacterSheet
            // 
            this.CharacterSheet.Controls.Add(this.HeroToolStrip);
            this.CharacterSheet.Controls.Add(this.HeroMenuStrip);
            this.CharacterSheet.Location = new System.Drawing.Point(4, 33);
            this.CharacterSheet.Name = "CharacterSheet";
            this.CharacterSheet.Padding = new System.Windows.Forms.Padding(3);
            this.CharacterSheet.Size = new System.Drawing.Size(752, 423);
            this.CharacterSheet.TabIndex = 3;
            this.CharacterSheet.Text = "Character Sheet";
            this.CharacterSheet.UseVisualStyleBackColor = true;
            // 
            // HeroToolStrip
            // 
            this.HeroToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator3,
            this.helpToolStripButton});
            this.HeroToolStrip.Location = new System.Drawing.Point(3, 27);
            this.HeroToolStrip.Name = "HeroToolStrip";
            this.HeroToolStrip.Size = new System.Drawing.Size(746, 25);
            this.HeroToolStrip.TabIndex = 1;
            this.HeroToolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // HeroMenuStrip
            // 
            this.HeroMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.HeroMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.HeroMenuStrip.Name = "HeroMenuStrip";
            this.HeroMenuStrip.Size = new System.Drawing.Size(746, 24);
            this.HeroMenuStrip.TabIndex = 0;
            this.HeroMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(662, 489);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(110, 45);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 489);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(110, 45);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.Location = new System.Drawing.Point(4, 61);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(189, 35);
            this.HeroNameLabel.TabIndex = 0;
            this.HeroNameLabel.Text = "Enter Hero Name";
            this.HeroNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeroNameTextbox
            // 
            this.HeroNameTextbox.Location = new System.Drawing.Point(199, 63);
            this.HeroNameTextbox.Name = "HeroNameTextbox";
            this.HeroNameTextbox.Size = new System.Drawing.Size(373, 29);
            this.HeroNameTextbox.TabIndex = 1;
            // 
            // FirstNameLAbel
            // 
            this.FirstNameLAbel.Location = new System.Drawing.Point(4, 140);
            this.FirstNameLAbel.Name = "FirstNameLAbel";
            this.FirstNameLAbel.Size = new System.Drawing.Size(189, 35);
            this.FirstNameLAbel.TabIndex = 0;
            this.FirstNameLAbel.Text = "First Name";
            this.FirstNameLAbel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(4, 191);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(189, 35);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameDataLabel.Location = new System.Drawing.Point(199, 140);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(373, 35);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameDataLabel.Location = new System.Drawing.Point(199, 191);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(373, 35);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateNameButton
            // 
            this.GenerateNameButton.Location = new System.Drawing.Point(397, 249);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(175, 41);
            this.GenerateNameButton.TabIndex = 2;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            // 
            // FightingDataLabel
            // 
            this.FightingDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FightingDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FightingDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FightingDataLabel.Location = new System.Drawing.Point(194, 58);
            this.FightingDataLabel.Name = "FightingDataLabel";
            this.FightingDataLabel.Size = new System.Drawing.Size(185, 58);
            this.FightingDataLabel.TabIndex = 1;
            this.FightingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FightingLabel
            // 
            this.FightingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FightingLabel.Location = new System.Drawing.Point(3, 58);
            this.FightingLabel.Name = "FightingLabel";
            this.FightingLabel.Size = new System.Drawing.Size(185, 58);
            this.FightingLabel.TabIndex = 2;
            this.FightingLabel.Text = "Fighting";
            this.FightingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgilityLabel
            // 
            this.AgilityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgilityLabel.Location = new System.Drawing.Point(3, 116);
            this.AgilityLabel.Name = "AgilityLabel";
            this.AgilityLabel.Size = new System.Drawing.Size(185, 58);
            this.AgilityLabel.TabIndex = 2;
            this.AgilityLabel.Text = "Agility";
            this.AgilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgilityDataLabel
            // 
            this.AgilityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgilityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AgilityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgilityDataLabel.Location = new System.Drawing.Point(194, 116);
            this.AgilityDataLabel.Name = "AgilityDataLabel";
            this.AgilityDataLabel.Size = new System.Drawing.Size(185, 58);
            this.AgilityDataLabel.TabIndex = 1;
            this.AgilityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabel.Location = new System.Drawing.Point(3, 174);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(185, 58);
            this.StrengthLabel.TabIndex = 2;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(194, 174);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(185, 58);
            this.StrengthDataLabel.TabIndex = 1;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceLabel.Location = new System.Drawing.Point(3, 232);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(185, 58);
            this.EnduranceLabel.TabIndex = 2;
            this.EnduranceLabel.Text = "Endurance";
            this.EnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnduranceDataLabel
            // 
            this.EnduranceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnduranceDataLabel.Location = new System.Drawing.Point(194, 232);
            this.EnduranceDataLabel.Name = "EnduranceDataLabel";
            this.EnduranceDataLabel.Size = new System.Drawing.Size(185, 58);
            this.EnduranceDataLabel.TabIndex = 1;
            this.EnduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReasonLabel
            // 
            this.ReasonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReasonLabel.Location = new System.Drawing.Point(385, 58);
            this.ReasonLabel.Name = "ReasonLabel";
            this.ReasonLabel.Size = new System.Drawing.Size(185, 58);
            this.ReasonLabel.TabIndex = 2;
            this.ReasonLabel.Text = "Reason";
            this.ReasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReasonDataLabel
            // 
            this.ReasonDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReasonDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReasonDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReasonDataLabel.Location = new System.Drawing.Point(576, 58);
            this.ReasonDataLabel.Name = "ReasonDataLabel";
            this.ReasonDataLabel.Size = new System.Drawing.Size(185, 58);
            this.ReasonDataLabel.TabIndex = 1;
            this.ReasonDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntuationLabel
            // 
            this.IntuationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntuationLabel.Location = new System.Drawing.Point(385, 116);
            this.IntuationLabel.Name = "IntuationLabel";
            this.IntuationLabel.Size = new System.Drawing.Size(185, 58);
            this.IntuationLabel.TabIndex = 2;
            this.IntuationLabel.Text = "Intuation";
            this.IntuationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntuationDataLabel
            // 
            this.IntuationDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntuationDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntuationDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntuationDataLabel.Location = new System.Drawing.Point(576, 116);
            this.IntuationDataLabel.Name = "IntuationDataLabel";
            this.IntuationDataLabel.Size = new System.Drawing.Size(185, 58);
            this.IntuationDataLabel.TabIndex = 1;
            this.IntuationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PsycheLabel
            // 
            this.PsycheLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PsycheLabel.Location = new System.Drawing.Point(385, 174);
            this.PsycheLabel.Name = "PsycheLabel";
            this.PsycheLabel.Size = new System.Drawing.Size(185, 58);
            this.PsycheLabel.TabIndex = 2;
            this.PsycheLabel.Text = "Psyche";
            this.PsycheLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PsychedataLabel
            // 
            this.PsychedataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PsychedataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PsychedataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PsychedataLabel.Location = new System.Drawing.Point(576, 174);
            this.PsychedataLabel.Name = "PsychedataLabel";
            this.PsychedataLabel.Size = new System.Drawing.Size(185, 58);
            this.PsychedataLabel.TabIndex = 1;
            this.PsychedataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopularLabel
            // 
            this.PopularLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PopularLabel.Location = new System.Drawing.Point(385, 232);
            this.PopularLabel.Name = "PopularLabel";
            this.PopularLabel.Size = new System.Drawing.Size(185, 58);
            this.PopularLabel.TabIndex = 2;
            this.PopularLabel.Text = "Popular";
            this.PopularLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopularDataLabel
            // 
            this.PopularDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PopularDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PopularDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PopularDataLabel.Location = new System.Drawing.Point(576, 232);
            this.PopularDataLabel.Name = "PopularDataLabel";
            this.PopularDataLabel.Size = new System.Drawing.Size(185, 58);
            this.PopularDataLabel.TabIndex = 1;
            this.PopularDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhysicalAbilitiesLabel
            // 
            this.PhysicalAbilitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilityTableLayoutPanel.SetColumnSpan(this.PhysicalAbilitiesLabel, 2);
            this.PhysicalAbilitiesLabel.Location = new System.Drawing.Point(3, 0);
            this.PhysicalAbilitiesLabel.Name = "PhysicalAbilitiesLabel";
            this.PhysicalAbilitiesLabel.Size = new System.Drawing.Size(376, 58);
            this.PhysicalAbilitiesLabel.TabIndex = 2;
            this.PhysicalAbilitiesLabel.Text = "Physical Abilities";
            this.PhysicalAbilitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MentalAbilitiesLAbel
            // 
            this.MentalAbilitiesLAbel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilityTableLayoutPanel.SetColumnSpan(this.MentalAbilitiesLAbel, 2);
            this.MentalAbilitiesLAbel.Location = new System.Drawing.Point(385, 0);
            this.MentalAbilitiesLAbel.Name = "MentalAbilitiesLAbel";
            this.MentalAbilitiesLAbel.Size = new System.Drawing.Size(376, 58);
            this.MentalAbilitiesLAbel.TabIndex = 2;
            this.MentalAbilitiesLAbel.Text = "Mental Abilities";
            this.MentalAbilitiesLAbel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbilityTableLayoutPanel
            // 
            this.AbilityTableLayoutPanel.ColumnCount = 4;
            this.AbilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayoutPanel.Controls.Add(this.PhysicalAbilitiesLabel, 0, 0);
            this.AbilityTableLayoutPanel.Controls.Add(this.GenerateAbilitiesButton, 2, 6);
            this.AbilityTableLayoutPanel.Controls.Add(this.PopularDataLabel, 3, 4);
            this.AbilityTableLayoutPanel.Controls.Add(this.MentalAbilitiesLAbel, 2, 0);
            this.AbilityTableLayoutPanel.Controls.Add(this.PsychedataLabel, 3, 3);
            this.AbilityTableLayoutPanel.Controls.Add(this.PopularLabel, 2, 4);
            this.AbilityTableLayoutPanel.Controls.Add(this.IntuationDataLabel, 3, 2);
            this.AbilityTableLayoutPanel.Controls.Add(this.FightingLabel, 0, 1);
            this.AbilityTableLayoutPanel.Controls.Add(this.ReasonDataLabel, 3, 1);
            this.AbilityTableLayoutPanel.Controls.Add(this.AgilityLabel, 0, 2);
            this.AbilityTableLayoutPanel.Controls.Add(this.PsycheLabel, 2, 3);
            this.AbilityTableLayoutPanel.Controls.Add(this.StrengthLabel, 0, 3);
            this.AbilityTableLayoutPanel.Controls.Add(this.EnduranceLabel, 0, 4);
            this.AbilityTableLayoutPanel.Controls.Add(this.IntuationLabel, 2, 2);
            this.AbilityTableLayoutPanel.Controls.Add(this.FightingDataLabel, 1, 1);
            this.AbilityTableLayoutPanel.Controls.Add(this.AgilityDataLabel, 1, 2);
            this.AbilityTableLayoutPanel.Controls.Add(this.ReasonLabel, 2, 1);
            this.AbilityTableLayoutPanel.Controls.Add(this.StrengthDataLabel, 1, 3);
            this.AbilityTableLayoutPanel.Controls.Add(this.EnduranceDataLabel, 1, 4);
            this.AbilityTableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.AbilityTableLayoutPanel.Name = "AbilityTableLayoutPanel";
            this.AbilityTableLayoutPanel.RowCount = 7;
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.Size = new System.Drawing.Size(764, 413);
            this.AbilityTableLayoutPanel.TabIndex = 3;
            // 
            // GenerateAbilitiesButton
            // 
            this.GenerateAbilitiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilityTableLayoutPanel.SetColumnSpan(this.GenerateAbilitiesButton, 2);
            this.GenerateAbilitiesButton.Location = new System.Drawing.Point(385, 351);
            this.GenerateAbilitiesButton.Name = "GenerateAbilitiesButton";
            this.GenerateAbilitiesButton.Size = new System.Drawing.Size(376, 59);
            this.GenerateAbilitiesButton.TabIndex = 1;
            this.GenerateAbilitiesButton.Text = "Generate Abilities";
            this.GenerateAbilitiesButton.UseVisualStyleBackColor = true;
            this.GenerateAbilitiesButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // HeroGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainTabControl);
            this.MainMenuStrip = this.HeroMenuStrip;
            this.Name = "HeroGenerator";
            this.Text = "Hero Generator";
            this.MainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.IdentityPage.PerformLayout();
            this.AbilityPage.ResumeLayout(false);
            this.CharacterSheet.ResumeLayout(false);
            this.CharacterSheet.PerformLayout();
            this.HeroToolStrip.ResumeLayout(false);
            this.HeroToolStrip.PerformLayout();
            this.HeroMenuStrip.ResumeLayout(false);
            this.HeroMenuStrip.PerformLayout();
            this.AbilityTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilityPage;
        private System.Windows.Forms.TabPage PowersPage;
        private System.Windows.Forms.TabPage CharacterSheet;
        private System.Windows.Forms.ToolStrip HeroToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.MenuStrip HeroMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.TextBox HeroNameTextbox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label FirstNameLAbel;
        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.TableLayoutPanel AbilityTableLayoutPanel;
        private System.Windows.Forms.Label PhysicalAbilitiesLabel;
        private System.Windows.Forms.Label PopularDataLabel;
        private System.Windows.Forms.Label MentalAbilitiesLAbel;
        private System.Windows.Forms.Label PsychedataLabel;
        private System.Windows.Forms.Label PopularLabel;
        private System.Windows.Forms.Label IntuationDataLabel;
        private System.Windows.Forms.Label FightingLabel;
        private System.Windows.Forms.Label ReasonDataLabel;
        private System.Windows.Forms.Label AgilityLabel;
        private System.Windows.Forms.Label PsycheLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Label IntuationLabel;
        private System.Windows.Forms.Label FightingDataLabel;
        private System.Windows.Forms.Label AgilityDataLabel;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label EnduranceDataLabel;
        private System.Windows.Forms.Button GenerateAbilitiesButton;
    }
}
