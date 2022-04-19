using Application.Domain.Base;
using System;

namespace Application.Domain
{
    /// <summary>
    /// Данные о контракте
    /// </summary>
    public class ContractEntity: BaseEntity
    {
        /// <summary>
        /// Название контракта
        /// </summary>
        public string ContractName { get; set; }

        /// <summary>
        /// Данные о клиенте
        /// </summary>
        public ClientEntity Client { get; set; }

        /// <summary>
        /// Дата заключения договора
        /// </summary>
        public DateTime ContractDate => DateTime.Now;

        /// <summary>
        /// Описание договора
        /// </summary>
        public string Description { get; set; }
    }
}
