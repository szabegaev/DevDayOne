using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickStartNH.DataAccess.Base;

namespace QuickStartNH.Entity
{
    public class AchievementIndicator : BaseEntity
    {
        /// <summary>
        /// Достижение
        /// </summary>
        public virtual Achievement Achievement { get; set; }

        /// <summary>
        /// показатель
        /// </summary>
        public virtual Indicator Indicator { get; set; }

        /// <summary>
        /// количественный показатель для получения достижения
        /// </summary>
        public virtual long Count { get; set; }
    }
}
