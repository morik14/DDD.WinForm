using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Infrastructure;
using System;

namespace DDD.WinForm.ViewModels
{
    public class LatestViewModel : ViewModelBase
    {
        // private IMeasureRepository _measureRepository;
        private MeasureRepository _measureRepository;

        private string _areaIdText = string.Empty;
        private string _measureDateText = string.Empty;
        private string _measureValueText = string.Empty;

        public LatestViewModel() : this(Factories.CreateMeasure())
        {

        }

        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = new MeasureRepository(measureRepository);
        }

        public string AreaIdText
        {
            get
            {
                return _areaIdText;
            }
            set
            {
                SetProperty(ref _areaIdText, value);
            }
        }
        public string MeasureDateText
        {
            get
            {
                return _measureDateText;
            }
            set
            {
                SetProperty(ref _measureDateText, value);
            }
        }
        public string MeasureValueText
        {
            get
            {
                return _measureValueText;
            }
            set
            {
                SetProperty(ref _measureValueText, value);
            }
        }

        public void Search()
        {
            var measureEntity = _measureRepository.GetLatest();
            AreaIdText = measureEntity.AreaId.DisplayValue;
            MeasureDateText = measureEntity.MeasureDate.DisplayValue;
            MeasureValueText = measureEntity.MeasureValue.DisplayValue;
        }
    }
}
