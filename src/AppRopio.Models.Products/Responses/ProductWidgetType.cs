namespace AppRopio.Models.Products.Responses
{
    public enum ProductWidgetType
    {
        /// <summary>
        /// Не определен
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Горизонтальная коллекция
        /// </summary>
        HorizontalCollection = 1,

        /// <summary>
        /// Вертикальная коллекция с возможностью множественного выбора
        /// </summary>
        VerticalCollection = 2,

        /// <summary>
        /// Выбор минимального и максимального значения (от-до)
        /// </summary>
        MinMax = 3,

        /// <summary>
        /// Выбор одного варианта через "карусель"
        /// </summary>
        Picker = 4,

        /// <summary>
        /// Выбор одного варианта на отдельном экране
        /// </summary>
        OneSelection = 5,

        /// <summary>
        /// Выбор нескольких вариантов на отдельном экране
        /// </summary>
        MultiSelection = 6,

        /// <summary>
        /// Включение или выключение некого параметра
        /// </summary>
        Switch = 7,

        /// <summary>
        /// Текстовый блок с текстом в несколько строк
        /// </summary>
        MultilineText = 8,

        /// <summary>
        /// Переход на другой экран
        /// </summary>
        Transition = 9
    }
}