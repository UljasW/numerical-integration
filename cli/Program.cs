﻿// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using integration.service;


var interator = new IntegrationService();
decimal result = interator.IntegrateBetween((decimal)0.01,-2,2,f);
Console.WriteLine($"Approximate integral: {result}");
decimal f(decimal x){
    decimal y = 5*x*(decimal)Math.Sin((double)x);
    return y;
}