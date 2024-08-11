class Car
{
    //fields
    public string _brand;
    public string _model;
    public string _color;
    private int _dourNum;

    //properties
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    private int DourNum
    {
        get
        {
            return _dourNum;
        }
        set
        {
            if (value != 2 || value != 4)
            {
                Console.WriteLine("Yanlış bir değer girildi...");
                _dourNum = -1;
            }
            else
            {
                _dourNum = value;
            }
        }
    }
}