namespace integration.service;

public class IntegrationService
{
    public decimal IntegrateBetween(decimal accuracy, decimal a, decimal b, Func<decimal, decimal> f)
    {
        decimal prevG = 0;

        decimal sum = 0;

        for (decimal i = a; i < b; i += accuracy)
        {
            sum += findG(i, accuracy, f, prevG);
            Console.WriteLine(sum);
            prevG = sum;
        }

        return sum;
    }

    private decimal findG(decimal i, decimal accuracy, Func<decimal, decimal> f, decimal prevG)
    {
        try
        {
            //Get three points
            decimal x1 = i;
            decimal x2 = i + (accuracy / 2);
            decimal x3 = i + accuracy;
            
            decimal y1 = f(x1);
            decimal y2 = f(x2);
            decimal y3 = f(x3);
            
            //calculate the coefficients in the parabolic function using substitution method
            decimal b = FindB(x1, y1, y2, x3, y3, x2);
            decimal a = (y3 - y1) / (x3 * x3 - x1 * x1 + (y1 - x1 * x1) / (b + 1));
            decimal c = (y1 - a * x1 * x1) / (b + 1);

            //integrate parabolic function between first and second point
            decimal g1 = a * x1 * x1 * x1 / 3 + b * x1 * c + c * x1;
            decimal g2 = a * x3 * x3 * x3 / 3 + b * x3 * c + c * x3;
            return g2 - g1;
        }
        catch (Exception e)
        {
            //if value is undefined return previous value
            return prevG;
        }
    }

    private decimal FindB(decimal x1, decimal y1, decimal y2, decimal x3, decimal y3, decimal x2)
    {
        decimal numerator = x1 * x1 * y1 + x2 * x2 * y1 - x3 * x3 * y1 - y1 * y1 - 2 * x1 * x1 * y2 + x3 * x3 * y2 +
            y1 * y2 + x1 * x1 * y3 - x2 * x2 * y3;
        decimal denominator =
            -(x2 * x2 * y1) + x3 * x3 * y1 + x1 * x1 * y2 - x3 * x3 * y2 - x1 * x1 * y3 + x2 * x2 * y3;
        return numerator / denominator;
    }
}