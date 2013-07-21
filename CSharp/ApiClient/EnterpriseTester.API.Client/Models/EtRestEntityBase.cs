using System.Collections.Generic;

namespace EnterpriseTester.API.Client.Models
{
    public class EtRestEntityBase
    {
        private static readonly string[] EmptyExpands = new string[] {};
        private string[] _expands;

        public EtRestEntityBase()
        {
            Links = new List<RestLink>();
        }

        public List<RestLink> Links { get; set; }

        public string[] Expands
        {
            get { return _expands ?? EmptyExpands; }
            set { _expands = value; }
        }
    }
}