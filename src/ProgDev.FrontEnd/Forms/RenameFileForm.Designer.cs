namespace ProgDev.FrontEnd.Forms
{
   partial class RenameFileForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameFileForm));
         this._IconBox = new System.Windows.Forms.PictureBox();
         this._CancelBtn = new System.Windows.Forms.Button();
         this._OkBtn = new System.Windows.Forms.Button();
         this._OldNameTxt = new System.Windows.Forms.TextBox();
         this._OldNameLbl = new System.Windows.Forms.Label();
         this._ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
         this._NewNameTxt = new System.Windows.Forms.TextBox();
         this._NewNameLbl = new System.Windows.Forms.Label();
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
         this._CancelBtn.Location = new System.Drawing.Point(246, 84);
         this._CancelBtn.Name = "_CancelBtn";
         this._CancelBtn.Size = new System.Drawing.Size(88, 26);
         this._CancelBtn.TabIndex = 4;
         this._CancelBtn.Text = "Cancel";
         this._CancelBtn.UseVisualStyleBackColor = true;
         // 
         // _OkBtn
         // 
         this._OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._OkBtn.Location = new System.Drawing.Point(152, 84);
         this._OkBtn.Name = "_OkBtn";
         this._OkBtn.Size = new System.Drawing.Size(88, 26);
         this._OkBtn.TabIndex = 3;
         this._OkBtn.Text = "Rename";
         this._OkBtn.UseVisualStyleBackColor = true;
         // 
         // _OldNameTxt
         // 
         this._OldNameTxt.Location = new System.Drawing.Point(123, 13);
         this._OldNameTxt.Name = "_OldNameTxt";
         this._OldNameTxt.ReadOnly = true;
         this._OldNameTxt.Size = new System.Drawing.Size(211, 23);
         this._OldNameTxt.TabIndex = 6;
         // 
         // _OldNameLbl
         // 
         this._OldNameLbl.AutoSize = true;
         this._OldNameLbl.Location = new System.Drawing.Point(50, 16);
         this._OldNameLbl.Name = "_OldNameLbl";
         this._OldNameLbl.Size = new System.Drawing.Size(62, 15);
         this._OldNameLbl.TabIndex = 5;
         this._OldNameLbl.Text = "Old name:";
         // 
         // _ErrorProvider
         // 
         this._ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
         this._ErrorProvider.ContainerControl = this;
         this._ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("_ErrorProvider.Icon")));
         // 
         // _NewNameTxt
         // 
         this._NewNameTxt.Location = new System.Drawing.Point(123, 42);
         this._NewNameTxt.Name = "_NewNameTxt";
         this._NewNameTxt.Size = new System.Drawing.Size(211, 23);
         this._NewNameTxt.TabIndex = 2;
         // 
         // _NewNameLbl
         // 
         this._NewNameLbl.AutoSize = true;
         this._NewNameLbl.Location = new System.Drawing.Point(50, 45);
         this._NewNameLbl.Name = "_NewNameLbl";
         this._NewNameLbl.Size = new System.Drawing.Size(67, 15);
         this._NewNameLbl.TabIndex = 1;
         this._NewNameLbl.Text = "&New name:";
         // 
         // RenameFileForm
         // 
         this.AcceptButton = this._OkBtn;
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._CancelBtn;
         this.ClientSize = new System.Drawing.Size(346, 122);
         this.Controls.Add(this._NewNameTxt);
         this.Controls.Add(this._NewNameLbl);
         this.Controls.Add(this._IconBox);
         this.Controls.Add(this._CancelBtn);
         this.Controls.Add(this._OkBtn);
         this.Controls.Add(this._OldNameTxt);
         this.Controls.Add(this._OldNameLbl);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "RenameFileForm";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Rename Program Organization Unit";
         ((System.ComponentModel.ISupportInitialize)(this._IconBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._ErrorProvider)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox _IconBox;
      private System.Windows.Forms.Button _CancelBtn;
      private System.Windows.Forms.Button _OkBtn;
      private System.Windows.Forms.TextBox _OldNameTxt;
      private System.Windows.Forms.Label _OldNameLbl;
      private System.Windows.Forms.ErrorProvider _ErrorProvider;
      private System.Windows.Forms.TextBox _NewNameTxt;
      private System.Windows.Forms.Label _NewNameLbl;
   }
}