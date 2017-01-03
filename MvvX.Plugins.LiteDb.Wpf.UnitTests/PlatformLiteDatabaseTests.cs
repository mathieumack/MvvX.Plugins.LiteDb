using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvvX.Plugins.LiteDb.UniTests.Shared.Entities;

namespace MvvX.Plugins.LiteDb.Wpf.UnitTests
{
    [TestClass]
    public class PlatformLiteDatabaseTests
    {
        [TestMethod]
        public void Insert()
        {
            using (var db = new PlatformLiteDatabase())
            {
                db.Construct(@"MyData.db");

                db.DropCollection("customers");

                // Get customer collection
                var customers = db.GetCollection<Customer>("customers");

                // Create your new customer instance
                var customer = new Customer
                {
                    Name = "John Doe",
                    Phones = new string[] { "8000-0000", "9000-0000" },
                    IsActive = true
                };

                // Insert new customer document (Id will be auto-incremented)
                customers.Insert(customer);

                Assert.IsTrue(customers.Count() == 1);
                // Update a document inside a collection
                //customer.Name = "Joana Doe";

                //customers.Update(customer);

                //// Index document using a document property
                //customers.EnsureIndex(x => x.Name);

                //// Use Linq to query documents
                //var results = customers.Find(x => x.Name.StartsWith("Jo"));
            }
        }
    }
}
