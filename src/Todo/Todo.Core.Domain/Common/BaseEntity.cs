using System;

namespace Todo.Core.Domain.Common
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// Id сущности
        /// </summary>
        public Guid Id { get; set; }
    }
}
