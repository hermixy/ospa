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
         this._ListView = new ProgDev.FrontEnd.Common.BufferedListView();
         this._NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this._TypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this._LanguageCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.SuspendLayout();
         // 
         // _ListView
         // 
         this._ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this._ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._NameCol,
            this._TypeCol,
            this._LanguageCol});
         this._ListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this._ListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this._ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
         this._ListView.LabelEdit = true;
         this._ListView.LabelWrap = false;
         this._ListView.Location = new System.Drawing.Point(0, 0);
         this._ListView.Name = "_ListView";
         this._ListView.Size = new System.Drawing.Size(402, 672);
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
         this.ResumeLayout(false);

      }

      #endregion

      private ProgDev.FrontEnd.Common.BufferedListView _ListView;
      private System.Windows.Forms.ColumnHeader _NameCol;
      private System.Windows.Forms.ColumnHeader _TypeCol;
      private System.Windows.Forms.ColumnHeader _LanguageCol;





   }
}