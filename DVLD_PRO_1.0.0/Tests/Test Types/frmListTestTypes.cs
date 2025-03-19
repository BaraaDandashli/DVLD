using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PRO_1._0._0.Tests.Test_Types
{
    public partial class frmListTestsTypes : Form
    {
        private DataTable _dtAllTestTypes;
        public frmListTestsTypes()
        {
            InitializeComponent();
        }

        private void EditApplicationTypesMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestTyoe frm = new frmEditTestTyoe((clsTestType.enTestType)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListTestsTypes_Load(null, null);
        }

        private void frmListTestsTypes_Load(object sender, EventArgs e)
        {
            _dtAllTestTypes = clsTestType.GetAllTestTypes();
            dgvTestTypes.DataSource = _dtAllTestTypes;
            lblRecordsCount.Text = dgvTestTypes.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
