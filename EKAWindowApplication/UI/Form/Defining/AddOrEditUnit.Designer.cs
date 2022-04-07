namespace EKAWindowApplication.UI.Form.Defining
{
    partial class AddOrEditUnit
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
            this.breUnitGroup = new Telerik.WinControls.UI.RadBrowseEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtFactor = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).BeginInit();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breUnitGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Location = new System.Drawing.Point(0, 194);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlSelect.Size = new System.Drawing.Size(582, 86);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 20);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(18, 20);
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(28, 48);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radLabel1.Size = new System.Drawing.Size(122, 34);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Unit Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(157, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(272, 35);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "  ";
            // 
            // breUnitGroup
            // 
            this.breUnitGroup.Location = new System.Drawing.Point(156, 92);
            this.breUnitGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.breUnitGroup.Name = "breUnitGroup";
            this.breUnitGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.breUnitGroup.Size = new System.Drawing.Size(272, 36);
            this.breUnitGroup.TabIndex = 7;
            this.breUnitGroup.Text = "radBrowseEditor1";
            this.breUnitGroup.Click += new System.EventHandler(this.breUnitGroup_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(24, 95);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(125, 34);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Unit Group:";
            // 
            // txtFactor
            // 
            this.txtFactor.Location = new System.Drawing.Point(153, 141);
            this.txtFactor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.NullText = "1";
            this.txtFactor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFactor.Size = new System.Drawing.Size(272, 35);
            this.txtFactor.TabIndex = 8;
            this.txtFactor.Text = "1";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(27, 144);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(76, 34);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "Factor:";
            // 
            // AddOrEditUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 280);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txtFactor);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.breUnitGroup);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radLabel1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "AddOrEditUnit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Tag = "Add/Edit Unit";
            this.Text = "Add/Edit Unit";
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.breUnitGroup, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.txtFactor, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breUnitGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadBrowseEditor breUnitGroup;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtFactor;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
