using System.Collections.Generic;

namespace EnterpriseTester.API.Client.Models
{
    public class QueryResults<T> : EtRestEntityBase
    {
        public QueryResults()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }
        public int Skip { get; set; }
        public int Top { get; set; }
        public int Total { get; set; }
    }
}