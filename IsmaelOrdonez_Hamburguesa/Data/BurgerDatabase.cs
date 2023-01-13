using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Init();
            int result = conn.Insert(burger);
            return result;
        }

        public List<Burger> GetAllBurger()
        {
            Init();
            List<Burger> burgers = conn.Table<Burger>().ToList();
            return burgers;
        }
    }
}
