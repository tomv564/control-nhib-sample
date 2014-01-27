using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;
using FluentNHibernate.Conventions;

namespace Fonq.Control.Data
{
    public class UnderscoreForeignKeyConvention : ForeignKeyConvention
    {
        protected override string GetKeyName(FluentNHibernate.Member member, Type type)
        {
            var keyName = UnderscoreNamingStrategy.FromProperty(member.Name);

            return keyName + "_id";
            
        }
    }
}
