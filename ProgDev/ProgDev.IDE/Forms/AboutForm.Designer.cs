namespace ProgDev.IDE.Forms
{
   partial class AboutForm
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
         System.Windows.Forms.Label label4;
         System.Windows.Forms.Label label5;
         System.Windows.Forms.Label label3;
         System.Windows.Forms.Label label8;
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
         this._TitleLabel = new System.Windows.Forms.Label();
         this._CopyrightLabel = new System.Windows.Forms.Label();
         this._GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
         this._CloseButton = new System.Windows.Forms.Button();
         this._VersionLabel = new System.Windows.Forms.Label();
         this._Subtitle1Label = new System.Windows.Forms.Label();
         this._Subtitle2Label = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this._FarmFreshLinkLabel = new System.Windows.Forms.LinkLabel();
         this.label1 = new System.Windows.Forms.Label();
         this._FatCowLinkLabel = new System.Windows.Forms.LinkLabel();
         this.label2 = new System.Windows.Forms.Label();
         this._CreativeCommonsLinkLabel = new System.Windows.Forms.LinkLabel();
         this._DockPanelLinkLabel = new System.Windows.Forms.LinkLabel();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this._AntlrLinkLabel = new System.Windows.Forms.LinkLabel();
         label4 = new System.Windows.Forms.Label();
         label5 = new System.Windows.Forms.Label();
         label3 = new System.Windows.Forms.Label();
         label8 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new System.Drawing.Point(68, 115);
         label4.Name = "label4";
         label4.Size = new System.Drawing.Size(15, 15);
         label4.TabIndex = 15;
         label4.Text = "♦";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Location = new System.Drawing.Point(68, 139);
         label5.Name = "label5";
         label5.Size = new System.Drawing.Size(15, 15);
         label5.TabIndex = 16;
         label5.Text = "♦";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new System.Drawing.Point(68, 178);
         label3.Name = "label3";
         label3.Size = new System.Drawing.Size(15, 15);
         label3.TabIndex = 18;
         label3.Text = "♦";
         // 
         // label8
         // 
         label8.AutoSize = true;
         label8.Location = new System.Drawing.Point(68, 202);
         label8.Name = "label8";
         label8.Size = new System.Drawing.Size(15, 15);
         label8.TabIndex = 21;
         label8.Text = "♦";
         // 
         // _TitleLabel
         // 
         this._TitleLabel.AutoSize = true;
         this._TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this._TitleLabel.Location = new System.Drawing.Point(66, 7);
         this._TitleLabel.Name = "_TitleLabel";
         this._TitleLabel.Size = new System.Drawing.Size(155, 30);
         this._TitleLabel.TabIndex = 1;
         this._TitleLabel.Text = "OSPA ProgDev";
         // 
         // _CopyrightLabel
         // 
         this._CopyrightLabel.AutoSize = true;
         this._CopyrightLabel.Location = new System.Drawing.Point(68, 91);
         this._CopyrightLabel.Name = "_CopyrightLabel";
         this._CopyrightLabel.Size = new System.Drawing.Size(99, 15);
         this._CopyrightLabel.TabIndex = 5;
         this._CopyrightLabel.Text = "© 2014 Brian Luft";
         // 
         // _GitHubLinkLabel
         // 
         this._GitHubLinkLabel.AutoSize = true;
         this._GitHubLinkLabel.Location = new System.Drawing.Point(82, 115);
         this._GitHubLinkLabel.Name = "_GitHubLinkLabel";
         this._GitHubLinkLabel.Size = new System.Drawing.Size(95, 15);
         this._GitHubLinkLabel.TabIndex = 7;
         this._GitHubLinkLabel.TabStop = true;
         this._GitHubLinkLabel.Text = "OSPA on GitHub";
         // 
         // _CloseButton
         // 
         this._CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._CloseButton.Location = new System.Drawing.Point(276, 239);
         this._CloseButton.Name = "_CloseButton";
         this._CloseButton.Size = new System.Drawing.Size(75, 23);
         this._CloseButton.TabIndex = 0;
         this._CloseButton.Text = "Close";
         this._CloseButton.UseVisualStyleBackColor = true;
         // 
         // _VersionLabel
         // 
         this._VersionLabel.AutoSize = true;
         this._VersionLabel.Location = new System.Drawing.Point(68, 76);
         this._VersionLabel.Name = "_VersionLabel";
         this._VersionLabel.Size = new System.Drawing.Size(73, 15);
         this._VersionLabel.TabIndex = 4;
         this._VersionLabel.Text = "Version X.XX";
         // 
         // _Subtitle1Label
         // 
         this._Subtitle1Label.AutoSize = true;
         this._Subtitle1Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this._Subtitle1Label.Location = new System.Drawing.Point(68, 37);
         this._Subtitle1Label.Name = "_Subtitle1Label";
         this._Subtitle1Label.Size = new System.Drawing.Size(264, 15);
         this._Subtitle1Label.TabIndex = 2;
         this._Subtitle1Label.Text = "Programming and debugging tool (PADT) for the";
         // 
         // _Subtitle2Label
         // 
         this._Subtitle2Label.AutoSize = true;
         this._Subtitle2Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this._Subtitle2Label.Location = new System.Drawing.Point(68, 52);
         this._Subtitle2Label.Name = "_Subtitle2Label";
         this._Subtitle2Label.Size = new System.Drawing.Size(166, 15);
         this._Subtitle2Label.TabIndex = 3;
         this._Subtitle2Label.Text = "Open Source PLC Architecture.";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(12, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(48, 48);
         this.pictureBox1.TabIndex = 8;
         this.pictureBox1.TabStop = false;
         // 
         // _FarmFreshLinkLabel
         // 
         this._FarmFreshLinkLabel.AutoSize = true;
         this._FarmFreshLinkLabel.Location = new System.Drawing.Point(82, 139);
         this._FarmFreshLinkLabel.Name = "_FarmFreshLinkLabel";
         this._FarmFreshLinkLabel.Size = new System.Drawing.Size(135, 15);
         this._FarmFreshLinkLabel.TabIndex = 9;
         this._FarmFreshLinkLabel.TabStop = true;
         this._FarmFreshLinkLabel.Text = "\"Farm-Fresh Web Icons\"";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(215, 139);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(20, 15);
         this.label1.TabIndex = 10;
         this.label1.Text = "by";
         // 
         // _FatCowLinkLabel
         // 
         this._FatCowLinkLabel.AutoSize = true;
         this._FatCowLinkLabel.Location = new System.Drawing.Point(232, 139);
         this._FatCowLinkLabel.Name = "_FatCowLinkLabel";
         this._FatCowLinkLabel.Size = new System.Drawing.Size(119, 15);
         this._FatCowLinkLabel.TabIndex = 11;
         this._FatCowLinkLabel.TabStop = true;
         this._FatCowLinkLabel.Text = "FatCow Web Hosting";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(82, 154);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(95, 15);
         this.label2.TabIndex = 12;
         this.label2.Text = "is licensed under";
         // 
         // _CreativeCommonsLinkLabel
         // 
         this._CreativeCommonsLinkLabel.AutoSize = true;
         this._CreativeCommonsLinkLabel.Location = new System.Drawing.Point(174, 154);
         this._CreativeCommonsLinkLabel.Name = "_CreativeCommonsLinkLabel";
         this._CreativeCommonsLinkLabel.Size = new System.Drawing.Size(58, 15);
         this._CreativeCommonsLinkLabel.TabIndex = 13;
         this._CreativeCommonsLinkLabel.TabStop = true;
         this._CreativeCommonsLinkLabel.Text = "CC BY 3.0";
         // 
         // _DockPanelLinkLabel
         // 
         this._DockPanelLinkLabel.AutoSize = true;
         this._DockPanelLinkLabel.Location = new System.Drawing.Point(82, 178);
         this._DockPanelLinkLabel.Name = "_DockPanelLinkLabel";
         this._DockPanelLinkLabel.Size = new System.Drawing.Size(92, 15);
         this._DockPanelLinkLabel.TabIndex = 17;
         this._DockPanelLinkLabel.TabStop = true;
         this._DockPanelLinkLabel.Text = "DockPanel Suite";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(171, 178);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(108, 15);
         this.label6.TabIndex = 19;
         this.label6.Text = "© 2007 Weifen Luo";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(131, 202);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(206, 15);
         this.label7.TabIndex = 22;
         this.label7.Text = "© 2012 Terence Parr and Sam Harwell";
         // 
         // _AntlrLinkLabel
         // 
         this._AntlrLinkLabel.AutoSize = true;
         this._AntlrLinkLabel.Location = new System.Drawing.Point(82, 202);
         this._AntlrLinkLabel.Name = "_AntlrLinkLabel";
         this._AntlrLinkLabel.Size = new System.Drawing.Size(53, 15);
         this._AntlrLinkLabel.TabIndex = 20;
         this._AntlrLinkLabel.TabStop = true;
         this._AntlrLinkLabel.Text = "ANTLR 4";
         // 
         // AboutForm
         // 
         this.AcceptButton = this._CloseButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._CloseButton;
         this.ClientSize = new System.Drawing.Size(363, 274);
         this.Controls.Add(this.label7);
         this.Controls.Add(label8);
         this.Controls.Add(this._AntlrLinkLabel);
         this.Controls.Add(this.label6);
         this.Controls.Add(label3);
         this.Controls.Add(this._DockPanelLinkLabel);
         this.Controls.Add(label5);
         this.Controls.Add(label4);
         this.Controls.Add(this._CreativeCommonsLinkLabel);
         this.Controls.Add(this.label2);
         this.Controls.Add(this._FatCowLinkLabel);
         this.Controls.Add(this.label1);
         this.Controls.Add(this._FarmFreshLinkLabel);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this._Subtitle2Label);
         this.Controls.Add(this._Subtitle1Label);
         this.Controls.Add(this._VersionLabel);
         this.Controls.Add(this._CloseButton);
         this.Controls.Add(this._GitHubLinkLabel);
         this.Controls.Add(this._CopyrightLabel);
         this.Controls.Add(this._TitleLabel);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "AboutForm";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "About OSPA ProgDev";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label _TitleLabel;
      private System.Windows.Forms.Label _CopyrightLabel;
      private System.Windows.Forms.LinkLabel _GitHubLinkLabel;
      private System.Windows.Forms.Button _CloseButton;
      private System.Windows.Forms.Label _VersionLabel;
      private System.Windows.Forms.Label _Subtitle1Label;
      private System.Windows.Forms.Label _Subtitle2Label;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.LinkLabel _FarmFreshLinkLabel;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.LinkLabel _FatCowLinkLabel;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.LinkLabel _CreativeCommonsLinkLabel;
      private System.Windows.Forms.LinkLabel _DockPanelLinkLabel;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.LinkLabel _AntlrLinkLabel;
   }
}