// See https://aka.ms/new-console-template for more information
class Car
{
    private String CustomerName;
    private int balance;

    public Car()
    {
        this.CustomerName = "Nguyen Van A";
        this.balance = 100000;
    }
    public Car(string customerName, int balance)
    {
        this.CustomerName = customerName;
        this.balance = balance;
    }

    public String customername
    {
        set { this.CustomerName = value; }
        get { return this.CustomerName; }
    }

    public int customerbalance
    {
        set { this.balance = value; }
        get { return this.balance; }
    }

    public void Debit (int value)
    {
        this.balance = this.balance - value;
    }

    public void Credit (int value)
    {
        this.balance = this.balance + value;
    }

    //public String balance{ get; set; }
    //public String CustomerName{ get; set; }
    //public int Year { get; set; }
    //public string color { get; set; }
}