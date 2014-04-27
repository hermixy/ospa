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
         this.components = new System.ComponentModel.Container();
         this._TextEditor = new ICSharpCode.TextEditor.TextEditorControl();
         this._UpdateTimer = new System.Windows.Forms.Timer(this.components);
         this.SuspendLayout();
         // 
         // _TextEditor
         // 
         this._TextEditor.AutoScroll = true;
         this._TextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
         this._TextEditor.IsReadOnly = false;
         this._TextEditor.Location = new System.Drawing.Point(0, 0);
         this._TextEditor.Name = "_TextEditor";
         this._TextEditor.ShowLineNumbers = false;
         this._TextEditor.ShowVRuler = false;
         this._TextEditor.Size = new System.Drawing.Size(556, 424);
         this._TextEditor.TabIndent = 3;
         this._TextEditor.TabIndex = 0;
         // 
         // _UpdateTimer
         // 
         this._UpdateTimer.Interval = 500;
         // 
         // CodeEditorControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this._TextEditor);
         this.Name = "CodeEditorControl";
         this.Size = new System.Drawing.Size(556, 424);
         this.ResumeLayout(false);

      }

      #endregion

      private ICSharpCode.TextEditor.TextEditorControl _TextEditor;
      private System.Windows.Forms.Timer _UpdateTimer;
   }
}
