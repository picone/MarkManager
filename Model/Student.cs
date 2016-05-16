using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        private int _id;
        private String _name;
        private String _password;
        private String _email;
        private short _sex;
        private Clazz _clazz;

        public int id
        {
            set { _id = value; }
            get { return _id; }
        }

        public String name
        {
            set { _name = value; }
            get { return _name; }
        }

        public String password
        {
            set { _password = value; }
            get { return _password; }
        }

        public String email
        {
            set { _email = value; }
            get { return _email; }
        }

        public short sex
        {
            set { _sex = value; }
            get { return _sex; }
        }

        public Clazz clazz
        {
            set { _clazz = value; }
            get { return _clazz; }
        }
    }
}
