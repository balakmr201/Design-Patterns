
using System;
using System.Collections.Generic;
public class Subject : ISubject
{
    private List<IObserver> observables = new List<IObserver>();
    private string ProductName { get; set; }
    private string ProductPrice { get; set; }
    private string Availablity { get; set; }

    public Subject(string productName, int productPrice, string availablity)
    {
        ProductName = productName;
        ProductPrice = productPrice;
        Availablity = availablity;
    }
    public string getAvailability()
    {
        return Availablity;
    }
    public string setAvailability(string availablity)
    {
        this.Availablity = availablity;
        Console.WriteLine("Available");
    }
    public void AddObserver(IObserver observer)
    {
        observables.Add(observer);
    }
      public void RemoveObserver(IObserver observer)
    {
        observables.Remove(observer);
    }
    public void NotifyObservers(){
        Console.WriteLine("Available" + ": Name:"+ProductName);
        Console.WriteLine("Product Price:"+ProductPrice);

        foreach(IObserver observer in observables){
            observer.update(Availablity);
        }
    }
}