using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using William01.DAO;

namespace William01.VISTA
{
    public partial class FrmJoin : Form
    {
        public FrmJoin()
        {
            InitializeComponent();

        }

        private void FrmJoin_Load(object sender, EventArgs e)
        {
            ClsDJoin join = new ClsDJoin();
            List<List<Object>> Matiz = new List<List<Object>>();
            Matiz = join.JoinUsuarioType();

            for (int i = 0; i < Matiz.Count; i++) {

                dataGridView1.Rows.Add(Matiz[i][0], Matiz[i][1], Matiz[i][2], Matiz[i][3]);
            }


        }
    }
}
