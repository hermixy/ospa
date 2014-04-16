namespace ProgDev.FrontEnd.Forms
{
   partial class EditorForm
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
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.textEditorControl1);
         this.splitContainer1.Size = new System.Drawing.Size(629, 512);
         this.splitContainer1.SplitterDistance = 209;
         this.splitContainer1.TabIndex = 0;
         // 
         // textEditorControl1
         // 
         this.textEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textEditorControl1.IsReadOnly = false;
         this.textEditorControl1.Location = new System.Drawing.Point(0, 0);
         this.textEditorControl1.Name = "textEditorControl1";
         this.textEditorControl1.Size = new System.Drawing.Size(629, 209);
         this.textEditorControl1.TabIndex = 0;
         this.textEditorControl1.Text = "textEditorControl1";
         // 
         // EditorForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Window;
         this.ClientSize = new System.Drawing.Size(629, 512);
         this.Controls.Add(this.splitContainer1);
         this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "EditorForm";
         this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
         this.ShowIcon = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
         this.Text = "Editor";
         this.splitContainer1.Panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;

   }
}