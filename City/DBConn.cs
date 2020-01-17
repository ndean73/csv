using System;
using System.Collections.Generic;
using System.Text;

namespace Cities
{
    //public interface IDBConn
    //{
    //    public CitiesContext conn();
    
   // }
    public class DBConn  ///: IDBConn
    {
            public static CitiesContext conn() {
            var db = new CitiesContext() ;
            return db;
        }

    }
}
