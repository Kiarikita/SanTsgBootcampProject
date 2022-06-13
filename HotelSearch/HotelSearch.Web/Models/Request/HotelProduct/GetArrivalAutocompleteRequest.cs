namespace HotelSearch.Web.Models.Request.HotelProduct
{
    public class GetArrivalAutocompleteRequest
    {
        public int ProductType { get; set; } = 2;
        public string Query { get; set; } = "anta";
        public string Culture { get; set; } = "en-US";

    }
}
