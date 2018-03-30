namespace AppRopio.Models.Filters.Responses
{
    public enum FilterWidgetType
    {
        Unknown = 0,

        /// <summary>
        /// The horizontal collection.
        /// </summary>
        HorizontalCollection,

        /// <summary>
        /// Вертикальная коллекция с возможностью множественного выбора
        /// </summary>
        VerticalCollection,

        /// <summary>
        /// Выбор минимального и максимального значения (от-до)
        /// </summary>
        MinMax,

        /// <summary>
        /// Выбор одного варианта через "карусель"
        /// </summary>
        Picker,

        /// <summary>
        /// Выбор одного варианта на отдельном экране
        /// </summary>
        OneSelection,

        /// <summary>
        /// Выбор нескольких вариантов на отдельном экране
        /// </summary>
        MultiSelection,

        /// <summary>
        /// Включение или выключение некого параметра
        /// </summary>
        Switch
    }
}
