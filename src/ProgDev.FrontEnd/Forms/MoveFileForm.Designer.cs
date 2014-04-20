namespace ProgDev.FrontEnd.Forms
{
   partial class MoveFileForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveFileForm));
         this._IconBox = new System.Windows.Forms.PictureBox();
         this._CancelBtn = new System.Windows.Forms.Button();
         this._OkBtn = new System.Windows.Forms.Button();
         this._NameLbl = new System.Windows.Forms.Label();
         this._ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
         this._NewFolderCmb = new System.Windows.Forms.ComboBox();
         this._NewFolderLbl = new System.Windows.Forms.Label();
         this._PouLst = new System.Windows.Forms.ListView();
         this._NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         ((System.ComponentModel.ISupportInitialize)(this._IconBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._ErrorProvider)).BeginInit();
         this.SuspendLayout();
         // 
         // _IconBox
         // 
         this._IconBox.Image = ((System.Drawing.Image)(resources.GetObject("_IconBox.Image")));
         this._IconBox.Location = new System.Drawing.Point(12, 12);
         this._IconBox.Name = "_IconBox";
         this._IconBox.Size = new System.Drawing.Size(32, 32);
         this._IconBox.TabIndex = 14;
         this._IconBox.TabStop = false;
         // 
         // _CancelBtn
         // 
         this._CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._CancelBtn.Location = new System.Drawing.Point(248, 189);
         this._CancelBtn.Name = "_CancelBtn";
         this._CancelBtn.Size = new System.Drawing.Size(88, 26);
         this._CancelBtn.TabIndex = 4;
         this._CancelBtn.Text = "Cancel";
         this._CancelBtn.UseVisualStyleBackColor = true;
         // 
         // _OkBtn
         // 
         this._OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._OkBtn.Location = new System.Drawing.Point(154, 189);
         this._OkBtn.Name = "_OkBtn";
         this._OkBtn.Size = new System.Drawing.Size(88, 26);
         this._OkBtn.TabIndex = 3;
         this._OkBtn.Text = "Move";
         this._OkBtn.UseVisualStyleBackColor = true;
         // 
         // _NameLbl
         // 
         this._NameLbl.AutoSize = true;
         this._NameLbl.Location = new System.Drawing.Point(50, 16);
         this._NameLbl.Name = "_NameLbl";
         this._NameLbl.Size = new System.Drawing.Size(39, 15);
         this._NameLbl.TabIndex = 5;
         this._NameLbl.Text = "POUs:";
         // 
         // _ErrorProvider
         // 
         this._ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
         this._ErrorProvider.ContainerControl = this;
         this._ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("_ErrorProvider.Icon")));
         // 
         // _NewFolderCmb
         // 
         this._NewFolderCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._NewFolderCmb.FormattingEnabled = true;
         this._NewFolderCmb.Location = new System.Drawing.Point(124, 147);
         this._NewFolderCmb.Name = "_NewFolderCmb";
         this._NewFolderCmb.Size = new System.Drawing.Size(212, 23);
         this._NewFolderCmb.TabIndex = 2;
         // 
         // _NewFolderLbl
         // 
         this._NewFolderLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this._NewFolderLbl.AutoSize = true;
         this._NewFolderLbl.Location = new System.Drawing.Point(50, 150);
         this._NewFolderLbl.Name = "_NewFolderLbl";
         this._NewFolderLbl.Size = new System.Drawing.Size(68, 15);
         this._NewFolderLbl.TabIndex = 1;
         this._NewFolderLbl.Text = "New &folder:";
         // 
         // _PouLst
         // 
         this._PouLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._PouLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._NameCol});
         this._PouLst.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
         this._PouLst.Location = new System.Drawing.Point(124, 12);
         this._PouLst.MultiSelect = false;
         this._PouLst.Name = "_PouLst";
         this._PouLst.Size = new System.Drawing.Size(212, 120);
         this._PouLst.Sorting = System.Windows.Forms.SortOrder.Ascending;
         this._PouLst.TabIndex = 15;
         this._PouLst.UseCompatibleStateImageBehavior = false;
         this._PouLst.View = System.Windows.Forms.View.Details;
         // 
         // _NameCol
         // 
         this._NameCol.Text = "Name";
         this._NameCol.Width = 146;
         // 
         // MoveFileForm
         // 
         this.AcceptButton = this._OkBtn;
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._CancelBtn;
         this.ClientSize = new System.Drawing.Size(348, 227);
         this.Controls.Add(this._PouLst);
         this.Controls.Add(this._NewFolderCmb);
         this.Controls.Add(this._NewFolderLbl);
         this.Controls.Add(this._IconBox);
         this.Controls.Add(this._CancelBtn);
         this.Controls.Add(this._OkBtn);
         this.Controls.Add(this._NameLbl);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MoveFileForm";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Move Program Organization Units";
         ((System.ComponentModel.ISupportInitialize)(this._IconBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._ErrorProvider)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox _IconBox;
      private System.Windows.Forms.Button _CancelBtn;
      private System.Windows.Forms.Button _OkBtn;
      private System.Windows.Forms.Label _NameLbl;
      private System.Windows.Forms.ErrorProvider _ErrorProvider;
      private System.Windows.Forms.ComboBox _NewFolderCmb;
      private System.Windows.Forms.Label _NewFolderLbl;
      private System.Windows.Forms.ListView _PouLst;
      private System.Windows.Forms.ColumnHeader _NameCol;
   }
}