﻿using System;
using IQFeed.CSharpApiClient.Lookup.Chains.Messages;
using IQFeed.CSharpApiClient.Lookup.Chains.Options;
using IQFeed.CSharpApiClient.Tests.Common;
using IQFeed.CSharpApiClient.Tests.Common.TestCases;
using NUnit.Framework;

namespace IQFeed.CSharpApiClient.Tests.Lookup.Chains.Messages
{
    public class EquityOptionMessageTests
    {
        [Test, TestCaseSource(typeof(CultureNameTestCase), nameof(CultureNameTestCase.CultureNames))]
        public void Should_Parse_EquityOptionMessage_Culture_Independant(string cultureName)
        {
            // Arrange
            TestHelper.SetThreadCulture(cultureName);
            var optionSymbol = "AAPL1806G167.5";

            // Act
            var equityOptionMessageParsed = EquityOptionMessage.Parse(optionSymbol);
            var equityOptionMessage = new EquityOptionMessage(optionSymbol, "AAPL", 167.5f, new DateTime(2018, 07, 06), OptionSide.Call);

            // Assert
            Assert.AreEqual(equityOptionMessage, equityOptionMessageParsed);
        }
    }
}