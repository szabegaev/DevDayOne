using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using QuickStartNH.DataAccess.Base;

namespace QuickStartNH.Map.Base
{
    public class BaseEntityMap<T> : ClassMapping<T> where T : BaseEntity
    {
        protected BaseEntityMap(string tableName)
        {
            Table(tableName);
            Id(x => x.Id, m => m.Generator(Generators.Guid));
        }
    }
}