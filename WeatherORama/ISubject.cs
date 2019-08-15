
namespace WeatherORama
{
    public interface ISubject
    {
        void RegisterObserver(IObserverMember o);
        void RemoveObserver(IObserverMember o);
        void NotifyObservers();
    }
}
