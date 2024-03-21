﻿internal class Program
{
    private static void Main(string[] args)
    {
        SimpleDataBase<float> data = new SimpleDataBase<float>();
        data.AddNewData((float)1.3);
        data.AddNewData((float)0.2);
        data.AddNewData((float)2.2);

        data.PrintAllData();
    }
}

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        this.storedData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < this.storedData.Count; i++) { 
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] +
                ", yang disimpan pada waktu UTC: " + this.inputDates[i]);
        }
    }


}