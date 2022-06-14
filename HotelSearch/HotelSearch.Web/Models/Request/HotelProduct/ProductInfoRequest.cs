namespace HotelSearch.Web.Models.Request
{
    public class ProductInfoRequest
    {
        public class Root
        {
            public int productType { get; set; }
            public int ownerProvider { get; set; }
            public string product { get; set; }
            public string culture { get; set; }
        }
    }
}
