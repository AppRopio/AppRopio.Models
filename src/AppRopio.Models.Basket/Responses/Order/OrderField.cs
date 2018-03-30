using AppRopio.Models.Basket.Responses.Enums;
using System.Collections.Generic;

namespace AppRopio.Models.Basket.Responses.Order
{
    public class OrderField
    {
        public string Id { get; set; }

        /// <summary>
        /// Название поля
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Поле используется для подстановки предзаполненного значения (или значения, запомненного ранее)
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Используется для передачи перечня значений, из которых пользователь может выбрать
        /// </summary>
        public List<string> Values { get; set; }

        public OrderFieldType Type { get; set; }

        /// <summary>
        /// Флаг отвечающий за возможность редактирования поля (например, может быть false, если уже заполнено и провалидировано)
        /// </summary>
        public bool Editable { get; set; }

        /// <summary>
        /// Поле обязательно для заполнения (если true, то должно быть редактируемым !)
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Выпадающее поле (если true, то должно быть не обязательным и редактируемым !)
        /// </summary>
        public bool IsOptional { get; set; }

        /// <summary>
        /// Имеет возможность автозаполнения поля или нет
        /// </summary>
        public bool HasAutocomplete { get; set; }

        /// <summary>
        /// Индекс символа, с которого начинается выбор автозаполнения (начиная с 0 !)
        /// </summary>
        public int AutocompleteStartIndex { get; set; }

        /// <summary>
        /// Список id полей, от которых зависит текущее поле (например: улица → город)
        /// </summary>
        public List<string> DependentFieldsIds { get; set; }
    }
}
