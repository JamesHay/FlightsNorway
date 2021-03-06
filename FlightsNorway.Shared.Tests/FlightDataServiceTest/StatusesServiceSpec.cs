﻿using System;
using System.Collections.Generic;

using FlightsNorway.Shared.Model;
using FlightsNorway.Shared.FlightDataServices;

using Microsoft.Silverlight.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightsNorway.Shared.Tests.FlightDataServiceTest
{
    [TestClass]
    public class StatusesServiceTest : SilverlightTest
    {
        [TestMethod, Asynchronous, Timeout(5000), Tag(Tags.WebService)]
        public void Should_be_able_to_get_airport_names()
        {
            var statusList = new List<Status>();
            service.GetStautses().Subscribe(statusList.AddRange);
            EnqueueConditional(() => statusList.Count > 0);
            EnqueueTestComplete();
        }

        [TestInitialize]
        public void Setup()
        {
            service = new StatusService();
        }

        private StatusService service;
    }
}
