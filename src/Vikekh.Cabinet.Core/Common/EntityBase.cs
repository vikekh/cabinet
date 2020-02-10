using System;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.Core.Common
{
    public abstract class EntityBase : IEntity
    {
        public Guid Id { get; private set; }
    }
}
