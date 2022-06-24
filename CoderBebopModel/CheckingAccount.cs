using System.ComponentModel.DataAnnotations;

namespace CoderBebopModel
{
    public class CheckingAccount
    {

        public string cName{ get; set;}
        private int _caccId;
        public int CAccID { 
            get {return _caccId;}
            set
            {
                if (value > 0)
                {
                    _caccId = value;
                }
                else
                {
                    throw new ValidationException("ID is invalid. Must be above 0.");
                }
            }
        }

        public String CAccType { get; set; }
        public Decimal CAccNumber { get; set; }
        private decimal _CAccBalance;
        public decimal CAccBalance{
            get {return _CAccBalance;}
            set
            {
                if(value >= 0)
                {
                    _CAccBalance = value;
                }
                else{
                    throw new ValidationException("Your balance must be greater than 0");
                }
            }
        }
        public String CAccHistory { get; set; }
    }
}