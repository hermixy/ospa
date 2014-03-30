namespace ProgDev.IDE.Forms
{
   partial class ProgramExplorerForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramExplorerForm));
         this._ToolStripContainer = new System.Windows.Forms.ToolStripContainer();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.treeView1 = new System.Windows.Forms.TreeView();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
         this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
         this._ToolStripContainer.BottomToolStripPanel.SuspendLayout();
         this._ToolStripContainer.ContentPanel.SuspendLayout();
         this._ToolStripContainer.TopToolStripPanel.SuspendLayout();
         this._ToolStripContainer.SuspendLayout();
         this.toolStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // _ToolStripContainer
         // 
         // 
         // _ToolStripContainer.BottomToolStripPanel
         // 
         this._ToolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip1);
         // 
         // _ToolStripContainer.ContentPanel
         // 
         this._ToolStripContainer.ContentPanel.Controls.Add(this.treeView1);
         this._ToolStripContainer.ContentPanel.Size = new System.Drawing.Size(393, 586);
         this._ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this._ToolStripContainer.Location = new System.Drawing.Point(0, 0);
         this._ToolStripContainer.Name = "_ToolStripContainer";
         this._ToolStripContainer.Size = new System.Drawing.Size(393, 633);
         this._ToolStripContainer.TabIndex = 0;
         this._ToolStripContainer.Text = "toolStripContainer1";
         // 
         // _ToolStripContainer.TopToolStripPanel
         // 
         this._ToolStripContainer.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
         this._ToolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
         // 
         // statusStrip1
         // 
         this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
         this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
         this.statusStrip1.Location = new System.Drawing.Point(0, 0);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(393, 22);
         this.statusStrip1.SizingGrip = false;
         this.statusStrip1.TabIndex = 0;
         // 
         // treeView1
         // 
         this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.treeView1.Location = new System.Drawing.Point(0, 0);
         this.treeView1.Name = "treeView1";
         this.treeView1.Size = new System.Drawing.Size(393, 586);
         this.treeView1.TabIndex = 0;
         // 
         // toolStrip1
         // 
         this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
         this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
         this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(393, 25);
         this.toolStrip1.Stretch = true;
         this.toolStrip1.TabIndex = 0;
         // 
         // toolStripButton1
         // 
         this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
         this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton1.Name = "toolStripButton1";
         this.toolStripButton1.Size = new System.Drawing.Size(72, 22);
         this.toolStripButton1.Text = "Compile";
         // 
         // toolStripButton2
         // 
         this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
         this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton2.Name = "toolStripButton2";
         this.toolStripButton2.Size = new System.Drawing.Size(58, 22);
         this.toolStripButton2.Text = "Add...";
         // 
         // ProgramExplorerForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(393, 633);
         this.Controls.Add(this._ToolStripContainer);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "ProgramExplorerForm";
         this.Text = "Program Explorer";
         this._ToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
         this._ToolStripContainer.BottomToolStripPanel.PerformLayout();
         this._ToolStripContainer.ContentPanel.ResumeLayout(false);
         this._ToolStripContainer.TopToolStripPanel.ResumeLayout(false);
         this._ToolStripContainer.TopToolStripPanel.PerformLayout();
         this._ToolStripContainer.ResumeLayout(false);
         this._ToolStripContainer.PerformLayout();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ToolStripContainer _ToolStripContainer;
      private System.Windows.Forms.TreeView treeView1;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton toolStripButton1;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripButton toolStripButton2;

   }
}