using System.Collections.Generic;
 
namespace AppRopio.Models.Filters.Responses
{
    public class Filter : ApplyedFilter
    {
        public string Name { get; set; }

        public FilterWidgetType WidgetType { get; set; }

        public new List<FilterValue> Values { get; set; }
    }
    
}
