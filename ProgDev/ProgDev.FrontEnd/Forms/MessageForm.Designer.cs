namespace ProgDev.FrontEnd.Forms
{
   partial class MessageForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
         this._IconBox = new System.Windows.Forms.PictureBox();
         this._MessageTxt = new System.Windows.Forms.TextBox();
         this._DetailTxt = new System.Windows.Forms.TextBox();
         this._Btn2 = new System.Windows.Forms.Button();
         this._Btn1 = new System.Windows.Forms.Button();
         this._Btn3 = new System.Windows.Forms.Button();
         this._ButtonPanel = new System.Windows.Forms.Panel();
         ((System.ComponentModel.ISupportInitialize)(this._IconBox)).BeginInit();
         this._ButtonPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // _IconBox
         // 
         this._IconBox.Image = ((System.Drawing.Image)(resources.GetObject("_IconBox.Image")));
         this._IconBox.Location = new System.Drawing.Point(12, 12);
         this._IconBox.Name = "_IconBox";
         this._IconBox.Size = new System.Drawing.Size(32, 32);
         this._IconBox.TabIndex = 0;
         this._IconBox.TabStop = false;
         // 
         // _MessageTxt
         // 
         this._MessageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._MessageTxt.BackColor = System.Drawing.Color.White;
         this._MessageTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this._MessageTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
         this._MessageTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this._MessageTxt.ForeColor = System.Drawing.Color.DarkBlue;
         this._MessageTxt.Location = new System.Drawing.Point(50, 12);
         this._MessageTxt.Multiline = true;
         this._MessageTxt.Name = "_MessageTxt";
         this._MessageTxt.ReadOnly = true;
         this._MessageTxt.Size = new System.Drawing.Size(353, 45);
         this._MessageTxt.TabIndex = 1;
         this._MessageTxt.TabStop = false;
         this._MessageTxt.Text = "Message Message Message Message Message Message Message Message Message Message M" +
    "essage Message Message Message Message ";
         // 
         // _DetailTxt
         // 
         this._DetailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._DetailTxt.BackColor = System.Drawing.Color.White;
         this._DetailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this._DetailTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
         this._DetailTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this._DetailTxt.Location = new System.Drawing.Point(50, 63);
         this._DetailTxt.Multiline = true;
         this._DetailTxt.Name = "_DetailTxt";
         this._DetailTxt.ReadOnly = true;
         this._DetailTxt.Size = new System.Drawing.Size(353, 35);
         this._DetailTxt.TabIndex = 2;
         this._DetailTxt.TabStop = false;
         this._DetailTxt.Text = resources.GetString("_DetailTxt.Text");
         // 
         // _Btn2
         // 
         this._Btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._Btn2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._Btn2.Location = new System.Drawing.Point(221, 11);
         this._Btn2.Name = "_Btn2";
         this._Btn2.Size = new System.Drawing.Size(88, 26);
         this._Btn2.TabIndex = 11;
         this._Btn2.Text = "2";
         this._Btn2.UseVisualStyleBackColor = true;
         // 
         // _Btn1
         // 
         this._Btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._Btn1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._Btn1.Location = new System.Drawing.Point(127, 11);
         this._Btn1.Name = "_Btn1";
         this._Btn1.Size = new System.Drawing.Size(88, 26);
         this._Btn1.TabIndex = 10;
         this._Btn1.Text = "1";
         this._Btn1.UseVisualStyleBackColor = true;
         // 
         // _Btn3
         // 
         this._Btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._Btn3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._Btn3.Location = new System.Drawing.Point(315, 11);
         this._Btn3.Name = "_Btn3";
         this._Btn3.Size = new System.Drawing.Size(88, 26);
         this._Btn3.TabIndex = 12;
         this._Btn3.Text = "3";
         this._Btn3.UseVisualStyleBackColor = true;
         // 
         // _ButtonPanel
         // 
         this._ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._ButtonPanel.BackColor = System.Drawing.SystemColors.Control;
         this._ButtonPanel.Controls.Add(this._Btn3);
         this._ButtonPanel.Controls.Add(this._Btn1);
         this._ButtonPanel.Controls.Add(this._Btn2);
         this._ButtonPanel.Location = new System.Drawing.Point(0, 102);
         this._ButtonPanel.Name = "_ButtonPanel";
         this._ButtonPanel.Size = new System.Drawing.Size(415, 49);
         this._ButtonPanel.TabIndex = 13;
         // 
         // MessageForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(415, 151);
         this.Controls.Add(this._DetailTxt);
         this.Controls.Add(this._MessageTxt);
         this.Controls.Add(this._IconBox);
         this.Controls.Add(this._ButtonPanel);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MessageForm";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Title";
         ((System.ComponentModel.ISupportInitialize)(this._IconBox)).EndInit();
         this._ButtonPanel.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox _IconBox;
      private System.Windows.Forms.TextBox _MessageTxt;
      private System.Windows.Forms.TextBox _DetailTxt;
      private System.Windows.Forms.Button _Btn2;
      private System.Windows.Forms.Button _Btn1;
      private System.Windows.Forms.Button _Btn3;
      private System.Windows.Forms.Panel _ButtonPanel;
   }
}