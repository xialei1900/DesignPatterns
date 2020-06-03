namespace Observer
{
    public interface IObserver
    {
        void Update(IPublisher publisher);

        //void OnClick(IButton button);
    }
}