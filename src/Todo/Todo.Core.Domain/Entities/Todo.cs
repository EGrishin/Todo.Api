using System;
using Todo.Core.Domain.Common;

namespace Todo.Core.Domain.Entities
{
    public class Todo : BaseEntity
    {
        /// <summary>
        /// Заголовок задачи
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Дата создания задачи
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Дата изменения задачи
        /// </summary>
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Дата завершения задачи
        /// </summary>
        public DateTime FinishedDate { get; set; } = DateTime.UnixEpoch;

        /// <summary>
        /// Флаг завершенности задачи
        /// </summary>
        public bool IsFinished { get; set; }
    }
}
