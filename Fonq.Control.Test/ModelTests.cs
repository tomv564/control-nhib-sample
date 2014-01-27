using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using Fonq.Control.Data;
using Fonq.Control.Entities;

namespace Font.Control.Test
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void CanLoadCustomer()
        {
            ISessionFactory factory = ControlDatabase.CreateSessionFactory();
            using (var session = factory.OpenSession())
            {
                var customer = session.Get<Customer>("1");
                Assert.AreEqual("Apart Design", customer.Name);

            }
        
        }

        [TestMethod]
        public void CanLoadCustomerWithAddress()
        {
            ISessionFactory factory = ControlDatabase.CreateSessionFactory();
            using (var session = factory.OpenSession())
            {
                var customer = session.Get<Customer>("1");
                Assert.AreEqual("Apart Design", customer.Name);
                Assert.IsNotNull(customer.DeliveryAddress);
                Assert.AreEqual("1811JR", customer.DeliveryAddress.Postalcode);
            }
        }


    }
}
