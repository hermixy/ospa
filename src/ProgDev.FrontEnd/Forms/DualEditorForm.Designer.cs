namespace ProgDev.FrontEnd.Forms
{
   partial class DualEditorForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DualEditorForm));
         this._SplitContainer = new ProgDev.FrontEnd.Common.FlexSplitContainer();
         this._CodePanel = new System.Windows.Forms.Panel();
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
         this._SplitContainer.Panel1.Controls.Add(this._CodePanel);
         // 
         // _SplitContainer.Panel2
         // 
         this._SplitContainer.Panel2.Controls.Add(this._DesignerPanel);
         this._SplitContainer.Size = new System.Drawing.Size(629, 512);
         this._SplitContainer.SplitterDistance = 209;
         this._SplitContainer.SplitterWidth = 6;
         this._SplitContainer.TabIndex = 0;
         // 
         // _CodePanel
         // 
         this._CodePanel.BackColor = System.Drawing.Color.White;
         this._CodePanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this._CodePanel.Location = new System.Drawing.Point(0, 0);
         this._CodePanel.Name = "_CodePanel";
         this._CodePanel.Size = new System.Drawing.Size(629, 209);
         this._CodePanel.TabIndex = 0;
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
         // DualEditorForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(629, 512);
         this.Controls.Add(this._SplitContainer);
         this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "DualEditorForm";
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
      private System.Windows.Forms.Panel _DesignerPanel;
      private System.Windows.Forms.Panel _CodePanel;

   }
}