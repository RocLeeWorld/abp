﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.MongoDB;

namespace Volo.Abp.MongoDB.Volo.Abp.Domain.Repositories.MongoDB
{
    public interface IMongoDbBulkOperationProvider
    {
        Task InsertManyAsync<TEntity>(
           IMongoDbRepository<TEntity> repository,
           IEnumerable<TEntity> entities,
           bool autoSave,
           CancellationToken cancellationToken
       )
           where TEntity : class, IEntity;


        Task UpdateManyAsync<TDbContext, TEntity>(
            IMongoDbRepository<TEntity> repository,
            IEnumerable<TEntity> entities,
            bool autoSave,
            CancellationToken cancellationToken
        )
            where TEntity : class, IEntity;


        Task DeleteManyAsync<TDbContext, TEntity>(
            IMongoDbRepository<TEntity> repository,
            IEnumerable<TEntity> entities,
            bool autoSave,
            CancellationToken cancellationToken
        )
            where TEntity : class, IEntity;
    }
}
