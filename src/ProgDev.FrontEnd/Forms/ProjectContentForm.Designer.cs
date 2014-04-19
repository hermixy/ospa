namespace ProgDev.FrontEnd.Forms
{
   partial class ProjectContentForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectContentForm));
         this._ContextMnu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.moveToFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._ListView = new ProgDev.FrontEnd.Common.BufferedListView();
         this._NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this._TypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this._LanguageCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this._ContextMnu.SuspendLayout();
         this.SuspendLayout();
         // 
         // _ContextMnu
         // 
         this._ContextMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.renameToolStripMenuItem,
            this.moveToFolderToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem});
         this._ContextMnu.Name = "_ContextMnu";
         this._ContextMnu.Size = new System.Drawing.Size(162, 126);
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
         this.openToolStripMenuItem.Text = "&Open";
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
         // 
         // renameToolStripMenuItem
         // 
         this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
         this.renameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
         this.renameToolStripMenuItem.Text = "&Rename";
         // 
         // moveToFolderToolStripMenuItem
         // 
         this.moveToFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moveToFolderToolStripMenuItem.Image")));
         this.moveToFolderToolStripMenuItem.Name = "moveToFolderToolStripMenuItem";
         this.moveToFolderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
         this.moveToFolderToolStripMenuItem.Text = "&Move to folder…";
         // 
         // duplicateToolStripMenuItem
         // 
         this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
         this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
         this.duplicateToolStripMenuItem.Text = "Du&plicate";
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
         // 
         // deleteToolStripMenuItem
         // 
         this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
         this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
         this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
         this.deleteToolStripMenuItem.Text = "&Delete";
         // 
         // _ListView
         // 
         this._ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this._ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._NameCol,
            this._TypeCol,
            this._LanguageCol});
         this._ListView.ContextMenuStrip = this._ContextMnu;
         this._ListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this._ListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this._ListView.FullRowSelect = true;
         this._ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
         this._ListView.LabelEdit = true;
         this._ListView.LabelWrap = false;
         this._ListView.Location = new System.Drawing.Point(0, 0);
         this._ListView.Name = "_ListView";
         this._ListView.Size = new System.Drawing.Size(402, 672);
         this._ListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
         this._ListView.TabIndex = 0;
         this._ListView.UseCompatibleStateImageBehavior = false;
         this._ListView.View = System.Windows.Forms.View.Details;
         // 
         // _NameCol
         // 
         this._NameCol.Text = "Name";
         this._NameCol.Width = 144;
         // 
         // _TypeCol
         // 
         this._TypeCol.Text = "Type";
         this._TypeCol.Width = 80;
         // 
         // _LanguageCol
         // 
         this._LanguageCol.Text = "Lang.";
         this._LanguageCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this._LanguageCol.Width = 50;
         // 
         // ProjectContentForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(402, 672);
         this.CloseButton = false;
         this.CloseButtonVisible = false;
         this.ControlBox = false;
         this.Controls.Add(this._ListView);
         this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "ProjectContentForm";
         this.Text = "Program Organization Units";
         this._ContextMnu.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private ProgDev.FrontEnd.Common.BufferedListView _ListView;
      private System.Windows.Forms.ColumnHeader _NameCol;
      private System.Windows.Forms.ColumnHeader _TypeCol;
      private System.Windows.Forms.ColumnHeader _LanguageCol;
      private System.Windows.Forms.ContextMenuStrip _ContextMnu;
      private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem moveToFolderToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;





   }
}