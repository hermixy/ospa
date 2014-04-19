namespace ProgDev.FrontEnd.Controls
{
   partial class CodeEditorControl
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
         this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
         this.SuspendLayout();
         // 
         // textEditorControl1
         // 
         this.textEditorControl1.AutoScroll = true;
         this.textEditorControl1.ConvertTabsToSpaces = true;
         this.textEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textEditorControl1.IsReadOnly = false;
         this.textEditorControl1.Location = new System.Drawing.Point(0, 0);
         this.textEditorControl1.Name = "textEditorControl1";
         this.textEditorControl1.ShowVRuler = false;
         this.textEditorControl1.Size = new System.Drawing.Size(556, 424);
         this.textEditorControl1.TabIndent = 3;
         this.textEditorControl1.TabIndex = 0;
         // 
         // CodeEditorControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.textEditorControl1);
         this.Name = "CodeEditorControl";
         this.Size = new System.Drawing.Size(556, 424);
         this.ResumeLayout(false);

      }

      #endregion

      private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
   }
}
