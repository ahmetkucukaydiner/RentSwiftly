namespace RentSwiftly.Dto.CarPricingDtos
{
	public class ResultCarPricingListWithModelDto
	{
		public string BrandName { get; set; }
		public string Model { get; set; }
		public string CoverImageUrl { get; set; }
		public decimal DailyAmount { get; set; }
		public decimal WeeklyAmount { get; set; }
		public decimal MonthlyAmount { get; set; }
	}
}
