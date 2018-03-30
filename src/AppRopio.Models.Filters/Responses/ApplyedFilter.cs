using System.Collections.Generic;

namespace AppRopio.Models.Filters.Responses
{
    public class ApplyedFilter
    {
        public string Id { get; set; }

        public string MinValue { get; set; }

        public string MaxValue { get; set; }

        public bool Enabled { get; set; }

        public FilterDataType DataType { get; set; }

        public List<ApplyedFilterValue> Values { get; set; }
    }


}
