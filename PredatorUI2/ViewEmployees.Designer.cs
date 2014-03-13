namespace PredatorUI2
{
    partial class ViewEmployees
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
            this.viewEmployeesDG = new System.Windows.Forms.DataGridView();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployeesDG)).BeginInit();
            this.SuspendLayout();
            // 
            // viewEmployeesDG
            // 
            this.viewEmployeesDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewEmployeesDG.Location = new System.Drawing.Point(47, 69);
            this.viewEmployeesDG.Name = "viewEmployeesDG";
            this.viewEmployeesDG.Size = new System.Drawing.Size(889, 537);
            this.viewEmployeesDG.TabIndex = 0;
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(121, 40);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(321, 20);
            this.searchTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SEARCH";
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.viewEmployeesDG);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployeesDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewEmployeesDG;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label1;
    }
}