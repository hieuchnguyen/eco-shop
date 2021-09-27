using System;

namespace backoffice.Models
{
    public abstract class AggregateRoot
    {
        protected AggregateRoot(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}