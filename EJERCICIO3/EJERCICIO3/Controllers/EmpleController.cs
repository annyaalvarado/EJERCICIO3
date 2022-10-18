using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using EJERCICIO3.Models;
using System.Threading.Tasks;

namespace EJERCICIO3.Controllers
{
    public class EmpleController
    {
        readonly SQLiteAsyncConnection _connection;
        public EmpleController(string dbpath)
        {
            _connection = new SQLiteAsyncConnection(dbpath);

            _connection.CreateTableAsync<Empleado>().Wait();
        }
        //CRUD - CREATE-DELETE-READ-UPDATE

        //crear

        public Task<int> StoreEmple(Empleado emple)
        {
            if (emple.Id != 0)
            {
                return _connection.UpdateAsync(emple);
            }
            else
            {
                return _connection.InsertAsync(emple);
            }
        }

        //Leer

        public Task<List<Empleado>> ListaEmpleados()
        {
            return _connection.Table<Empleado>().ToListAsync();
        }

        public Task<Empleado> ObtenerEmpleados(int pid)
        {
            return _connection.Table<Empleado>().Where(i => i.Id == pid).FirstOrDefaultAsync();
        }

        public Task<int> DeleteEmple(Empleado emple)
        {
            return _connection.DeleteAsync(emple);
        }
    }
}
