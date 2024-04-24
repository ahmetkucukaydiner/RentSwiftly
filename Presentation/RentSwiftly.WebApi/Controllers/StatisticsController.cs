using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentSwiftly.Application.Features.Mediator.Queries.StatisticsQueries;

namespace RentSwiftly.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCarCount")]
        public IActionResult GetCarCount()
        {
            var value = _mediator.Send(new GetCarCountQuery());
            return Ok(value);
        }

        [HttpGet("GetLocationCount")]
        public IActionResult GetLocationCount()
        {
            var value = _mediator.Send(new GetLocationCountQuery());
            return Ok(value);
        }

        [HttpGet("GetAuthorCount")]
        public IActionResult GetAuthorCount()
        {
            var value = _mediator.Send(new GetAuthorCountQuery());
            return Ok(value);
        }

        [HttpGet("GetBlogCount")]
        public IActionResult GetBlogCount()
        {
            var value = _mediator.Send(new GetBlogCountQuery());
            return Ok(value);
        }

        [HttpGet("GetBrandCount")]
        public IActionResult GetBrandCount()
        {
            var value = _mediator.Send(new GetBrandCountQuery());
            return Ok(value);
        }

        [HttpGet("GetAverageRentPriceForDaily")]
        public IActionResult GetAverageRentPriceForDaily()
        {
            var value = _mediator.Send(new GetAverageRentPriceForDailyQuery());
            return Ok(value);
        }

        [HttpGet("GetAverageRentPriceForWeekly")]
        public IActionResult GetAverageRentPriceForWeekly()
        {
            var value = _mediator.Send(new GetAverageRentPriceForWeeklyQuery());
            return Ok(value);
        }

        [HttpGet("GetAverageRentPriceForMonthly")]
        public IActionResult GetAverageRentPriceForMonthly()
        {
            var value = _mediator.Send(new GetAverageRentPriceForMonthlyQuery());
            return Ok(value);
        }

        [HttpGet("GetCarCountByTransmissionIsAuto")]
        public IActionResult GetCarCountByTransmissionIsAuto()
        {
            var value = _mediator.Send(new GetCarCountByTransmissionIsAutoQuery());
            return Ok(value);
        }

        [HttpGet("GetBrandNameByMaxCar")]
        public IActionResult GetBrandNameByMaxCar()
        {
            var value = _mediator.Send(new GetBrandNameByMaxCarQuery());
            return Ok(value);
        }

        [HttpGet("GetBlogTitleByMaxBlogComment")]
        public IActionResult GetBlogTitleByMaxBlogComment()
        {
            var value = _mediator.Send(new GetBlogTitleByMaxBlogCommentQuery());
            return Ok(value);
        }

        [HttpGet("GetCarCountByKilometerLowerThan1000")]
        public IActionResult GetCarCountByKilometerLowerThan1000()
        {
            var value = _mediator.Send(new GetCarCountByKilometerLowerThan1000Query());
            return Ok(value);
        }

        [HttpGet("GetGetCarCountByFuelGasolineOrDieselCarCount")]
        public IActionResult GetCarCountByFuelGasolineOrDiesel()
        {
            var value = _mediator.Send(new GetCarCountByFuelGasolineOrDieselQuery());
            return Ok(value);
        }

        [HttpGet("GetCarCountByFuelElectric")]
        public IActionResult GetCarCountByFuelElectric()
        {
            var value = _mediator.Send(new GetCarCountByFuelElectricQuery());
            return Ok(value);
        }

        [HttpGet("GetCarBrandAndModelByRentPriceDailyMax")]
        public IActionResult GetCarBrandAndModelByRentPriceDailyMax()
        {
            var value = _mediator.Send(new GetCarBrandAndModelByRentPriceDailyMaxQuery());
            return Ok(value);
        }

        [HttpGet("GetCarBrandAndModelByRentPriceDailyMin")]
        public IActionResult GetCarBrandAndModelByRentPriceDailyMin()
        {
            var value = _mediator.Send(new GetCarBrandAndModelByRentPriceDailyMinQuery());
            return Ok(value);
        }
    }
}
