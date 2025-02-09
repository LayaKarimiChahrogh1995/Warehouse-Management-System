﻿using System;
using System.Linq;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class Unit : ListForm, IListForm<Logic.Data.Unit>
    {
        private ServiceResult<IQueryable<Logic.Data.Unit>> _data;

        public Logic.Data.Unit Selected
        {
            get
            {
                try
                {
                    int id;
                    int.TryParse(rgvList.SelectedRows[0].Cells["UnitID"].Value.ToString(), out id);
                    return _data.Result.FirstOrDefault(r => r.UnitID == id);
                }
                catch
                {
                    return null;
                }
            }
        }
        public Unit()
        {
            InitializeComponent();
            Bind();
        }

        public void Bind()
        {
            _data = MaterialService.GetUnits();
            if (_data.Status != ResultStatus.Ok)
            {
                MessageBox.Show(Resources.BindingError);
                return;
            }

            rgvList.DataSource = _data.Result
                .Where(r =>  
                    true
                )
                .Select(r => new
                {
                    r.UnitID,
                    r.Name,
                    r.Factor,
                    UnitGroupName = r.UnitGroup.Name

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
            if (new AddOrEditUnit().ShowDialog() == DialogResult.OK)
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
            if (new AddOrEditUnit(Selected).ShowDialog() == DialogResult.OK)
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
            var result = MaterialService.RemoveUnit(Selected);

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
