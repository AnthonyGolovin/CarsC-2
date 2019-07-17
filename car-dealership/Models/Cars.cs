
using System;

namespace Dealership.Models
{
  class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _drivesLike;

    public Car(string makeModel, int price, int miles, string drivesLike)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _drivesLike = drivesLike;
    }

    public string GetMakeModel()
    {
        return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }
    public string GetDrivesLike()
    {
      return _drivesLike;
    }
    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
     public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public static string MakeSound (string sound)
    {
      return "our cars sound like " + sound;
    }
  }
}