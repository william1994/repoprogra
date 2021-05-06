using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using William01.MODEL;

namespace William01.VISTA
{
    public partial class frmJoinvista : Form
    {
        public frmJoinvista()
        {
            InitializeComponent();
        }

        private void frmJoinvista_Load(object sender, EventArgs e)
        {
            load();
        }

        void load() {
            dataGridView1.Rows.Clear();
            using (programacionEntities bd = new programacionEntities()) {

                var consulta = (from user in bd.UserList
                                from type in bd.TypeOfUser
                                where user.IdTypeOfUser == type.IdTypeOfUser && user.NombreUsario.Contains(textBox1.Text)
                                select new
                                {
                                    user.NombreUsario,
                                    type.TypeofUserName
                                }
                                ).ToList();


                foreach (var iteracion in consulta) { 
                dataGridView1.Rows.Add(iteracion.NombreUsario, iteracion.TypeofUserName);
                }


            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
