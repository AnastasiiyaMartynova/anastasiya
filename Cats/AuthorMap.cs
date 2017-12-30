using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Books
{
    class AuthorMap : ClassMap<AuthorClass>
    {
        public AuthorMap()
        {
            Id(t => t.Id);
            Map(t => t.Name);
            Map(t => t.WrittenBook.Title);
        }

        public static void addAuthorToDB(AuthorClass author)
        {
            var sessionFactory = CreateSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(author);
                    transaction.Commit();
                }
            }
        }



        private static ISessionFactory CreateSessionFactory()
        {
            return
                Fluently.Configure()
                    .Database(SQLiteConfiguration.Standard.UsingFile("C:\\books\\books.db"))
                    .Mappings(t => t.FluentMappings.AddFromAssemblyOf<AuthorClass>()).ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
                    .BuildSessionFactory();
        }
    }
}

