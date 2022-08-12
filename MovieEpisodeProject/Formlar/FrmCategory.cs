using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using FacadeLayer;
using BusinessLogicLayer;
using BusinessLogicLayer.BL;
using EntityLayer.Entities;

namespace MovieEpisodeProject.Formlar
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntityCategory> entityCategories = BLCategory.BLCategoryList();
            dataGridView1.DataSource = entityCategories;
        }
    }
}
