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
         this._OpenMnu = new System.Windows.Forms.ToolStripMenuItem();
         this._Separator1 = new System.Windows.Forms.ToolStripSeparator();
         this._MoveMnu = new System.Windows.Forms.ToolStripMenuItem();
         this._DuplicateMnu = new System.Windows.Forms.ToolStripMenuItem();
         this._RenameMnu = new System.Windows.Forms.ToolStripMenuItem();
         this._Separator2 = new System.Windows.Forms.ToolStripSeparator();
         this._DeleteMnu = new System.Windows.Forms.ToolStripMenuItem();
         this._ListView = new ProgDev.FrontEnd.Common.Toolkit.BufferedListView();
         this._NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this._TypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this._ContextMnu.SuspendLayout();
         this.SuspendLayout();
         // 
         // _ContextMnu
         // 
         this._ContextMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._OpenMnu,
            this._Separator1,
            this._MoveMnu,
            this._DuplicateMnu,
            this._RenameMnu,
            this._Separator2,
            this._DeleteMnu});
         this._ContextMnu.Name = "_ContextMnu";
         this._ContextMnu.Size = new System.Drawing.Size(162, 126);
         // 
         // _OpenMnu
         // 
         this._OpenMnu.Name = "_OpenMnu";
         this._OpenMnu.ShortcutKeyDisplayString = "Enter";
         this._OpenMnu.Size = new System.Drawing.Size(161, 22);
         this._OpenMnu.Text = "&Open";
         // 
         // _Separator1
         // 
         this._Separator1.Name = "_Separator1";
         this._Separator1.Size = new System.Drawing.Size(158, 6);
         // 
         // _MoveMnu
         // 
         this._MoveMnu.Image = ((System.Drawing.Image)(resources.GetObject("_MoveMnu.Image")));
         this._MoveMnu.Name = "_MoveMnu";
         this._MoveMnu.Size = new System.Drawing.Size(161, 22);
         this._MoveMnu.Text = "&Move to folder…";
         // 
         // _DuplicateMnu
         // 
         this._DuplicateMnu.Name = "_DuplicateMnu";
         this._DuplicateMnu.Size = new System.Drawing.Size(161, 22);
         this._DuplicateMnu.Text = "Du&plicate";
         // 
         // _RenameMnu
         // 
         this._RenameMnu.Image = ((System.Drawing.Image)(resources.GetObject("_RenameMnu.Image")));
         this._RenameMnu.Name = "_RenameMnu";
         this._RenameMnu.ShortcutKeys = System.Windows.Forms.Keys.F2;
         this._RenameMnu.Size = new System.Drawing.Size(161, 22);
         this._RenameMnu.Text = "&Rename…";
         // 
         // _Separator2
         // 
         this._Separator2.Name = "_Separator2";
         this._Separator2.Size = new System.Drawing.Size(158, 6);
         // 
         // _DeleteMnu
         // 
         this._DeleteMnu.Image = ((System.Drawing.Image)(resources.GetObject("_DeleteMnu.Image")));
         this._DeleteMnu.Name = "_DeleteMnu";
         this._DeleteMnu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
         this._DeleteMnu.Size = new System.Drawing.Size(161, 22);
         this._DeleteMnu.Text = "&Delete";
         // 
         // _ListView
         // 
         this._ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this._ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._NameCol,
            this._TypeCol});
         this._ListView.ContextMenuStrip = this._ContextMnu;
         this._ListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this._ListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this._ListView.FullRowSelect = true;
         this._ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
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

      private ProgDev.FrontEnd.Common.Toolkit.BufferedListView _ListView;
      private System.Windows.Forms.ColumnHeader _NameCol;
      private System.Windows.Forms.ColumnHeader _TypeCol;
      private System.Windows.Forms.ContextMenuStrip _ContextMnu;
      private System.Windows.Forms.ToolStripMenuItem _DeleteMnu;
      private System.Windows.Forms.ToolStripMenuItem _RenameMnu;
      private System.Windows.Forms.ToolStripMenuItem _MoveMnu;
      private System.Windows.Forms.ToolStripMenuItem _DuplicateMnu;
      private System.Windows.Forms.ToolStripSeparator _Separator2;
      private System.Windows.Forms.ToolStripMenuItem _OpenMnu;
      private System.Windows.Forms.ToolStripSeparator _Separator1;





   }
}