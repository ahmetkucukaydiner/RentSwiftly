namespace RentSwiftly.Application.Features.Mediator.Results.CarDescriptionResults
{
	public class GetCarDescriptionByIdQueryResult
	{
		public int CarDescriptionID { get; set; }
		public int CarID { get; set; }
		public string Details { get; set; }
	}
}