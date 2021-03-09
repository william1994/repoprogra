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
            clear();


        }

        void clear() {
           
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtPass.Clear();

        }
        void Carga() {
            dtgListaUsuarios.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.UserList.ToList();

                foreach (var iteracion in Lista)
                {

                    dtgListaUsuarios.Rows.Add(iteracion.Id, iteracion.NombreUsario,iteracion.Apellido,iteracion.Edad,iteracion.Pass);
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                using (programacionEntities db = new programacionEntities()) {

                    UserList userList = new UserList();

                    userList.NombreUsario = txtNombre.Text;
                    userList.Apellido = txtApellido.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.Pass = txtPass.Text;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");
                }
            } catch (Exception EX) {
                MessageBox.Show(EX.ToString());
            
            }
            Carga();
            clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int Eliminar = Convert.ToInt32(txtId.Text);
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
            clear();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                using (programacionEntities db = new programacionEntities())
                {
                    int update = Convert.ToInt32(txtId.Text);
                    UserList user = db.UserList.Where(x => x.Id == update).Select(x => x).FirstOrDefault();
                    //UserList userListdddd = new UserList();
                    //userListdddd = db.UserList.Find(140);
                    user.NombreUsario = txtNombre.Text;
                    user.Apellido = txtApellido.Text;
                    user.Edad = Convert.ToInt32(txtEdad.Text);
                    user.Pass = txtPass.Text;
                    db.SaveChanges();
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            }
            Carga();
            clear();
        }

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dtgListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            String Edad = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            String Pass = dtgListaUsuarios.CurrentRow.Cells[4].Value.ToString();

            txtId.Text = Id;
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            txtEdad.Text = Edad;
            txtPass.Text = Pass;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
