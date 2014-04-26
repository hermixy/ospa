namespace ProgDev.FrontEnd.Controls
{
   partial class SplitEditorControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this._SplitContainer = new ProgDev.FrontEnd.Common.Toolkit.FlexSplitContainer();
         ((System.ComponentModel.ISupportInitialize)(this._SplitContainer)).BeginInit();
         this._SplitContainer.SuspendLayout();
         this.SuspendLayout();
         // 
         // _SplitContainer
         // 
         this._SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this._SplitContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this._SplitContainer.Location = new System.Drawing.Point(0, 0);
         this._SplitContainer.Name = "_SplitContainer";
         this._SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
         this._SplitContainer.Size = new System.Drawing.Size(687, 480);
         this._SplitContainer.SplitterDistance = 229;
         this._SplitContainer.TabIndex = 0;
         // 
         // DualDocumentControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this._SplitContainer);
         this.Name = "DualDocumentControl";
         this.Size = new System.Drawing.Size(687, 480);
         ((System.ComponentModel.ISupportInitialize)(this._SplitContainer)).EndInit();
         this._SplitContainer.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private Common.Toolkit.FlexSplitContainer _SplitContainer;
   }
}
