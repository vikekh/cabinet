using System;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.Core.Common
{
    public abstract class EntityBase : IEntity
    {
        public EntityBase()
        {
            //Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
