using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Payment:IEntity
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public int MonthOfExp { get; set; }
        public int YearOfExp { get; set; }
        public int CVV { get; set; }
    }
}
