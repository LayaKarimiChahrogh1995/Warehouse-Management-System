namespace EKAWindowApplication.UI.Form.WareHouse
{
    partial class Order
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvList = new Telerik.WinControls.UI.RadGridView();
            this.breMaterialGroup = new Telerik.WinControls.UI.RadBrowseEditor();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.breWareHouse = new Telerik.WinControls.UI.RadBrowseEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).BeginInit();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlsContainer)).BeginInit();
            this.ControlsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOperation)).BeginInit();
            this.pnlOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.PanelContainer.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breMaterialGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breWareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Location = new System.Drawing.Point(0, 786);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlSelect.Size = new System.Drawing.Size(1488, 86);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(697, 22);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(562, 22);
            // 
            // ControlsContainer
            // 
            this.ControlsContainer.Padding = new System.Windows.Forms.Padding(1);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(-34, 22);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(133, 22);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(303, 22);
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlOperation
            // 
            this.pnlOperation.Size = new System.Drawing.Size(1488, 86);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(1312, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearch.Size = new System.Drawing.Size(152, 157);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            // 
            // pnlSearch.PanelContainer
            // 
            this.pnlSearch.PanelContainer.Controls.Add(this.breWareHouse);
            this.pnlSearch.PanelContainer.Controls.Add(this.radLabel2);
            this.pnlSearch.PanelContainer.Controls.Add(this.breMaterialGroup);
            this.pnlSearch.PanelContainer.Controls.Add(this.radLabel1);
            this.pnlSearch.PanelContainer.Location = new System.Drawing.Point(1, 1);
            this.pnlSearch.PanelContainer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlSearch.PanelContainer.Padding = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.pnlSearch.PanelContainer.Size = new System.Drawing.Size(1486, 207);
            this.pnlSearch.Size = new System.Drawing.Size(1488, 248);
            // 
            // rgvList
            // 
            this.rgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvList.Location = new System.Drawing.Point(0, 334);
            this.rgvList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // 
            // 
            this.rgvList.MasterTemplate.AllowAddNewRow = false;
            this.rgvList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "OrderID";
            gridViewTextBoxColumn1.HeaderText = "OrderID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "OrderID";
            gridViewTextBoxColumn1.Width = 47;
            gridViewTextBoxColumn2.FieldName = "WareHouseName";
            gridViewTextBoxColumn2.HeaderText = "WareHouseName";
            gridViewTextBoxColumn2.Name = "WareHouseName";
            gridViewTextBoxColumn2.Width = 125;
            gridViewTextBoxColumn3.FieldName = "MaterialGroupName";
            gridViewTextBoxColumn3.HeaderText = "ItemGroup";
            gridViewTextBoxColumn3.Name = "MaterialGroupName";
            gridViewTextBoxColumn3.Width = 178;
            gridViewTextBoxColumn4.FieldName = "Qty";
            gridViewTextBoxColumn4.HeaderText = "Quantity";
            gridViewTextBoxColumn4.Name = "Qty";
            gridViewTextBoxColumn4.Width = 98;
            gridViewTextBoxColumn5.FieldName = "UnitName";
            gridViewTextBoxColumn5.HeaderText = "UnitName";
            gridViewTextBoxColumn5.Name = "UnitName";
            gridViewTextBoxColumn5.Width = 84;
            gridViewTextBoxColumn6.FieldName = "ActorName";
            gridViewTextBoxColumn6.HeaderText = "RemitterName";
            gridViewTextBoxColumn6.Name = "ActorName";
            gridViewTextBoxColumn6.Width = 178;
            gridViewTextBoxColumn7.FieldName = "DateTime";
            gridViewTextBoxColumn7.HeaderText = "Date&Time";
            gridViewTextBoxColumn7.Name = "DateTime";
            gridViewTextBoxColumn7.Width = 809;
            this.rgvList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.rgvList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvList.Name = "rgvList";
            this.rgvList.ReadOnly = true;
            this.rgvList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvList.Size = new System.Drawing.Size(1488, 452);
            this.rgvList.TabIndex = 4;
            this.rgvList.Text = "radGridView1";
            // 
            // breMaterialGroup
            // 
            this.breMaterialGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.breMaterialGroup.Location = new System.Drawing.Point(77, 25);
            this.breMaterialGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.breMaterialGroup.Name = "breMaterialGroup";
            this.breMaterialGroup.Size = new System.Drawing.Size(272, 36);
            this.breMaterialGroup.TabIndex = 17;
            this.breMaterialGroup.Text = "radBrowseEditor1";
            this.breMaterialGroup.Click += new System.EventHandler(this.breMaterial_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel1.Location = new System.Drawing.Point(22, 25);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(55, 34);
            this.radLabel1.TabIndex = 13;
            this.radLabel1.Text = "Item";
            // 
            // breWareHouse
            // 
            this.breWareHouse.Dock = System.Windows.Forms.DockStyle.Left;
            this.breWareHouse.Location = new System.Drawing.Point(472, 25);
            this.breWareHouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.breWareHouse.Name = "breWareHouse";
            this.breWareHouse.Size = new System.Drawing.Size(272, 36);
            this.breWareHouse.TabIndex = 20;
            this.breWareHouse.Text = "radBrowseEditor1";
            this.breWareHouse.Click += new System.EventHandler(this.breWareHouse_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel2.Location = new System.Drawing.Point(349, 25);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(123, 34);
            this.radLabel2.TabIndex = 18;
            this.radLabel2.Text = "Warehouse";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(1488, 872);
            this.Controls.Add(this.rgvList);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Order";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Tag = "Remittance";
            this.Text = "Remittance";
            this.Controls.SetChildIndex(this.pnlOperation, 0);
            this.Controls.SetChildIndex(this.pnlSearch, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.rgvList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlsContainer)).EndInit();
            this.ControlsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOperation)).EndInit();
            this.pnlOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.pnlSearch.PanelContainer.ResumeLayout(false);
            this.pnlSearch.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breMaterialGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breWareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvList;
        private Telerik.WinControls.UI.RadBrowseEditor breWareHouse;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadBrowseEditor breMaterialGroup;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
