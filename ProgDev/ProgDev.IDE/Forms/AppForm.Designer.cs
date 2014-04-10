namespace ProgDev.IDE.Forms
{
   partial class AppForm
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
         WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
         WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
         WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
         WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
         WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
         WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
         WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
         WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
         WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
         WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
         WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
         WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
         WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
         WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
         WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
         this._DockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
         this._Theme = new WeifenLuo.WinFormsUI.Docking.VS2012LightTheme();
         this._ToolStripContainer = new System.Windows.Forms.ToolStripContainer();
         this._StatusStrip = new System.Windows.Forms.StatusStrip();
         this._MenuStrip = new System.Windows.Forms.MenuStrip();
         this._FileMenu = new System.Windows.Forms.ToolStripMenuItem();
         this._EditMenu = new System.Windows.Forms.ToolStripMenuItem();
         this._ProgramMenu = new System.Windows.Forms.ToolStripMenuItem();
         this._ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
         this._HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
         this._AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._ToolStrip = new System.Windows.Forms.ToolStrip();
         this._NewButton = new System.Windows.Forms.ToolStripButton();
         this._OpenButton = new System.Windows.Forms.ToolStripButton();
         this._SaveButton = new System.Windows.Forms.ToolStripButton();
         this._Separator1 = new System.Windows.Forms.ToolStripSeparator();
         this._NewFileBtn = new System.Windows.Forms.ToolStripButton();
         this._NewFolderBtn = new System.Windows.Forms.ToolStripButton();
         this._Separator2 = new System.Windows.Forms.ToolStripSeparator();
         this._BuildButton = new System.Windows.Forms.ToolStripButton();
         this._DeployButton = new System.Windows.Forms.ToolStripButton();
         this._DebugButton = new System.Windows.Forms.ToolStripButton();
         this._ToolStripContainer.BottomToolStripPanel.SuspendLayout();
         this._ToolStripContainer.ContentPanel.SuspendLayout();
         this._ToolStripContainer.TopToolStripPanel.SuspendLayout();
         this._ToolStripContainer.SuspendLayout();
         this._MenuStrip.SuspendLayout();
         this._ToolStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // _DockPanel
         // 
         this._DockPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
         this._DockPanel.DefaultFloatWindowSize = new System.Drawing.Size(300, 400);
         this._DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this._DockPanel.Location = new System.Drawing.Point(0, 0);
         this._DockPanel.Name = "_DockPanel";
         this._DockPanel.ShowDocumentIcon = true;
         this._DockPanel.Size = new System.Drawing.Size(830, 663);
         dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
         dockPanelGradient1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
         autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
         tabGradient1.EndColor = System.Drawing.SystemColors.Control;
         tabGradient1.StartColor = System.Drawing.SystemColors.Control;
         tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
         autoHideStripSkin1.TabGradient = tabGradient1;
         autoHideStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
         dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
         tabGradient2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
         tabGradient2.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
         tabGradient2.TextColor = System.Drawing.Color.White;
         dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
         dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
         dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
         dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
         tabGradient3.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
         tabGradient3.StartColor = System.Drawing.SystemColors.Control;
         tabGradient3.TextColor = System.Drawing.Color.Black;
         dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
         dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
         dockPaneStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
         tabGradient4.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))));
         tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
         tabGradient4.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
         tabGradient4.TextColor = System.Drawing.Color.White;
         dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
         tabGradient5.EndColor = System.Drawing.SystemColors.ControlLightLight;
         tabGradient5.StartColor = System.Drawing.SystemColors.ControlLightLight;
         tabGradient5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
         dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
         dockPanelGradient3.EndColor = System.Drawing.SystemColors.Control;
         dockPanelGradient3.StartColor = System.Drawing.SystemColors.Control;
         dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
         tabGradient6.EndColor = System.Drawing.SystemColors.ControlDark;
         tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
         tabGradient6.StartColor = System.Drawing.SystemColors.Control;
         tabGradient6.TextColor = System.Drawing.SystemColors.GrayText;
         dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
         tabGradient7.EndColor = System.Drawing.SystemColors.Control;
         tabGradient7.StartColor = System.Drawing.SystemColors.Control;
         tabGradient7.TextColor = System.Drawing.SystemColors.GrayText;
         dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
         dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
         dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
         this._DockPanel.Skin = dockPanelSkin1;
         this._DockPanel.TabIndex = 0;
         this._DockPanel.Theme = this._Theme;
         // 
         // _ToolStripContainer
         // 
         // 
         // _ToolStripContainer.BottomToolStripPanel
         // 
         this._ToolStripContainer.BottomToolStripPanel.Controls.Add(this._StatusStrip);
         // 
         // _ToolStripContainer.ContentPanel
         // 
         this._ToolStripContainer.ContentPanel.Controls.Add(this._DockPanel);
         this._ToolStripContainer.ContentPanel.Size = new System.Drawing.Size(830, 663);
         this._ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this._ToolStripContainer.Location = new System.Drawing.Point(0, 0);
         this._ToolStripContainer.Name = "_ToolStripContainer";
         this._ToolStripContainer.Size = new System.Drawing.Size(830, 734);
         this._ToolStripContainer.TabIndex = 5;
         this._ToolStripContainer.Text = "toolStripContainer1";
         // 
         // _ToolStripContainer.TopToolStripPanel
         // 
         this._ToolStripContainer.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
         this._ToolStripContainer.TopToolStripPanel.Controls.Add(this._MenuStrip);
         this._ToolStripContainer.TopToolStripPanel.Controls.Add(this._ToolStrip);
         // 
         // _StatusStrip
         // 
         this._StatusStrip.BackColor = System.Drawing.SystemColors.Control;
         this._StatusStrip.Dock = System.Windows.Forms.DockStyle.None;
         this._StatusStrip.Location = new System.Drawing.Point(0, 0);
         this._StatusStrip.Name = "_StatusStrip";
         this._StatusStrip.Size = new System.Drawing.Size(830, 22);
         this._StatusStrip.TabIndex = 0;
         // 
         // _MenuStrip
         // 
         this._MenuStrip.BackColor = System.Drawing.SystemColors.Control;
         this._MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
         this._MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._FileMenu,
            this._EditMenu,
            this._ProgramMenu,
            this._ToolsMenu,
            this._HelpMenu});
         this._MenuStrip.Location = new System.Drawing.Point(0, 0);
         this._MenuStrip.Name = "_MenuStrip";
         this._MenuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
         this._MenuStrip.Size = new System.Drawing.Size(830, 24);
         this._MenuStrip.TabIndex = 0;
         this._MenuStrip.Text = "menuStrip1";
         // 
         // _FileMenu
         // 
         this._FileMenu.Name = "_FileMenu";
         this._FileMenu.Size = new System.Drawing.Size(37, 20);
         this._FileMenu.Text = "&File";
         // 
         // _EditMenu
         // 
         this._EditMenu.Name = "_EditMenu";
         this._EditMenu.Size = new System.Drawing.Size(39, 20);
         this._EditMenu.Text = "&Edit";
         // 
         // _ProgramMenu
         // 
         this._ProgramMenu.Name = "_ProgramMenu";
         this._ProgramMenu.Size = new System.Drawing.Size(65, 20);
         this._ProgramMenu.Text = "&Program";
         // 
         // _ToolsMenu
         // 
         this._ToolsMenu.Name = "_ToolsMenu";
         this._ToolsMenu.Size = new System.Drawing.Size(48, 20);
         this._ToolsMenu.Text = "&Tools";
         // 
         // _HelpMenu
         // 
         this._HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._AboutMenuItem});
         this._HelpMenu.Name = "_HelpMenu";
         this._HelpMenu.Size = new System.Drawing.Size(44, 20);
         this._HelpMenu.Text = "&Help";
         // 
         // _AboutMenuItem
         // 
         this._AboutMenuItem.Name = "_AboutMenuItem";
         this._AboutMenuItem.Size = new System.Drawing.Size(188, 22);
         this._AboutMenuItem.Text = "&About OSPA ProgDev";
         this._AboutMenuItem.Click += new System.EventHandler(this.OnAboutClick);
         // 
         // _ToolStrip
         // 
         this._ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
         this._ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
         this._ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._NewButton,
            this._OpenButton,
            this._SaveButton,
            this._Separator1,
            this._NewFileBtn,
            this._NewFolderBtn,
            this._Separator2,
            this._BuildButton,
            this._DeployButton,
            this._DebugButton});
         this._ToolStrip.Location = new System.Drawing.Point(3, 24);
         this._ToolStrip.Name = "_ToolStrip";
         this._ToolStrip.Size = new System.Drawing.Size(709, 25);
         this._ToolStrip.TabIndex = 1;
         // 
         // _NewButton
         // 
         this._NewButton.Image = ((System.Drawing.Image)(resources.GetObject("_NewButton.Image")));
         this._NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._NewButton.Name = "_NewButton";
         this._NewButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
         this._NewButton.Size = new System.Drawing.Size(96, 22);
         this._NewButton.Text = "New project";
         // 
         // _OpenButton
         // 
         this._OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("_OpenButton.Image")));
         this._OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._OpenButton.Name = "_OpenButton";
         this._OpenButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
         this._OpenButton.Size = new System.Drawing.Size(110, 22);
         this._OpenButton.Text = "Open project…";
         // 
         // _SaveButton
         // 
         this._SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("_SaveButton.Image")));
         this._SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._SaveButton.Name = "_SaveButton";
         this._SaveButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
         this._SaveButton.Size = new System.Drawing.Size(71, 22);
         this._SaveButton.Text = "Save all";
         // 
         // _Separator1
         // 
         this._Separator1.Name = "_Separator1";
         this._Separator1.Size = new System.Drawing.Size(6, 25);
         // 
         // _NewFileBtn
         // 
         this._NewFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("_NewFileBtn.Image")));
         this._NewFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._NewFileBtn.Name = "_NewFileBtn";
         this._NewFileBtn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
         this._NewFileBtn.Size = new System.Drawing.Size(92, 22);
         this._NewFileBtn.Text = "New POU…";
         // 
         // _NewFolderBtn
         // 
         this._NewFolderBtn.Image = ((System.Drawing.Image)(resources.GetObject("_NewFolderBtn.Image")));
         this._NewFolderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._NewFolderBtn.Name = "_NewFolderBtn";
         this._NewFolderBtn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
         this._NewFolderBtn.Size = new System.Drawing.Size(99, 22);
         this._NewFolderBtn.Text = "New folder…";
         // 
         // _Separator2
         // 
         this._Separator2.Name = "_Separator2";
         this._Separator2.Size = new System.Drawing.Size(6, 25);
         // 
         // _BuildButton
         // 
         this._BuildButton.Image = ((System.Drawing.Image)(resources.GetObject("_BuildButton.Image")));
         this._BuildButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._BuildButton.Name = "_BuildButton";
         this._BuildButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
         this._BuildButton.Size = new System.Drawing.Size(59, 22);
         this._BuildButton.Text = "Build";
         // 
         // _DeployButton
         // 
         this._DeployButton.Image = ((System.Drawing.Image)(resources.GetObject("_DeployButton.Image")));
         this._DeployButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._DeployButton.Name = "_DeployButton";
         this._DeployButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
         this._DeployButton.Size = new System.Drawing.Size(69, 22);
         this._DeployButton.Text = "Deploy";
         // 
         // _DebugButton
         // 
         this._DebugButton.Image = ((System.Drawing.Image)(resources.GetObject("_DebugButton.Image")));
         this._DebugButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._DebugButton.Name = "_DebugButton";
         this._DebugButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
         this._DebugButton.Size = new System.Drawing.Size(67, 22);
         this._DebugButton.Text = "Debug";
         // 
         // AppForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(830, 734);
         this.Controls.Add(this._ToolStripContainer);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.IsMdiContainer = true;
         this.MinimumSize = new System.Drawing.Size(443, 383);
         this.Name = "AppForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "OSPA ProgDev";
         this._ToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
         this._ToolStripContainer.BottomToolStripPanel.PerformLayout();
         this._ToolStripContainer.ContentPanel.ResumeLayout(false);
         this._ToolStripContainer.TopToolStripPanel.ResumeLayout(false);
         this._ToolStripContainer.TopToolStripPanel.PerformLayout();
         this._ToolStripContainer.ResumeLayout(false);
         this._ToolStripContainer.PerformLayout();
         this._MenuStrip.ResumeLayout(false);
         this._MenuStrip.PerformLayout();
         this._ToolStrip.ResumeLayout(false);
         this._ToolStrip.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private WeifenLuo.WinFormsUI.Docking.DockPanel _DockPanel;
      private WeifenLuo.WinFormsUI.Docking.VS2012LightTheme _Theme;
      private System.Windows.Forms.ToolStripContainer _ToolStripContainer;
      private System.Windows.Forms.StatusStrip _StatusStrip;
      private System.Windows.Forms.MenuStrip _MenuStrip;
      private System.Windows.Forms.ToolStripMenuItem _FileMenu;
      private System.Windows.Forms.ToolStripMenuItem _HelpMenu;
      private System.Windows.Forms.ToolStrip _ToolStrip;
      private System.Windows.Forms.ToolStripButton _DebugButton;
      private System.Windows.Forms.ToolStripButton _NewButton;
      private System.Windows.Forms.ToolStripButton _OpenButton;
      private System.Windows.Forms.ToolStripButton _SaveButton;
      private System.Windows.Forms.ToolStripSeparator _Separator1;
      private System.Windows.Forms.ToolStripButton _NewFolderBtn;
      private System.Windows.Forms.ToolStripSeparator _Separator2;
      private System.Windows.Forms.ToolStripButton _BuildButton;
      private System.Windows.Forms.ToolStripButton _DeployButton;
      private System.Windows.Forms.ToolStripMenuItem _AboutMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _EditMenu;
      private System.Windows.Forms.ToolStripMenuItem _ProgramMenu;
      private System.Windows.Forms.ToolStripMenuItem _ToolsMenu;
      private System.Windows.Forms.ToolStripButton _NewFileBtn;
   }
}