using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public sealed class MeasureValue : ValueObject<MeasureValue>
    {
        public MeasureValue(float value)
        {
            Value = value;
        }

        public float Value { get; }

        public string DisplayValue => Math.Round(Value, 2) + "°C";

        protected override bool EqualsCore(MeasureValue other)
        {
            return this.Value == other.Value;
        }
    }
}
