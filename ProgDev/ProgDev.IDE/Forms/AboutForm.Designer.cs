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
         this._TitleLabel = new System.Windows.Forms.Label();
         this._CopyrightLabel = new System.Windows.Forms.Label();
         this._WebsiteLinkLabel = new System.Windows.Forms.LinkLabel();
         this._GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
         this._CloseButton = new System.Windows.Forms.Button();
         this._VersionLabel = new System.Windows.Forms.Label();
         this._Subtitle1Label = new System.Windows.Forms.Label();
         this._Subtitle2Label = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // _TitleLabel
         // 
         this._TitleLabel.AutoSize = true;
         this._TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this._TitleLabel.Location = new System.Drawing.Point(12, 9);
         this._TitleLabel.Name = "_TitleLabel";
         this._TitleLabel.Size = new System.Drawing.Size(155, 30);
         this._TitleLabel.TabIndex = 1;
         this._TitleLabel.Text = "OSPA ProgDev";
         // 
         // _CopyrightLabel
         // 
         this._CopyrightLabel.AutoSize = true;
         this._CopyrightLabel.Location = new System.Drawing.Point(14, 93);
         this._CopyrightLabel.Name = "_CopyrightLabel";
         this._CopyrightLabel.Size = new System.Drawing.Size(99, 15);
         this._CopyrightLabel.TabIndex = 5;
         this._CopyrightLabel.Text = "© 2014 Brian Luft";
         // 
         // _WebsiteLinkLabel
         // 
         this._WebsiteLinkLabel.AutoSize = true;
         this._WebsiteLinkLabel.Location = new System.Drawing.Point(14, 117);
         this._WebsiteLinkLabel.Name = "_WebsiteLinkLabel";
         this._WebsiteLinkLabel.Size = new System.Drawing.Size(80, 15);
         this._WebsiteLinkLabel.TabIndex = 6;
         this._WebsiteLinkLabel.TabStop = true;
         this._WebsiteLinkLabel.Text = "OSPA website";
         // 
         // _GitHubLinkLabel
         // 
         this._GitHubLinkLabel.AutoSize = true;
         this._GitHubLinkLabel.Location = new System.Drawing.Point(100, 117);
         this._GitHubLinkLabel.Name = "_GitHubLinkLabel";
         this._GitHubLinkLabel.Size = new System.Drawing.Size(95, 15);
         this._GitHubLinkLabel.TabIndex = 7;
         this._GitHubLinkLabel.TabStop = true;
         this._GitHubLinkLabel.Text = "OSPA on GitHub";
         // 
         // _CloseButton
         // 
         this._CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._CloseButton.Location = new System.Drawing.Point(173, 154);
         this._CloseButton.Name = "_CloseButton";
         this._CloseButton.Size = new System.Drawing.Size(75, 23);
         this._CloseButton.TabIndex = 0;
         this._CloseButton.Text = "Close";
         this._CloseButton.UseVisualStyleBackColor = true;
         // 
         // _VersionLabel
         // 
         this._VersionLabel.AutoSize = true;
         this._VersionLabel.Location = new System.Drawing.Point(14, 78);
         this._VersionLabel.Name = "_VersionLabel";
         this._VersionLabel.Size = new System.Drawing.Size(73, 15);
         this._VersionLabel.TabIndex = 4;
         this._VersionLabel.Text = "Version X.XX";
         // 
         // _Subtitle1Label
         // 
         this._Subtitle1Label.AutoSize = true;
         this._Subtitle1Label.Location = new System.Drawing.Point(14, 39);
         this._Subtitle1Label.Name = "_Subtitle1Label";
         this._Subtitle1Label.Size = new System.Drawing.Size(227, 15);
         this._Subtitle1Label.TabIndex = 2;
         this._Subtitle1Label.Text = "Programming and debugging tool for the";
         // 
         // _Subtitle2Label
         // 
         this._Subtitle2Label.AutoSize = true;
         this._Subtitle2Label.Location = new System.Drawing.Point(14, 54);
         this._Subtitle2Label.Name = "_Subtitle2Label";
         this._Subtitle2Label.Size = new System.Drawing.Size(170, 15);
         this._Subtitle2Label.TabIndex = 3;
         this._Subtitle2Label.Text = "Open Source PLC Architecture.";
         // 
         // AboutForm
         // 
         this.AcceptButton = this._CloseButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._CloseButton;
         this.ClientSize = new System.Drawing.Size(260, 189);
         this.Controls.Add(this._Subtitle2Label);
         this.Controls.Add(this._Subtitle1Label);
         this.Controls.Add(this._VersionLabel);
         this.Controls.Add(this._CloseButton);
         this.Controls.Add(this._GitHubLinkLabel);
         this.Controls.Add(this._WebsiteLinkLabel);
         this.Controls.Add(this._CopyrightLabel);
         this.Controls.Add(this._TitleLabel);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "AboutForm";
         this.ShowIcon = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "About OSPA ProgDev";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label _TitleLabel;
      private System.Windows.Forms.Label _CopyrightLabel;
      private System.Windows.Forms.LinkLabel _WebsiteLinkLabel;
      private System.Windows.Forms.LinkLabel _GitHubLinkLabel;
      private System.Windows.Forms.Button _CloseButton;
      private System.Windows.Forms.Label _VersionLabel;
      private System.Windows.Forms.Label _Subtitle1Label;
      private System.Windows.Forms.Label _Subtitle2Label;
   }
}