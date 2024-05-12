using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.SqlServer
{
    internal sealed class MeasureSqlServer : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            throw new NotImplementedException();
        }
    }
}
