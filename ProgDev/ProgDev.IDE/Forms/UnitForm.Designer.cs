namespace ProgDev.IDE.Forms
{
   partial class UnitForm
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
         this._NameLbl = new System.Windows.Forms.Label();
         this._NameTxt = new System.Windows.Forms.TextBox();
         this._OkBtn = new System.Windows.Forms.Button();
         this._CancelBtn = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // _NameLbl
         // 
         this._NameLbl.AutoSize = true;
         this._NameLbl.Location = new System.Drawing.Point(12, 9);
         this._NameLbl.Name = "_NameLbl";
         this._NameLbl.Size = new System.Drawing.Size(42, 15);
         this._NameLbl.TabIndex = 0;
         this._NameLbl.Text = "&Name:";
         // 
         // _NameTxt
         // 
         this._NameTxt.Location = new System.Drawing.Point(12, 27);
         this._NameTxt.Name = "_NameTxt";
         this._NameTxt.Size = new System.Drawing.Size(256, 23);
         this._NameTxt.TabIndex = 1;
         // 
         // _OkBtn
         // 
         this._OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._OkBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._OkBtn.Location = new System.Drawing.Point(86, 70);
         this._OkBtn.Name = "_OkBtn";
         this._OkBtn.Size = new System.Drawing.Size(88, 26);
         this._OkBtn.TabIndex = 2;
         this._OkBtn.Text = "OK";
         this._OkBtn.UseVisualStyleBackColor = true;
         // 
         // _CancelBtn
         // 
         this._CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._CancelBtn.Location = new System.Drawing.Point(180, 70);
         this._CancelBtn.Name = "_CancelBtn";
         this._CancelBtn.Size = new System.Drawing.Size(88, 26);
         this._CancelBtn.TabIndex = 3;
         this._CancelBtn.Text = "Cancel";
         this._CancelBtn.UseVisualStyleBackColor = true;
         // 
         // UnitForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(280, 108);
         this.Controls.Add(this._CancelBtn);
         this.Controls.Add(this._OkBtn);
         this.Controls.Add(this._NameTxt);
         this.Controls.Add(this._NameLbl);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "UnitForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Program Organization Unit";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label _NameLbl;
      private System.Windows.Forms.TextBox _NameTxt;
      private System.Windows.Forms.Button _OkBtn;
      private System.Windows.Forms.Button _CancelBtn;
   }
}