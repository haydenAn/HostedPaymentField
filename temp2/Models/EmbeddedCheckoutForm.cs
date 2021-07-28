using System;

namespace temp2.Models
{
    public class EmbeddedCheckoutFormModel
    {
        public EmbeddedCheckoutFormModel(string _token, string _amount, string _currency,ShopperData _shopperData){
            token = _token;
            amount = _amount;
            currency = _currency ;
            shopperData = _shopperData;
        }
        public string token { get; set; }
        public string amount { get; set; }
        public ShopperData shopperData { get; set; }
        public string currency { get; set; }

        // preset values
        public string title { get; set; } = "BlueSnap Example";
        public string Description { get; set; } = "This is description for example...";
        public string img { get; set; } = "/developers/571747/download.jpg";
        public string buttonLabel { get; set; } = "Click to Purchase";
        public bool billingDetails { get; set; } = true;
        public bool includeEmail { get; set; } = true;
        public string language { get; set; } = "ËN";
    }
    public class ShopperData{
       public ShopperData(string fname,string lname){
           firstname = fname;
           lastname = lname;
       }
     public string firstname { get; set; }
     public string lastname { get; set; }
    }
}
