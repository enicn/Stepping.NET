﻿using Stepping.Core;

namespace Stepping.DbProviders.MongoDb;

public class MongoDbInitializingInfoModel : IDbInitializingInfoModel
{
    public ISteppingDbContext DbContext { get; }

    public MongoDbInitializingInfoModel(MongoDbSteppingDbContext dbContext)
    {
        DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }
}