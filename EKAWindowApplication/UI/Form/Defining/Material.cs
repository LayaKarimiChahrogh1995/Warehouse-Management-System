﻿using System;
using System.Linq;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class Material : ListForm, IListForm<Logic.Data.Material>
    {
        private ServiceResult<IQueryable<Logic.Data.Material>> _data;
        public Logic.Data.Material Selected
        {
            get
            {
                try
                {
                    int id;
                    int.TryParse(rgvList.SelectedRows[0].Cells["MaterialID"].Value.ToString(), out id);
                    return _data.Result.FirstOrDefault(r => r.MaterialID == id);
                }
                catch
                {
                    return null;
                }

            }
        }
        public Material()
        {
            InitializeComponent();
            Bind();
        }

        public void Bind()
        {
            _data = MaterialService.GetMaterials();
            if (_data.Status != ResultStatus.Ok)
            {
                MessageBox.Show(Resources.BindingError);
                return;
            }

            int materialId;
            int.TryParse(txtMaterialID.Text,out materialId);

            var materialGroup = (Logic.Data.MaterialGroup) breMaterialGroup.Tag;
            var materialGroupId = 0;
            if (materialGroup != null)  materialGroupId =  materialGroup.MaterialGroupID;

            rgvList.DataSource = _data.Result
                .Where(r =>  
                    materialId == 0 || r.MaterialID == materialId
                )
                .Where(r =>
                    materialGroupId == 0 || (materialGroupId != 0 && r.MaterialGroup.MaterialGroupID == materialGroupId)
                )
                .Select(r => new
                {
                    r.MaterialID,
                    GroupName = r.MaterialGroup.Name,
                    r.Qty,
                    Unit = r.MaterialGroup.Unit.Name,
                    WareHouseName = r.Orders.OrderByDescending(u => u.DateTime).ThenBy(u => u.OrderID).Select(u => u.WareHouse.Name).FirstOrDefault() ?? ""

                }).OrderByDescending(u => u.MaterialID).ToList();
            rgvList.BestFitColumns();
        }

        public void Clear()
        {
            
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddOrEditMaterial().ShowDialog() == DialogResult.OK)
            {
                Bind();
            }
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            if (Selected == null)
            {
                MessageBox.Show(Resources.NoRowSelected);
                return;
            }
            if (new AddOrEditMaterial(Selected).ShowDialog() == DialogResult.OK)
            {
                Bind();
            }
        }

        public void btnRemove_Click(object sender, EventArgs e)
        {
            if (Selected == null)
            {
                MessageBox.Show(Resources.NoRowSelected);
                return;
            }
            var result = MaterialService.RemoveMaterial(Selected);

            switch (result.Status)
            {
                case ResultStatus.Ok:
                    MessageBox.Show(Resources.SuccessfulOperation);
                    Bind();
                    break;
                case ResultStatus.AccessFail:
                    MessageBox.Show(Resources.AccessFail);
                    break;
                default:
                    MessageBox.Show(Resources.UnknownError);
                    break;
            }
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            Bind();
        }

        private void breMaterialGroup_Click(object sender, EventArgs e)
        {
            var form = new MaterialGroup() { SelectMode = true };
            if (form.ShowDialog() == DialogResult.OK)
            {
                breMaterialGroup.Tag = form.Selected;
                breMaterialGroup.Value = form.Selected?.Name;
            }
        }
    }
}
