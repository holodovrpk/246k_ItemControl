using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _246k_ItemControl
{
    // Внутренний класс, описывающий товар.
    internal class Product
    {
        // Наименование товара.
        public string Name { get; set; }
        // Цена товара (в минимальных денежных единицах).
        public int Price { get; set; }
        // Количество единиц товара на складе.
        public int Count { get; set; }
        // Текстовое описание товара.
        public string Description { get; set; }
        // Рейтинг товара (например, от 0 до 5).
        public int Rating { get; set; }
        // Обложка товара — путь или ссылка на изображение.
        public string Cover { get; set; }
    }
}
