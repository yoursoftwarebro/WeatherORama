
namespace WeatherORama
{
    public interface IObserverMember
    {
        void Update(double temp, double humidity, double pressure);
    }
}
