using System;
using System.ComponentModel.DataAnnotations.Schema;
using Vikekh.Cabinet.Web.Interfaces;

namespace Vikekh.Cabinet.Web.Models
{
    public abstract class EntityBase : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
    }
}
