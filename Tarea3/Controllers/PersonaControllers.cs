using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Tarea3.MODEL;
using Tarea3.Controllers;
using System.Threading.Tasks;
using System.IO;

namespace Tarea3.Controllers
{
    public class PersonaControllers
    {

        readonly SQLiteAsyncConnection connection;
        public PersonaControllers(string DBpath)
        {
            connection = new SQLiteAsyncConnection(DBpath);
            connection.CreateTableAsync<MODEL.Personas>();
        }
        
        //metodo CRUD 
        public Task<int> Saveemple(Personas personas)
        {
            if (personas.Id != 0)
                return connection.UpdateAsync(personas);

            else
            return connection.InsertAsync(personas);
        }
        //seleccionar
        public Task<MODEL.Personas> GetPersona(int pid)
        {
            return connection.Table<MODEL.Personas>()
                .Where(i => i.Id = pid)
                .FirstOrDefaultAsync();
                
        }
        public Task<List<MODEL.Personas>> GetListPersona()
        {
            return connection.Table<MODEL.Personas>().ToListAsync();
        }
        //Delete
        public Task<int> DeletePersona(MODEL.Personas personas)
        {
            return connection.DeleteAsync(personas);
        }

    }
}
