using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using William01.MODEL;

namespace William01.DAO
{
    class ClsDUserList
    {
        public List<UserList> cargarDatosUserlit() {
            List<UserList> Lista;

            using (programacionEntities db = new programacionEntities())
            {
                 Lista = db.UserList.ToList();


            }

            return Lista;
        }

        //public void SaveDatosUser(String Nombre, String Apellido, int Edad, String  Pass) {

        //    try
        //    {
        //        using (programacionEntities db = new programacionEntities())
        //        {

        //            UserList userList = new UserList();

        //            userList.NombreUsario = Nombre ;
        //            userList.Apellido = Apellido;
        //            userList.Edad = Edad;
        //            userList.Pass = Pass;
        //            db.UserList.Add(userList);
        //            db.SaveChanges();

        //            MessageBox.Show("Save");
        //        }
        //    }
        //    catch (Exception EX)
        //    {
        //        MessageBox.Show(EX.ToString());

        //    }

        //}

        public void SaveDatosUser(UserList user)
        {

            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();

                    userList.NombreUsario = user.NombreUsario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());

            }

        }

        public void deleteUser(int iD) {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
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

        }

        public void updateUser(UserList user) {

            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int update = Convert.ToInt32(user.Id);
                    UserList userList = db.UserList.Where(x => x.Id == update).Select(x => x).FirstOrDefault();
                    //UserList userListdddd = new UserList();
                    //userListdddd = db.UserList.Find(140);
                    

                    userList.NombreUsario = user.NombreUsario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
    }
}
