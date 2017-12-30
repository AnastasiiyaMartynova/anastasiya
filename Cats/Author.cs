using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class AuthorClass
    {
        public virtual int Id { get; protected set; }

        public virtual string Name { get; set; }

        public virtual Book WrittenBook { get; set; }



        public AuthorClass()
        {

        }


    }
}
