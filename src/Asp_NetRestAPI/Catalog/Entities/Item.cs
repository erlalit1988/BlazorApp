using System;

namespace Catalog.Entities
{
    public record Item
    {
        /* record types prity much class
        - use for immutable objects
        - With-expressions support
        - value-based equality support
        */
       
        public Guid Id { get; init; }
         /*init only properties- is property initilizer
           // You can do this 
           Item item=new()
           {
              Id=Guid.NewGuid()
           };
           //But not this
            item.I=Guid.NewGuid()
        */
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreateDate { get; init; }
               
    }
}