﻿using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Repositories
{
    public sealed class MeasureRepository
    {
        private IMeasureRepository _repository;

        public MeasureRepository(IMeasureRepository repository)
        {
            _repository = repository;
        }

        public MeasureEntity GetLatest()
        {
            var val1 = _repository.GetLatest();
            System.Threading.Thread.Sleep(1000);
            var val2 = _repository.GetLatest();
            System.Threading.Thread.Sleep(1000);
            var val3 = _repository.GetLatest();
            System.Threading.Thread.Sleep(1000);

            var val = (val1.MeasureValue.Value + val2.MeasureValue.Value + val3.MeasureValue.Value)
                / 3;

            return new MeasureEntity(val3.AreaId.Value, val3.MeasureDate.Value, val);
        }
    }
}
