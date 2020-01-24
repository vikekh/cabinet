using System;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.Core.Models
{
    public abstract class EntityBase : IEntity
    {
        public Guid Id { get; set; }
    }
}
