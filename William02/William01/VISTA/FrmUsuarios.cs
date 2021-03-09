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
            Carga();

           
        }
        void Carga() {
            dataGridView1.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.UserList.ToList();

                foreach (var iteracion in Lista)
                {

                    dataGridView1.Rows.Add(iteracion.Id, iteracion.NombreUsario,iteracion.Apellido,iteracion.Edad,iteracion.Pass);
                }

            }
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
            Carga();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int Eliminar = Convert.ToInt32(textBox5.Text);
                    UserList userListdddd = db.UserList.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();
                    
                    //userListdddd = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userListdddd);
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());

            }
            Carga();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                using (programacionEntities db = new programacionEntities())
                {
                    int update = Convert.ToInt32(textBox5.Text);
                    UserList user = db.UserList.Where(x => x.Id == 140).Select(x => x).FirstOrDefault();
                    //UserList userListdddd = new UserList();
                    //userListdddd = db.UserList.Find(140);
                    user.NombreUsario = textBox1.Text;
                    user.Apellido = textBox2.Text;
                    user.Edad = Convert.ToInt32(textBox3.Text);
                    user.Pass = textBox4.Text;
                    db.SaveChanges();
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            }
            Carga();
        }
    }
}
