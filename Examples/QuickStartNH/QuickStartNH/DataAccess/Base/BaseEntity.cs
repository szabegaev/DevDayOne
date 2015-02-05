using System;

namespace QuickStartNH.DataAccess.Base
{
    public class BaseEntity : IEntity
    {

        public Guid Id { get; set; }

        object IEntity.Id
        {
            get { return Id; }
            set { Id = (Guid)value; }
        }
    }
}