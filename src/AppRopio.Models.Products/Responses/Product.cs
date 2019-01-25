using System.Collections.Generic;
using AppRopio.Models.Base.Responses;

namespace AppRopio.Models.Products.Responses
{
    public class Product
    {
        public string GroupId { get; set; }

        public string Id { get; set; }

        public List<Image> ImageUrls { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Параметр, отвечающий за отметку товара. Чаще всего используется для индикации товара как избранного
        /// </summary>
        public bool IsMarked { get; set; }

        public ProductState State { get; set; }

        /// <summary>
        /// TODO: ???
        /// </summary>
        public List<ProductBadge> Badges { get; set; }

        /// <summary>
        /// Параметр, отвечающий за перезагрузку краткой информации о товаре при переходе в каточку товара. true – если нужно в карточке товара загрузить данные с сервера
        /// </summary>
        public bool NeedsReload { get; set; }

        #region Price
        //TODO: переделать Price с использованием модели Price

        /// <summary>
        /// Текущая цена товара (наиболее выгодная/минимальная для пользователя)
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Максимально возможная цена товара
        /// </summary>
        public decimal? MaxPrice { get; set; }

        /// <summary>
        /// Единица измерения свойства Price
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// Шаг изменения количества свойства Price
        /// </summary>
        public float UnitStep { get; set; }

        #endregion

        #region OldPrice
        //TODO: переделать OldPrice с использованием модели Price

        /// <summary>
        /// Старая или акционная цена товара
        /// </summary>
        public decimal? OldPrice { get; set; }

        /// <summary>
        /// Единица измерения свойства OldPrice
        /// </summary>
        public string UnitNameOld { get; set; }

        /// <summary>
        /// Шаг изменения количества свойства OldPrice
        /// </summary>
        public float? UnitStepOld { get; set; }

        #endregion

        #region ExtraPrice

        /// <summary>
        /// Дополнительная цена (выводится только в карточке товара)
        /// </summary>
        /// <remarks>наименее выгодная цена товара для пользователя (выводится только в карточке товара)</remarks>
        public Price ExtraPrice { get; set; }

        #endregion
    }
}
