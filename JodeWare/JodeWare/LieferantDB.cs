using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JodeWare
{
    public class LieferantDB
    {
        readonly SQLiteAsyncConnection database;

        public LieferantDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Lieferant>().Wait();
        }

        public Task<List<Lieferant>> GetLieferantsAsync()
        {
            return database.Table<Lieferant>().ToListAsync();
        }

        public Task<Lieferant> GetLieferantAsync(int id)
        {
            return database.Table<Lieferant>().Where(i => i.LieID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveLieferantAsync(Lieferant lieferant)
        {
            if(lieferant.LieID == 0)
            {
                return database.UpdateAsync(lieferant);
            }
            else
            {
                return database.InsertAsync(lieferant);
            }
        }

        public Task<int> DeleteLieferantAsync(Lieferant lieferant)
        {
            return database.DeleteAsync(lieferant);
        }
    }
}
