﻿using NUnit.Framework;
using Rebus.Tests.Contracts.Sagas;

namespace Rebus.Tests.Persistence.SqlServer
{
    [TestFixture]
    public class TestSagaCorrelationSql : TestSagaCorrelation<SqlServerSagaStorageFactory> { }
}