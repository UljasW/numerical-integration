namespace integration.service;
public class IntegrationService
{
    public float IntegrateBetween(float accuracy ,float a, float b, Func<float, float> f){

        float sum = 0;

        for (float i = a; i < b; i += accuracy)
        {
            sum += findG(i,accuracy,f);
        }

        return 0;
    }

    private float findG(float i, float accuracy, Func<float, float> f){

        float x1 = i;
        float x2 = i+(accuracy/2);
        float x3 = i+accuracy;


        float y1 = f(x1);
        float y2 = f(x2);
        float y3 = f(x3);


        float c (float a, float b){
           return (y1-a*x1*x1)/(b+1);
        }





        //a=(bc+c)/x^2
        //b=((-ax^2-c)/c)
        //c=((y-ax^2)/(b+1))






        return 0;

    }
    
}
