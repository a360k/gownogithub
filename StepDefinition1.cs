using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NUnitTestProject1
{
    [Binding]
    public sealed class StepDefinition1
    {
        private readonly ScenarioContext _scenarioContext;

        public StepDefinition1(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the first number is '(.*)' and total is '(.*)'")]
        public void GivenTheFirstNumberIsAndTotalIs(int p0, int p1)
        {
            var total = p0 + 100;
            Assert.AreEqual(p1, total);
        }
    }
}
