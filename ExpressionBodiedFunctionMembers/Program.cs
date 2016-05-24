namespace ExpressionBodiedFunctionMembers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Point point = new Point(37, 77);
            Point point2 = point.Clone() as Point;

            point.Move(100, 100);

            point.Print();
            point2.Print();
        }
    }
}
