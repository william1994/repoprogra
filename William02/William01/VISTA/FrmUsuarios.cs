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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                using (programacionEntities db = new programacionEntities()) {

                    UserList userList = new UserList();

                    userList.NombreUsario = textBox1.Text;
                    userList.Apellido = textBox2.Text;
                    userList.Edad = Convert.ToInt32(textBox3.Text);
                    userList.Pass = textBox4.Text;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");
                }
            } catch (Exception EX) {
                MessageBox.Show(EX.ToString());
            
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    UserList userListdddd = new UserList();
                    int Eliminar = Convert.ToInt32(textBox5.Text);
                    userListdddd = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userListdddd);
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());

            }

        }
    }
}
