using System.Collections.Generic;
using QuickStartNH.DataAccess.Base;

namespace QuickStartNH.Entity
{
    public class User : BaseEntity
    {
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }

         /// <summary>
        /// Набор связей с таблицей пользователей достижений
        /// </summary>
        public virtual ICollection<UserAchievement> UserAchievements { get; set; }

         /// <summary>
        /// Набор связей с таблицей пользователей показателей
        /// </summary>
        public virtual ICollection<UserIndicator> UserIndicators { get; set; }

    }
}