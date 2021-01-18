using System.Collections.Generic;

namespace PortNet.Model.Models.Pagination
{
    public class PaginatedSt<T>
    {
        public List<T> Items { set; get; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalRow { get; set; }
    }
}