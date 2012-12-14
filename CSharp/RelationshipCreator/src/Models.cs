using System;
using System.Collections.Generic;
using System.Linq;

namespace RelationshipCreator
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

    public class Organisation : AbstractModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Self { get; set; }
    }

    public class Script : AbstractModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class Requirement : AbstractModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class Relationship : AbstractModel
    {
    }

    public class Root : AbstractModel
    {
    }

    public class CreateRelationshipModel
    {
        public string RelationshipDirection { get; set; }
        public Guid DestinationEntityId { get; set; }
        public string DestinationEntityType { get; set; }
        public Guid SourceEntityId { get; set; }
        public string SourceEntityType { get; set; }
    }

    public class Collection<T>
    {
        public Collection()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }
    }
}