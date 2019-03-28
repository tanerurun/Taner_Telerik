using System;

namespace Taner.Data.Entities
{
    public abstract class EntityBase<TKey>
    {
        public TKey Id { get; set; } 
    }
}
