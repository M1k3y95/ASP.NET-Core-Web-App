using Application.Domain.Base;

namespace Application.Domain
{
    /// <summary>
    /// Данные о клиенте
    /// </summary>
    public class ClientEntity: BaseEntity
    {
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string consumerName { get; set; }
    }
}
