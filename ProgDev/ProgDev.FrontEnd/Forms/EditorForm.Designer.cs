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
         this._SplitContainer = new ProgDev.FrontEnd.Common.FlexSplitContainer();
         this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
         this._DesignerPanel = new System.Windows.Forms.Panel();
         ((System.ComponentModel.ISupportInitialize)(this._SplitContainer)).BeginInit();
         this._SplitContainer.Panel1.SuspendLayout();
         this._SplitContainer.Panel2.SuspendLayout();
         this._SplitContainer.SuspendLayout();
         this.SuspendLayout();
         // 
         // _SplitContainer
         // 
         this._SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this._SplitContainer.Location = new System.Drawing.Point(0, 0);
         this._SplitContainer.Name = "_SplitContainer";
         this._SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // _SplitContainer.Panel1
         // 
         this._SplitContainer.Panel1.Controls.Add(this.textEditorControl1);
         // 
         // _SplitContainer.Panel2
         // 
         this._SplitContainer.Panel2.Controls.Add(this._DesignerPanel);
         this._SplitContainer.Size = new System.Drawing.Size(629, 512);
         this._SplitContainer.SplitterDistance = 209;
         this._SplitContainer.SplitterWidth = 6;
         this._SplitContainer.TabIndex = 0;
         // 
         // textEditorControl1
         // 
         this.textEditorControl1.ConvertTabsToSpaces = true;
         this.textEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textEditorControl1.EnableFolding = false;
         this.textEditorControl1.IsReadOnly = false;
         this.textEditorControl1.Location = new System.Drawing.Point(0, 0);
         this.textEditorControl1.Name = "textEditorControl1";
         this.textEditorControl1.ShowLineNumbers = false;
         this.textEditorControl1.ShowVRuler = false;
         this.textEditorControl1.Size = new System.Drawing.Size(629, 209);
         this.textEditorControl1.TabIndent = 3;
         this.textEditorControl1.TabIndex = 0;
         this.textEditorControl1.Text = "textEditorControl1";
         // 
         // _DesignerPanel
         // 
         this._DesignerPanel.BackColor = System.Drawing.Color.White;
         this._DesignerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this._DesignerPanel.Location = new System.Drawing.Point(0, 0);
         this._DesignerPanel.Name = "_DesignerPanel";
         this._DesignerPanel.Size = new System.Drawing.Size(629, 297);
         this._DesignerPanel.TabIndex = 0;
         // 
         // EditorForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(629, 512);
         this.Controls.Add(this._SplitContainer);
         this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "EditorForm";
         this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
         this.ShowIcon = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
         this.Text = "Editor";
         this._SplitContainer.Panel1.ResumeLayout(false);
         this._SplitContainer.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this._SplitContainer)).EndInit();
         this._SplitContainer.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private ProgDev.FrontEnd.Common.FlexSplitContainer _SplitContainer;
      private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
      private System.Windows.Forms.Panel _DesignerPanel;

   }
}