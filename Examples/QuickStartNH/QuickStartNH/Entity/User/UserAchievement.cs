using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickStartNH.DataAccess.Base;

namespace QuickStartNH.Entity
{
    /// <summary>
    /// Отношение многие ко многим между User и Achievement
    /// </summary>
    public class UserAchievement : BaseEntity
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Достижение
        /// </summary>
        public virtual Achievement Achievement { get; set; }
    }
}
