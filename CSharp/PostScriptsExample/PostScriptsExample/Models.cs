using System.Net;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostScriptsExample
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Picklist> Priorities { get; set; }
        public List<Picklist> Statuses { get; set; }
        public List<Picklist> TestTypes { get; set; }

        public Guid ResolvePriorityId(string text)
        {
            return Priorities.First(item => item.Text == text).Id;
        }

        public Guid ResolveStatusId(string text)
        {
            return Statuses.First(item => item.Text == text).Id;
        }

        public Guid ResolveTypeID(string text)
        {
            return TestTypes.First(item => item.Text == text).Id;
        }
    }

    public class Package
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class Picklist
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
    }

    public class Collection<T>
    {
        public Collection()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }
    }

    public class Step
    {
        public string Description { get; set; }
        public string ExpectedResult { get; set; }
        public string Notes { get; set; }
        public string Data { get; set; }
    }

    public class Script
    {
        public string Name { get; set; }
        public Guid PackageId { get; set; }
        public Guid StatusId { get; set; }
        public Guid TypeId { get; set; }
        public Guid PriorityId { get; set; }
        public List<Step> Steps { get; set; }
        public string Description { get; set; }
    }

    public class CreatedInfo
    {
        public Guid Id { get; set; }
        public string Self { get; set; }
    }
}
