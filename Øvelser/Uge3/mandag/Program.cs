namespace Uge3;
using System;

public class Program
{
    delegate bool isPrime(int num);
    
    public static bool IsPrime(int num)
    {
        return false;
    }
    public class DataConsumer
    {
        public void NotifyMeAboutChange2()
        {
            Console.WriteLine(temp);
        }
        public string name;
        public DataConsumer(string n=name);
        public void NotifyMe(object sender, int temp)
        {
            Console.WriteLine("New temp reading: {0}", temp);
        }
    }
    public class DataProducer
    {
        ///<see cref="Temperature"\>
        public event TemperatureEvent TemperatureChange;
        protected void OnTemperatureChange(int temp)
        {
            if(TemperatureChange!=null)
                TemperatureChange(this, temp);

        }
        public void NewTempMeasurement(int temp)
        {
            if(temp>10)
        }
        DataConsumer data;
        public void NotifyConsumer()
        {
            data.NotifyConsumer;
        }
    }
    public static void Main(string[] args)
    {
        
        //isPrime func= new isPrime(IsPrime);
        //Console.WriteLine(func(10));
        DataProducer dp= new DataProducer();
        DataConsumer dc1= new DataConsumer("Consumer 1");
        DataConsumer dc2= new DataConsumer("Consumer 2");

        dp.TemperatureChange+= new TemperatureEvent(dc1.NotifyMe);
        dp.TemperatureChange+= new TemperatureEvent(dc2.NotifyMe);
        dp.NewTempMeasurement(12);
    }
}