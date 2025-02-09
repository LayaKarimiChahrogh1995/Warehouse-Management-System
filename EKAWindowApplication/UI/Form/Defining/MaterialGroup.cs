﻿using System;
using System.Linq;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class MaterialGroup : ListForm, IListForm<Logic.Data.MaterialGroup>
    {
        private ServiceResult<IQueryable<Logic.Data.MaterialGroup>> _data;

        public Logic.Data.MaterialGroup Selected
        {
            get
            {
                try
                {
                    int id;
                    int.TryParse(rgvList.SelectedRows[0].Cells["MaterialGroupID"].Value.ToString(), out id);
                    return _data.Result.FirstOrDefault(r => r.MaterialGroupID == id);
                }
                catch
                {
                    return null;
                }

            }
        }
        public MaterialGroup()
        {
            InitializeComponent();
            Bind();
        }

        public void Bind()
        {
            _data = MaterialService.GetMaterialGroups();
            if (_data.Status != ResultStatus.Ok)
            {
                MessageBox.Show(Resources.BindingError);
                return;
            }
            bool justExists = chkJustExists.IsChecked;
            int materialGroupId;
            int.TryParse(txtMaterialGroupID.Text, out materialGroupId);
            rgvList.DataSource = _data.Result
                .Where(r =>  
                    materialGroupId == 0 || r.MaterialGroupID == materialGroupId
                )
                .Where( r =>
                    !justExists || (justExists && ((r.MaterialExistances.Any(u => u.WareHouse.IsCountable) ? r.MaterialExistances.Where(u => u.WareHouse.IsCountable).Sum(u => u.Qty) : 0) > 0))
                )
                .Select(r => new
                {
                   r.MaterialGroupID,
                   r.Name,
                   UnitName = r.Unit.Name,
                   AvailableAmount = r.MaterialExistances.Any(u => u.WareHouse.IsCountable) ? r.MaterialExistances.Where(u => u.WareHouse.IsCountable).Sum(u => u.Qty) : 0
                }).ToList();
            rgvList.BestFitColumns();
        }

        public void Clear()
        {
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            Bind();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddOrEditMaterialGroup().ShowDialog() == DialogResult.OK)
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
            if (new AddOrEditMaterialGroup(Selected).ShowDialog() == DialogResult.OK)
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
            var result = MaterialService.RemoveMaterialGroup(Selected);

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

        private void pnlOperation_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
