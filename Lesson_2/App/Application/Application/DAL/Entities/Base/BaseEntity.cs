namespace Application.Domain.Base
{
    /// <summary>
    /// Базовый класс для сущностей
    /// </summary>
    public class BaseEntity : IEntity
    {
        /// <summary>
        /// Уникальный идентификатор сущности
        /// </summary>
        public int Id { get; set; }
    }
}
