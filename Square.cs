public class Square
{
    public int Number { get; set; }
    public int Sqr { get; set; }
    public Square(int num)
    {
        Number = num;
        Sqr = num * num;
    }
}