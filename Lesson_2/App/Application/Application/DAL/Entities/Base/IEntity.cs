namespace Application.Domain.Base
{
    /// <summary>
    /// Базовый интерфейс для сущностей
    /// </summary>
    interface IEntity
    {
        /// <summary>
        /// Уникальный идентификатор сущности
        /// </summary>
        int Id { get; set; }
    }
}
