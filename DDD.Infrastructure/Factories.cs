using DDD.Domain;
using DDD.Domain.Repositories;
using DDD.Infrastructure.Fake;
using DDD.Infrastructure.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure
{
    public static class Factories
    {
        public static IMeasureRepository CreateMeasure()
        {
#if DEBUG
            if (Shared.IsFake)
            {
                return new MeasureFake();
            }
#endif

            return new MeasureSqlServer();
        }
    }
}
