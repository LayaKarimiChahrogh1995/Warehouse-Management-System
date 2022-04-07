namespace EKAWindowApplication.UI.Form.Defining
{
    partial class AddOrEditMaterialGroup
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.breUnit = new Telerik.WinControls.UI.RadBrowseEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).BeginInit();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Location = new System.Drawing.Point(0, 120);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlSelect.Size = new System.Drawing.Size(583, 86);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(151, 20);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(14, 20);
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(40, 22);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radLabel1.Size = new System.Drawing.Size(124, 34);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Item Group";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(235, 19);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 35);
            this.txtName.TabIndex = 6;
            // 
            // breUnit
            // 
            this.breUnit.Location = new System.Drawing.Point(235, 66);
            this.breUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.breUnit.Name = "breUnit";
            this.breUnit.Size = new System.Drawing.Size(272, 36);
            this.breUnit.TabIndex = 7;
            this.breUnit.Text = "radBrowseEditor1";
            this.breUnit.Click += new System.EventHandler(this.breUnit_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(40, 69);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radLabel2.Size = new System.Drawing.Size(181, 34);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Unit of  Measure:";
            // 
            // AddOrEditMaterialGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 206);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.breUnit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radLabel1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "AddOrEditMaterialGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Tag = "Add/Edit Item Groups";
            this.Text = "Add/Edit Item Groups";
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.breUnit, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadBrowseEditor breUnit;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
