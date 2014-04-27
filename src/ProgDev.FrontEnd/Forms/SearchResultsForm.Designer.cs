namespace ProgDev.FrontEnd.Forms
{
   partial class SearchResultsForm
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
         this._ResultsLst = new System.Windows.Forms.ListView();
         this._SearchLbl = new System.Windows.Forms.Label();
         this._SearchTxt = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // _ResultsLst
         // 
         this._ResultsLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._ResultsLst.Location = new System.Drawing.Point(-1, 22);
         this._ResultsLst.Name = "_ResultsLst";
         this._ResultsLst.Size = new System.Drawing.Size(450, 639);
         this._ResultsLst.TabIndex = 0;
         this._ResultsLst.UseCompatibleStateImageBehavior = false;
         // 
         // _SearchLbl
         // 
         this._SearchLbl.AutoSize = true;
         this._SearchLbl.Location = new System.Drawing.Point(3, 4);
         this._SearchLbl.Name = "_SearchLbl";
         this._SearchLbl.Size = new System.Drawing.Size(65, 15);
         this._SearchLbl.TabIndex = 1;
         this._SearchLbl.Text = "Results for:";
         // 
         // _SearchTxt
         // 
         this._SearchTxt.AutoSize = true;
         this._SearchTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this._SearchTxt.Location = new System.Drawing.Point(66, 4);
         this._SearchTxt.Name = "_SearchTxt";
         this._SearchTxt.Size = new System.Drawing.Size(43, 15);
         this._SearchTxt.TabIndex = 2;
         this._SearchTxt.Text = "(none)";
         // 
         // SearchResultsForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(448, 660);
         this.CloseButton = false;
         this.CloseButtonVisible = false;
         this.ControlBox = false;
         this.Controls.Add(this._SearchTxt);
         this.Controls.Add(this._SearchLbl);
         this.Controls.Add(this._ResultsLst);
         this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "SearchResultsForm";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.Text = "Search Results";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListView _ResultsLst;
      private System.Windows.Forms.Label _SearchLbl;
      private System.Windows.Forms.Label _SearchTxt;

   }
}