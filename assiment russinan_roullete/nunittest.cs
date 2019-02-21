using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace assiment_russinan_roullete
{
    class nunittest
    {
      shooted test = new shooted();
           [TestCase]
        public void pos()
        {
            Assert.AreEqual(1, test.spinner(6));
        }
  
        [TestCase]
        public void neg()
        {
            ;
            Assert.AreNotEqual(2, test.spinner(6));
        }
    }
}
