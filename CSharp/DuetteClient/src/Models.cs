using System;
using System.Collections.Generic;
using System.Linq;

namespace EnterpriseTester.DuetteClient
{
    public class Link
    {
        public string Href { get; set; }
        public string Rel { get; set; }
    }

    public abstract class AbstractModel
    {
        protected AbstractModel()
        {
            Links = new List<Link>();
        }

        public List<Link> Links { get; set; }

        public string GetLink(string rel)
        {
            Link match = Links.FirstOrDefault(l => l.Rel == rel);

            if (match == null)
            {
                throw new ArgumentException(string.Format("Unable to find link with relationship: {0}", rel), "rel");
            }
            else
            {
                return match.Href;
            }
        }
    }

    public class Project : AbstractModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class Root : AbstractModel
    {
    }

    public class SystemInfo
    {
        public string PackagePathSeparator { get; set; }
    }

    public class AutomatedTest : AbstractModel
    {
        public Guid? Id { get; set; }
        public string Type { get; set; }
        public Guid PackageId { get; set; }
        public AutomatedTestConfiguration Configuration { get; set; }

        public string Name { get; set; }
    }

    public class AutomatedTestAssignment : AbstractModel
    {
        public Guid? Id { get; set; }
        public Guid AutomatedTestId { get; set; }
        public Guid PackageId { get; set; }
    }

    public class AutomatedTestConfiguration
    {
        public string Type { get; set; }
    }

    public class Package : AbstractModel
    {
        public Guid? ProjectId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class Collection<T>
    {
        public Collection()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }
    }

    public class BackgroundTask
    {
        public bool Complete { get; set; }
        public string Error { get; set; }
        public string Self { get; set; }
        public string Message { get; set; }
        public int? TotalElements { get; set; }
        public int? ProcessedElements { get; set; }
        public DateTime StartedAt { get; set; }
        public double ProgressInPercent { get; set; }
        public string Id { get; set; }
    }
}