using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickStartNH.DataAccess.Base;

namespace QuickStartNH.Entity
{
    public class Indicator : BaseEntity
    {
        public virtual string Name { get; set; }
    }
}