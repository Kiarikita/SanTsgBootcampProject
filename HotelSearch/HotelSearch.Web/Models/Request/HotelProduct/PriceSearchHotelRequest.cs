using System.Collections.Generic;

namespace HotelSearch.Web.Models.Request.HotelProduct
{
    public class PriceSearchHotelRequest
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class ArrivalLocation
        {
            public string id { get; set; }
            public int type { get; set; } = 2;
        }

        public class RoomCriterion
        {
            public int adult { get; set; } = 1;
            public List<int> childAges { get; set; }=new List<int>();
        }

        public class Root
        {
            public bool checkAllotment { get; set; } = true;
            public bool checkStopSale { get; set; } = true;
            public bool getOnlyDiscountedPrice { get; set; } = false;
            public bool getOnlyBestOffers { get; set; } = true;
            public int productType { get; set; } = 2;
            public List<ArrivalLocation> arrivalLocations { get; set; }=new List<ArrivalLocation>()
            {
                new ArrivalLocation()
            };
            public List<RoomCriterion> roomCriteria { get; set; }=new List<RoomCriterion>()
            {
                new RoomCriterion()
            };
            public string nationality { get; set; } = "DE";
            public string checkIn { get; set; }="2022-10-17";
            public int night { get; set; } = 7;
            public string currency { get; set; } = "EUR";
            public string culture { get; set; } = "en-US";
        }


    }
}
