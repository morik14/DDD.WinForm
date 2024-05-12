using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Domain.Entities;

namespace DDD.Domain.Repositories
{
    public interface IMeasureRepository
    {
        MeasureEntity GetLatest();
    }
}
