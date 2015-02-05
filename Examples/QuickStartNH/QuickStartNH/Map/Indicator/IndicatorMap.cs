using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickStartNH.Entity;
using QuickStartNH.Map.Base;

namespace QuickStartNH.Map
{
    public class IndicatorMap : BaseEntityMap<Indicator>
    {
        public IndicatorMap()
            : base("Indicator")
        {
            Property(x => x.Name, c => c.Column("NAME"));
        }
    }
}