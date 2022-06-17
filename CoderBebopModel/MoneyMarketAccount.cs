using System.ComponentModel.DataAnnotations;

namespace CoderBebopModel
{
    public class MoneyMarketAccount
    {
        private int _maccId;
        public int MAccID { 
            get {return _maccId;}
            set
            {
                if (value > 0)
                {
                    _maccId = value;
                }
                else
                {
                    throw new ValidationException("ID is invalid. Must be above 0.");
                }
            }
        }

        public String MAccType { get; set; }
        public Decimal MAccNumber { get; set; }
        public Double MAccBalance { get; set; }
        public String MAccHistory { get; set; }
    }
}