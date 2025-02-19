using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_labs.src
{
    /// <summary>
    /// Исключение, генерирующееся при превышении 
    /// максимального числа объектов
    /// </summary>
    class TooManyObjectsException : OutOfMemoryException
    {
        private int _limit;
        /// <summary>
        /// Максимальное число объектов
        /// </summary>
        public int Limit {
            get => _limit;
        }

        /// <summary>
        /// Конструктор исключения
        /// </summary>
        /// <param name="message">Сообщение об ошибке</param>
        /// <param name="limit">Лимит количества объектов</param>
        public TooManyObjectsException(string message, int limit) : base(message) {
            _limit = limit;
        }
    }
}
