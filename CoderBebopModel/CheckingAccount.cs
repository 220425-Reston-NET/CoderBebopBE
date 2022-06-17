using System.ComponentModel.DataAnnotations;

namespace CoderBebopModel
{
    public class CheckingAccount
    {
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
        public Double CAccBalance { get; set; }
        public String CAccHistory { get; set; }
    }
}