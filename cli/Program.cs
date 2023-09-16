// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using integration.service;


var integration= new IntegrationService();
decimal result = integration.IntegrateBetween((decimal)0.00001, 0, (decimal)(Math.PI * 2), f);
Console.WriteLine($"Approximate integral: {result}");

decimal f(decimal x){
    decimal y = (decimal)Math.Sin((double)x) * (decimal)Math.Exp((double)(x)) * (decimal)Math.Log((double)(x + 2)) * (decimal)Math.Cos((double)(x*x)) * (decimal)Math.Tan((double)(x/2)) * (decimal)Math.Sqrt((double)x);
    return y;
}

decimal g(decimal x)
{
    decimal y = x * x * x * (decimal)Math.Pow(Math.E,(double)x);
    return y;
}