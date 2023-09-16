// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using integration.service;


IntegrationService interator = new IntegrationService();


decimal result = interator.IntegrateBetween((decimal)0.1,2,5,f);
Console.WriteLine($"Approximate integral: {result}");
decimal f(decimal x){
    decimal y = x*10;
    return y;
}