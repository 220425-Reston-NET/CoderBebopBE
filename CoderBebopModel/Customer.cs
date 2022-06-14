using System.ComponentModel.DataAnnotations;

namespace CoderBebopModel;
public class Customer
{
    private int _custId;

    public int CustID { 
        get {return _custId; }
        set {
            if (value > 0)
            {
                _custId = value;
            }
            else
            {
                throw new ValidationException("CustID is not valid");
            }
        } 
    }

    public string Name { get; set; }
    private string _phone { get; set; }

    public string Phone { 
        get {return _phone; }
        set {
            if (value.Length == 10)
            {
                _phone = value;
            }
            else
            {
                throw new ValidationException("Phone Number is not valid");
            }
        } 
    }

    public string Address { get; set; }

    public string _email { get; set; }





}
