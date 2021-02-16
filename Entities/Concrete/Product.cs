
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity // public: bu classa diğer katmanlarda ulaşabilsin demektir. //defaultu internaldır. Internal bu classa sadece entities ulaşabilsin demektir.
    {   //Databasedeki temel nesneler
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
