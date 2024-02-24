namespace ex7;

public class Meth
{
    private double _pi=3.14;
    private double _e=2.71;
    public double Abs(double value)
    {
        double res=0;
        if(value>0)
        {
            res=value*(-1);
        }
        else if(value<0)
        {
            res=value*(-1);
        }
        return res;
    }
    public float Abs(float value)
    {
        float res=0;
        if(value>0)
        {
            res=value*(-1);
        }
        else if(value<0)
        {
            res=value*(-1);
        }
        return res;
    } 
    public int Abs(int value)
    {
        int res=0;
        if(value>0)
        {
            res=value*(-1);
        }
        else if(value<0)
        {
            res=value*(-1);
        }
        return res;
    } 
    public double Pow(double x,double y)
    {
        return Math.Pow(x,y);
    }
    public double Sqrt(int d)
    {
        double res=0;
        for (int i = 1; i <=d; i++)
        {
            if(i*i==d)
            {
                res=i;
            }
        }
            return res;
    }
    public int Max(int val1, int val2)
    {
        int res=0;
        if(val1>val2)
        {
            res=val1;
        }
        else
        {
            res=val2;
        }
        return res;
    }
    public int Min(int val1, int val2)
    {
        int res=0;
        if(val1<val2)
        {
            res=val1;
        }
        else
        {
            res=val2;
        }
        return res;
    }
}