using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgentsAndPasswords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentsAndPasswords.Tests
{
    [TestClass()]
    public class MI5AgentTests
    {

        MI5Agent JamesBond;
        CIAAgent FelixLeiter;

        [TestInitialize()]
        
        public void testSetUp()
        {
            JamesBond = new MI5Agent();
            FelixLeiter = new CIAAgent();
        }


        [TestMethod()]
        public void SaySecretGreetingTest()
        {
            Assert.AreEqual(JamesBond.SaySecretGreeting(), JamesBond.SecretPassword);

        }

        [TestMethod()]
        public void CheckSecretGreetingTest()
        {
            Assert.AreEqual(JamesBond.CheckSecretGreeting(FelixLeiter.SaySecretGreeting()), JamesBond.SecretAnswer);
            Assert.AreNotEqual(JamesBond.CheckSecretGreeting("wrong password"), JamesBond.CheckSecretGreeting(FelixLeiter.SaySecretGreeting()));
        }

        [TestMethod()]
        public void CheckSecretAnswerTest()
        {
            JamesBond.TrustOtherAgent = true;
            JamesBond.CheckSecretAnswer("wrong answer");
            Assert.AreEqual(JamesBond.DoITrustYou(), false);
        }

        [TestMethod()]
        public void DoITrustYouTest()
        {
            JamesBond.TrustOtherAgent = false;
            Assert.AreEqual(JamesBond.DoITrustYou(), false);
            JamesBond.TrustOtherAgent = true;
            Assert.AreEqual(JamesBond.DoITrustYou(), true);
        }


        [TestCleanup()]
        public void runCleanUp()
        {
            
        }
    }
}