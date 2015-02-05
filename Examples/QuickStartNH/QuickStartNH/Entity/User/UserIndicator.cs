using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickStartNH.DataAccess.Base;

namespace QuickStartNH.Entity
{
    public class UserIndicator : BaseEntity
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Достижение
        /// </summary>
        public virtual Indicator Indicator { get; set; }

        /// <summary>
        /// количественный показатель пользователя для определенного свойства
        /// </summary>
        public virtual long Count { get; set; }
    }
}
