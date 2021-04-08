using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using William01.MODEL;

namespace William01.DAO
{
    class ClsDJoin
    {

        public List<List<Object>> JoinUsuarioType() {
            List<List<Object>> Matriz = new List<List<Object>>();
            using (programacionEntities db = new programacionEntities())
            {

                var lista = (from usuario in db.UserList
                            from type in db.TypeOfUser
                            where usuario.IdTypeOfUser == type.IdTypeOfUser

                            select new
                            {
                                usuario.Id,
                                usuario.NombreUsario,
                                type.IdTypeOfUser,
                                type.TypeofUserName

                            }).ToList();


                for (int i = 0; i < lista.Count; i++) {

                    Matriz.Add(new List<Object>()
                    {
                        lista[i].Id, lista[i].NombreUsario,lista[i].IdTypeOfUser,lista[i].TypeofUserName
                    });
                }
                        

            }

                return Matriz;
        }
    }
}
