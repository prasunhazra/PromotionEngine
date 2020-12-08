using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System.Collections.Generic;

namespace PromotionEngineTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<ISKU> ScenarioA = new List<ISKU> { new skuA(), new skuB(), new skuC() };
            int cost = new PromotionA(ScenarioA).Cost();
            Assert.AreEqual(cost, 50);
            cost = new PromotionB(ScenarioA).Cost();
            Assert.AreEqual(cost, 30);
            cost = new PromotionCD(ScenarioA).Cost();
            Assert.AreEqual(cost, 20);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<ISKU> Scenario2 = new List<ISKU> { new skuA(), new skuA(), new skuA(), new skuA(), new skuA(),
                                                    new skuB(), new skuB(), new skuB(), new skuB(), new skuB(),
                                                    new skuC() };

            int cost = new PromotionA(Scenario2).Cost();
            Assert.AreEqual(cost, 230);
            cost = new PromotionB(Scenario2).Cost();
            Assert.AreEqual(cost, 120);
            cost = new PromotionCD(Scenario2).Cost();
            Assert.AreEqual(cost, 20);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<ISKU> Scenario3 = new List<ISKU> { new skuA(), new skuA(), new skuA(), 
                                                    new skuB(), new skuB(), new skuB(), new skuB(), new skuB(),
                                                    new skuC(),
                                                    new skuD() };
            int cost = new PromotionA(Scenario3).Cost();
            Assert.AreEqual(cost, 130);
            cost = new PromotionB(Scenario3).Cost();
            Assert.AreEqual(cost, 120);
            cost = new PromotionCD(Scenario3).Cost();
            Assert.AreEqual(cost, 30);
        }
    }
}
