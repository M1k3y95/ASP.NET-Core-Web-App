using Application.Domain.Base;
using System;
using System.Collections.Generic;

namespace Application.Domain
{
    public class InvoiceEntity: BaseEntity
    {
        /// <summary>
        /// Название счета
        /// </summary>
        public string invoiceName { get; set; }

        /// <summary>
        /// Факт оплаты
        /// </summary>
        public bool IsPayed { get; private set; }

        /// <summary>
        /// Дата оплаты
        /// </summary>
        public DateTime PayDate { get; set; }


        /// <summary>
        /// Список выполненных работ
        /// </summary>
        public List<TaskEntity> CompletedTasks { get; set; }

        /// <summary>
        /// Итоговая сумма
        /// </summary>
        public decimal TotalSum 
        { 
            get 
            {
                int sum = 0;
                if (CompletedTasks is null)
                {
                    return sum;
                }
                foreach (var task in CompletedTasks)
                {
                    sum += task.Price;
                }
                return sum;
            } 
        }

        /// <summary>
        /// Оплата получена
        /// </summary>
        public void Pay()
        {
            IsPayed = true;
            PayDate = DateTime.Now;
        }

    }
}
