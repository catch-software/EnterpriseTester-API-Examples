using System;
using System.Runtime.Serialization;

namespace RelationshipCreator
{
    [Serializable]
    public class RelationshipExistsException : Exception
    {
        public RelationshipExistsException()
        {
        }

        public RelationshipExistsException(string message) : base(message)
        {
        }

        public RelationshipExistsException(string message, Exception inner) : base(message, inner)
        {
        }

        protected RelationshipExistsException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}