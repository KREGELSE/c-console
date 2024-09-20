
class GetSet
{
    private string _model;

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }


}

class Person
{
    Private string _name;

    public string Name
    {
        get{ return _name; }
        set
        {
            If(!string.IsNullOrEmpty(value))
            {
                _name = value;
            }

        }
    }
}

class Short
{
    public string Cut { get; set; }
}

class BankAccount
{
    private decimal _balance;

    public decimal Balance
    {
        get{ return _balance; }
        set{ 
            if(value >= 0)
            {
                _balance = value;
            }
        }
    }
}