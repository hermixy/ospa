namespace ProgDev.IDE.Forms
{
   partial class NewFileForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFileForm));
         this._NameLbl = new System.Windows.Forms.Label();
         this._NameTxt = new System.Windows.Forms.TextBox();
         this._OkBtn = new System.Windows.Forms.Button();
         this._CancelBtn = new System.Windows.Forms.Button();
         this._IconBox = new System.Windows.Forms.PictureBox();
         this._ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
         this._TypeLbl = new System.Windows.Forms.Label();
         this._TypeCmb = new System.Windows.Forms.ComboBox();
         this._LanguageCmb = new System.Windows.Forms.ComboBox();
         this._LanguageLbl = new System.Windows.Forms.Label();
         this._FolderCmb = new System.Windows.Forms.ComboBox();
         this._FolderLbl = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this._IconBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._ErrorProvider)).BeginInit();
         this.SuspendLayout();
         // 
         // _NameLbl
         // 
         this._NameLbl.AutoSize = true;
         this._NameLbl.Location = new System.Drawing.Point(50, 15);
         this._NameLbl.Name = "_NameLbl";
         this._NameLbl.Size = new System.Drawing.Size(42, 15);
         this._NameLbl.TabIndex = 0;
         this._NameLbl.Text = "&Name:";
         // 
         // _NameTxt
         // 
         this._NameTxt.Location = new System.Drawing.Point(118, 12);
         this._NameTxt.Name = "_NameTxt";
         this._NameTxt.Size = new System.Drawing.Size(210, 23);
         this._NameTxt.TabIndex = 1;
         // 
         // _OkBtn
         // 
         this._OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._OkBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._OkBtn.Location = new System.Drawing.Point(146, 141);
         this._OkBtn.Name = "_OkBtn";
         this._OkBtn.Size = new System.Drawing.Size(88, 26);
         this._OkBtn.TabIndex = 8;
         this._OkBtn.Text = "Create";
         this._OkBtn.UseVisualStyleBackColor = true;
         // 
         // _CancelBtn
         // 
         this._CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._CancelBtn.Location = new System.Drawing.Point(240, 141);
         this._CancelBtn.Name = "_CancelBtn";
         this._CancelBtn.Size = new System.Drawing.Size(88, 26);
         this._CancelBtn.TabIndex = 9;
         this._CancelBtn.Text = "Cancel";
         this._CancelBtn.UseVisualStyleBackColor = true;
         // 
         // _IconBox
         // 
         this._IconBox.Image = ((System.Drawing.Image)(resources.GetObject("_IconBox.Image")));
         this._IconBox.Location = new System.Drawing.Point(12, 12);
         this._IconBox.Name = "_IconBox";
         this._IconBox.Size = new System.Drawing.Size(32, 32);
         this._IconBox.TabIndex = 4;
         this._IconBox.TabStop = false;
         // 
         // _ErrorProvider
         // 
         this._ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
         this._ErrorProvider.ContainerControl = this;
         this._ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("_ErrorProvider.Icon")));
         // 
         // _TypeLbl
         // 
         this._TypeLbl.AutoSize = true;
         this._TypeLbl.Location = new System.Drawing.Point(50, 74);
         this._TypeLbl.Name = "_TypeLbl";
         this._TypeLbl.Size = new System.Drawing.Size(36, 15);
         this._TypeLbl.TabIndex = 4;
         this._TypeLbl.Text = "&Type:";
         // 
         // _TypeCmb
         // 
         this._TypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._TypeCmb.FormattingEnabled = true;
         this._TypeCmb.Location = new System.Drawing.Point(118, 70);
         this._TypeCmb.Name = "_TypeCmb";
         this._TypeCmb.Size = new System.Drawing.Size(121, 23);
         this._TypeCmb.TabIndex = 5;
         // 
         // _LanguageCmb
         // 
         this._LanguageCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._LanguageCmb.FormattingEnabled = true;
         this._LanguageCmb.Location = new System.Drawing.Point(118, 99);
         this._LanguageCmb.Name = "_LanguageCmb";
         this._LanguageCmb.Size = new System.Drawing.Size(210, 23);
         this._LanguageCmb.TabIndex = 7;
         // 
         // _LanguageLbl
         // 
         this._LanguageLbl.AutoSize = true;
         this._LanguageLbl.Location = new System.Drawing.Point(50, 103);
         this._LanguageLbl.Name = "_LanguageLbl";
         this._LanguageLbl.Size = new System.Drawing.Size(62, 15);
         this._LanguageLbl.TabIndex = 6;
         this._LanguageLbl.Text = "&Language:";
         // 
         // _FolderCmb
         // 
         this._FolderCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._FolderCmb.FormattingEnabled = true;
         this._FolderCmb.Location = new System.Drawing.Point(118, 41);
         this._FolderCmb.Name = "_FolderCmb";
         this._FolderCmb.Size = new System.Drawing.Size(210, 23);
         this._FolderCmb.TabIndex = 3;
         // 
         // _FolderLbl
         // 
         this._FolderLbl.AutoSize = true;
         this._FolderLbl.Location = new System.Drawing.Point(50, 45);
         this._FolderLbl.Name = "_FolderLbl";
         this._FolderLbl.Size = new System.Drawing.Size(43, 15);
         this._FolderLbl.TabIndex = 2;
         this._FolderLbl.Text = "&Folder:";
         // 
         // NewFileForm
         // 
         this.AcceptButton = this._OkBtn;
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._CancelBtn;
         this.ClientSize = new System.Drawing.Size(340, 179);
         this.Controls.Add(this._FolderCmb);
         this.Controls.Add(this._FolderLbl);
         this.Controls.Add(this._LanguageCmb);
         this.Controls.Add(this._LanguageLbl);
         this.Controls.Add(this._TypeCmb);
         this.Controls.Add(this._TypeLbl);
         this.Controls.Add(this._IconBox);
         this.Controls.Add(this._CancelBtn);
         this.Controls.Add(this._OkBtn);
         this.Controls.Add(this._NameTxt);
         this.Controls.Add(this._NameLbl);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "NewFileForm";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "New Program Organization Unit";
         ((System.ComponentModel.ISupportInitialize)(this._IconBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._ErrorProvider)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label _NameLbl;
      private System.Windows.Forms.TextBox _NameTxt;
      private System.Windows.Forms.Button _OkBtn;
      private System.Windows.Forms.Button _CancelBtn;
      private System.Windows.Forms.PictureBox _IconBox;
      private System.Windows.Forms.ErrorProvider _ErrorProvider;
      private System.Windows.Forms.ComboBox _TypeCmb;
      private System.Windows.Forms.Label _TypeLbl;
      private System.Windows.Forms.ComboBox _LanguageCmb;
      private System.Windows.Forms.Label _LanguageLbl;
      private System.Windows.Forms.ComboBox _FolderCmb;
      private System.Windows.Forms.Label _FolderLbl;
   }
}