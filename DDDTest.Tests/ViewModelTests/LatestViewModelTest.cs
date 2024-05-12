using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DDD.WinForm.ViewModels;
using DDD.Domain.Entities;
using Moq;
using DDD.Domain.Repositories;

namespace DDDTest.Tests.ViewModelTests
{
    [TestClass]
    public class LatestViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var entity = new MeasureEntity(
                1,
                Convert.ToDateTime("2022/12/12 12:34:56"),
                12.34f);
            var measureMoq = new Mock<IMeasureRepository>();
            measureMoq.Setup(x => x.GetLatest()).Returns(entity);
            var vm = new LatestViewModel(measureMoq.Object);
            vm.Search();

            vm.AreaIdText.Is("0001");
            vm.MeasureDateText.Is("2022/12/12 12:34:56");
            vm.MeasureValueText.Is("12.34°C");
        }
    }
}
