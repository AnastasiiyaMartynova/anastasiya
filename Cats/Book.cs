using System.Collections.Generic;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;


namespace Books
{
    class Book
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual IList<Author> Authors { get; set; }

        public virtual double Rating { get; set; }

        public Book()
        {

        }




    }
    class Author
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Book> Books { get; set; }

    }
}