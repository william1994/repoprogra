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
            ClsDUserList clsDUserList = new ClsDUserList();
            List<UserList> Lista = clsDUserList.cargarDatosUserlit();

            foreach (var iteracion in Lista)
            {

                dtgListaUsuarios.Rows.Add(iteracion.Id, iteracion.NombreUsario, iteracion.Apellido, iteracion.Edad, iteracion.Pass);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                ClsDUserList clsDUserList = new ClsDUserList();
                //clsDUserList.SaveDatosUser(txtNombre.Text,txtApellido.Text,Convert.ToInt32(txtEdad.Text),txtPass.Text);
                UserList userList = new UserList();
                userList.NombreUsario = txtNombre.Text;
                userList.Apellido = txtApellido.Text;
                userList.Edad = Convert.ToInt32(txtEdad.Text);
                userList.Pass = txtPass.Text;
                clsDUserList.SaveDatosUser(userList);
            }
            else {
                ClsDUserList clsDUserList = new ClsDUserList();

                UserList userList = new UserList();
                userList.Id = Convert.ToInt32(txtId.Text);
                userList.NombreUsario = txtNombre.Text;
                userList.Apellido = txtApellido.Text;
                userList.Edad = Convert.ToInt32(txtEdad.Text);
                userList.Pass = txtPass.Text;
                clsDUserList.updateUser(userList);

            }
            Carga();
            clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsDUserList user = new ClsDUserList();
            user.deleteUser(Convert.ToInt32(txtId.Text));
            Carga();
            clear();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
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
