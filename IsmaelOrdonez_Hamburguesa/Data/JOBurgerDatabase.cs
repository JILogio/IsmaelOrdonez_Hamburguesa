//using Android.App;
using IsmaelOrdonez_Hamburguesa.Models;
using SQLite;

namespace IsmaelOrdonez_Hamburguesa.Data
{
    public class JOBurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;

        public JOBurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<JOBurger>();
        }

        public int AddNewBurger(JOBurger burger)
        {
            if (burger.Id != 0)
                return conn.Update(burger);
            else
                return conn.Insert(burger);
        }

        public int DeleteBurger(JOBurger burger)
        {
            Init();
            return conn.Delete(burger);
        }

        public List<JOBurger> GetAllBurger()
        {
            Init();
            List<JOBurger> burgers = conn.Table<JOBurger>().ToList();
            return burgers;
        }
    }
}
