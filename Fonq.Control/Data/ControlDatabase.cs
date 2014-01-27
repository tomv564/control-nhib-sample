using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Automapping;
using Fonq.Control.Entities;

namespace Fonq.Control.Data
{
    public static class ControlDatabase
    {
        public static ISessionFactory CreateSessionFactory()
        {
            return FluentNHibernate.Cfg.Fluently.Configure()
                    .Database(MySQLConfiguration.Standard.ConnectionString(c => c.FromConnectionStringWithKey("Control")))
                    .Mappings(m => m.AutoMappings.Add(
                        AutoMap.AssemblyOf<Customer>(new AutoMappingConfiguration())
                                                            .Conventions.Setup(c => { 
                                                                c.Add<UnderscoreColumnConvention>(); 
                                                                c.Add<UnderscoreForeignKeyConvention>(); })))
                    .BuildSessionFactory();
        }
    }
}
