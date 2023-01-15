//using Android.App;
using IsmaelOrdonez_Hamburguesa.Models;
using SQLite;

namespace IsmaelOrdonez_Hamburguesa.Data
{
    public class BurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;

        public BurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Burger>();
        }

        public int AddNewBurger(Burger burger)
        {
            if (burger.Id != 0)
                return conn.Update(burger);
            else
                return conn.Insert(burger);
            /*
            if (burger.Name == null || burger.Description == null)
                return result;

            result = conn.Insert(burger);
            return result;*/
        }

        public int DeleteBurger(Burger burger)
        {
            Init();
            return conn.Delete(burger);
        }

        public List<Burger> GetAllBurger()
        {
            Init();
            List<Burger> burgers = conn.Table<Burger>().ToList();
            return burgers;
        }

        /*private async Task Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteAsyncConnection(_dbPath);

            await conn.CreateTableAsync<Burger>();
        }

        public async Task<int> AddNewBurger(Burger burger)
        {
            await Init();
            if (burger.Id !=0)
                return await conn.UpdateAsync(burger);
            else
                return await conn.InsertAsync(burger);
        }

        public async Task<List<Burger>> GetAllBurger()
        {
            await Init();
            List<Burger> burgers = await conn.Table<Burger>().ToListAsync();
            return burgers;
        }

        public async Task<int> DeleteBurger(Burger burger)
        {
            await Init();
            return await conn.DeleteAsync(burger);
        }*/
    }
}
