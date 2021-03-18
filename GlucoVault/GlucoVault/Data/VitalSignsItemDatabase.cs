using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace Todo
{
    public class VitalSignsItemDatabase
    {
        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<VitalSignsItemDatabase> Instance = new AsyncLazy<VitalSignsItemDatabase>(async () =>
        {
            var instance = new VitalSignsItemDatabase();
            CreateTableResult result = await Database.CreateTableAsync<VitalSignsItem>();
            return instance;
        });

        public VitalSignsItemDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<VitalSignsItem>> GetItemsAsync()
        {            
            return Database.Table<VitalSignsItem>().ToListAsync();
        }

        public Task<VitalSignsItem> GetVitalItem(int id)
        {
            var chartValue = Database.Table<VitalSignsItem>().Where(x => x.ID == id).FirstOrDefaultAsync();
            return chartValue;
        }

   

        public Task<VitalSignsItem> GetItemAsync(int id)
        {
            return Database.Table<VitalSignsItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(VitalSignsItem item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public void DeleteMonkey(VitalSignsItem item)
        {
            Database.DeleteAsync(item);
        }

        public Task<int> DeleteItemAsync(VitalSignsItem item)
        {
            return Database.DeleteAsync(item);
        }
    }
}

