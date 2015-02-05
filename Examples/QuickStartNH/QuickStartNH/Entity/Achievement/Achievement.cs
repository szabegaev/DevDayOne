using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickStartNH.DataAccess.Base;

namespace QuickStartNH.Entity
{
    public class Achievement : BaseEntity
    {
        public virtual string Name { get; set; }

        /// <summary>
        /// Набор связей с таблицей достижений показателей
        /// </summary>
        public virtual ICollection<AchievementIndicator> AchievementIndicators { get; set; }
    }
}
