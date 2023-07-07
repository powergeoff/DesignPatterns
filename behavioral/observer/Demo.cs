using Behavioral.Observer.Book;

namespace Behavioral.Observer;

public static class ObserverDemo{
    public static void Run(){
        //do stuff
        
        /*var data = new DataSource();
        var spreadSheet = new Observer.PullStyle.SpreadSheet(data);
        var chart = new Observer.PullStyle.Chart(data);
        data.AddObserver(spreadSheet);
        data.AddObserver(chart);

        data.SetValue(10);
        */

        /* var stock1 = new Stock("GAO");
        var stock2 = new Stock("TJO");
        var stock3 = new Stock("CEB");
        var stock4 = new Stock("RBO");

        var data = new StockList();
        data.AddStock(stock1);
        stock1.AddObserver(data);
        data.AddStock(stock2);
        stock2.AddObserver(data);
        
        stock3.SetPrice(10);
        stock2.SetPrice(100); */

        var weatherData = new WeatherData();
        var currentConditions = new CurrentConditionsDisplay(weatherData);
        var heatIndex = new HeatIndexDisplay(weatherData);

        weatherData.SetMeasurements(80, 90, 3);
    }
}