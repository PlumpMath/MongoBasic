﻿using MongoBasic.Core;
using MongoBasic.Core.IdGeneration;
using MongoDB.Driver;

namespace MongoBasic.Tests.TestHelper
{
    public class TestSessionMongoFactory : AbstractMongoSessionFactory
    {
        public TestSessionMongoFactory(MongoSessionFactoryConfig mongoSettings) : base(mongoSettings)
        {
        }

        protected override void AfterSessionFactoryInitialized(MongoDatabase mongoDatabase)
        {
            RegisterClassMap(new PersonMap());
            RegisterClassMap(new VehicleMap(new AutoIncrementIdGenerator<long>(mongoDatabase, "Vehicles")));
        }
    }
}