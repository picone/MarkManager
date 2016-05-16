using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Clazz
    {
        public static List<Model.Clazz> getClazzs()
        {
            List<Model.Clazz> result = new List<Model.Clazz>();
            SqlDataReader reader = DBHelper.query("SELECT [id],[name] FROM [clazz]");
            while(reader.Read())
            {
                Model.Clazz model = new Model.Clazz();
                model.id = reader.GetInt32(0);
                model.name = reader.GetString(1);
                result.Add(model);
            }
            return result;
        }
    }
}
