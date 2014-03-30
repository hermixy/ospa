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
         this._DockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
         this._Theme = new WeifenLuo.WinFormsUI.Docking.VS2012LightTheme();
         this._MenuStrip = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutOSPAProgDevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._StatusStrip = new System.Windows.Forms.StatusStrip();
         this._MenuStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // _DockPanel
         // 
         this._DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this._DockPanel.Location = new System.Drawing.Point(0, 24);
         this._DockPanel.Name = "_DockPanel";
         this._DockPanel.Size = new System.Drawing.Size(646, 547);
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
         // _MenuStrip
         // 
         this._MenuStrip.BackColor = System.Drawing.SystemColors.Control;
         this._MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
         this._MenuStrip.Location = new System.Drawing.Point(0, 0);
         this._MenuStrip.Name = "_MenuStrip";
         this._MenuStrip.Size = new System.Drawing.Size(646, 24);
         this._MenuStrip.TabIndex = 3;
         this._MenuStrip.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "&File";
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutOSPAProgDevToolStripMenuItem});
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.helpToolStripMenuItem.Text = "&Help";
         // 
         // aboutOSPAProgDevToolStripMenuItem
         // 
         this.aboutOSPAProgDevToolStripMenuItem.Name = "aboutOSPAProgDevToolStripMenuItem";
         this.aboutOSPAProgDevToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
         this.aboutOSPAProgDevToolStripMenuItem.Text = "&About OSPA ProgDev";
         this.aboutOSPAProgDevToolStripMenuItem.Click += new System.EventHandler(this.OnAboutClick);
         // 
         // _StatusStrip
         // 
         this._StatusStrip.BackColor = System.Drawing.SystemColors.Control;
         this._StatusStrip.Location = new System.Drawing.Point(0, 549);
         this._StatusStrip.Name = "_StatusStrip";
         this._StatusStrip.Size = new System.Drawing.Size(646, 22);
         this._StatusStrip.TabIndex = 4;
         this._StatusStrip.Text = "statusStrip1";
         // 
         // AppForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(646, 571);
         this.Controls.Add(this._StatusStrip);
         this.Controls.Add(this._DockPanel);
         this.Controls.Add(this._MenuStrip);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.IsMdiContainer = true;
         this.MainMenuStrip = this._MenuStrip;
         this.Name = "AppForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "OSPA ProgDev";
         this._MenuStrip.ResumeLayout(false);
         this._MenuStrip.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private WeifenLuo.WinFormsUI.Docking.DockPanel _DockPanel;
      private WeifenLuo.WinFormsUI.Docking.VS2012LightTheme _Theme;
      private System.Windows.Forms.MenuStrip _MenuStrip;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.StatusStrip _StatusStrip;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutOSPAProgDevToolStripMenuItem;
   }
}