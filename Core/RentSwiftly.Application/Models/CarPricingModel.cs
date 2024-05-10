namespace RentSwiftly.Application.Models
{
	public class CarPricingModel
	{
		public CarPricingModel()
		{
			Amounts = new List<decimal>();
		}
		public string Model { get; set; }
		public List<decimal> Amounts { get; set; }
		public string BrandName { get; set; }
		public string CoverImageUrl { get; set; }
	}
}
