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
    public partial class FrmVisuaUsuario : Form
    {
        public FrmVisuaUsuario()
        {
            InitializeComponent();
        }

        private void FrmVisuaUsuario_Load(object sender, EventArgs e)
        {
            ClsListaUsuario cls = new ClsListaUsuario();

            foreach (var iteracion in cls.user) {

                dataGridView1.Rows.Add(iteracion.ToString());
            }

        }
    }
}
