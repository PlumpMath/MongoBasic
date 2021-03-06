﻿using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;

namespace MongoBasic.Core.Abstract
{
    public interface IMongoSession
    {
        IQueryable<TEntity> Query<TEntity>();
        IQueryable<TEntity> Query<TEntity>(string[] fields);
        IQueryable<TEntitySubType> QuerySubType<TEntity, TEntitySubType>();
        TEntity Get<TEntity>(object id);
        void Save<TEntity>(TEntity entity);
        void SaveBatch<TEntity>(IEnumerable<TEntity> entities);
        void Delete<TEntity>(TEntity entity);
        void DeleteAll<TEntity>();
        void DropAllCollections();
        int Count<TEntity>();
        DatabaseStatsResult Status();
        MongoCollection<TEntity> GetCollection<TEntity>();
    }
}