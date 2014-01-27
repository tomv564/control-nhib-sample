using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Conventions;
using System.Text.RegularExpressions;

namespace Fonq.Control.Data
{
    public class UnderscoreColumnConvention : IPropertyConvention
    {
        public void Apply(FluentNHibernate.Conventions.Instances.IPropertyInstance instance)
        {
            instance.Column(UnderscoreNamingStrategy.FromProperty(instance.Name));
           
        }
    }
}
