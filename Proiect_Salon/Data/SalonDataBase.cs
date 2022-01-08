using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using Proiect_Salon.SalonModels;

namespace Proiect_Salon.Data
{
    public class SalonDataBase
    {
        readonly SQLiteAsyncConnection _database;
        public SalonDataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Recenzii>().Wait();
        }
        public Task<int> SaveRecenziiAsync(Recenzii slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }

        public Task<int> DeleteRecenziiAsync(Recenzii slist)
        {
            return _database.DeleteAsync(slist);
        }

        public Task<List<Recenzii>> GetRecenziisAsync()
        {
            return _database.Table<Recenzii>().ToListAsync();
        }
    
        public Task<Recenzii> GetRecenziiAsync(int id)
        {
            return _database.Table<Recenzii>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }         
    }
}
