using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iş_takip_proje.entity1;
using System.Windows.Forms;

namespace iş_takip_proje.formlar
{
    public partial class frmDepartmanlar : Form
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {

        }
        void listele()
        {
           DbisTakipEntities db = new DbisTakipEntities();
            gridControl1.DataSource = db.tbldepartmanlar.ToList();         
        }
     
        private void BtnlListele_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
