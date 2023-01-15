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
    }
}
