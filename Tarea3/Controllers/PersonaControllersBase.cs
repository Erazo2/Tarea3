namespace Tarea3.Controllers
{
    public class PersonaControllersBase
    {

        //metodo CRUD 
        public Task<int> SavePersonas(Personas personas)
        {
            if (personas.Id != 0)
                return connection.UpdateAsync(personas);

            else
                return connection.InsertAsync(personas);
        }
    }
}