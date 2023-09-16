// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using integration.service;


IntegrationService interator = new IntegrationService();


System.Console.WriteLine(interator.IntegrateBetween(0.05f,2,5,f));


float f(float x){
    float y = x;
    return y;
}