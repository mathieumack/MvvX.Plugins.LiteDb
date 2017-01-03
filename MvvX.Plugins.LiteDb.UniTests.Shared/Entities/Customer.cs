using System;
using System.Collections.Generic;
using System.Text;

namespace MvvX.Plugins.LiteDb.UniTests.Shared.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string[] Phones { get; set; }

        public bool IsActive { get; set; }
    }
}
