namespace ProgDev.FrontEnd.Forms
{
   partial class NewProjectForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectForm));
         this._IconBox = new System.Windows.Forms.PictureBox();
         this._CancelBtn = new System.Windows.Forms.Button();
         this._OkBtn = new System.Windows.Forms.Button();
         this._NameTxt = new System.Windows.Forms.TextBox();
         this._NameLbl = new System.Windows.Forms.Label();
         this._ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
         this._CancelBtn.Location = new System.Drawing.Point(220, 56);
         this._CancelBtn.Name = "_CancelBtn";
         this._CancelBtn.Size = new System.Drawing.Size(88, 26);
         this._CancelBtn.TabIndex = 20;
         this._CancelBtn.Text = "Cancel";
         this._CancelBtn.UseVisualStyleBackColor = true;
         // 
         // _OkBtn
         // 
         this._OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._OkBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._OkBtn.Location = new System.Drawing.Point(126, 56);
         this._OkBtn.Name = "_OkBtn";
         this._OkBtn.Size = new System.Drawing.Size(88, 26);
         this._OkBtn.TabIndex = 19;
         this._OkBtn.Text = "Create";
         this._OkBtn.UseVisualStyleBackColor = true;
         // 
         // _NameTxt
         // 
         this._NameTxt.Location = new System.Drawing.Point(98, 12);
         this._NameTxt.Name = "_NameTxt";
         this._NameTxt.Size = new System.Drawing.Size(210, 23);
         this._NameTxt.TabIndex = 11;
         // 
         // _NameLbl
         // 
         this._NameLbl.AutoSize = true;
         this._NameLbl.Location = new System.Drawing.Point(50, 15);
         this._NameLbl.Name = "_NameLbl";
         this._NameLbl.Size = new System.Drawing.Size(42, 15);
         this._NameLbl.TabIndex = 10;
         this._NameLbl.Text = "&Name:";
         // 
         // _ErrorProvider
         // 
         this._ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
         this._ErrorProvider.ContainerControl = this;
         this._ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("_ErrorProvider.Icon")));
         // 
         // NewProjectForm
         // 
         this.AcceptButton = this._OkBtn;
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._CancelBtn;
         this.ClientSize = new System.Drawing.Size(320, 94);
         this.Controls.Add(this._IconBox);
         this.Controls.Add(this._CancelBtn);
         this.Controls.Add(this._OkBtn);
         this.Controls.Add(this._NameTxt);
         this.Controls.Add(this._NameLbl);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "NewProjectForm";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "New Project";
         ((System.ComponentModel.ISupportInitialize)(this._IconBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._ErrorProvider)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox _IconBox;
      private System.Windows.Forms.Button _CancelBtn;
      private System.Windows.Forms.Button _OkBtn;
      private System.Windows.Forms.TextBox _NameTxt;
      private System.Windows.Forms.Label _NameLbl;
      private System.Windows.Forms.ErrorProvider _ErrorProvider;
   }
}