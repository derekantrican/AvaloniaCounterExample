using AvaloniaCounterExample.Models;

namespace AvaloniaCounterExample.ViewModels
{
    public class CounterViewModel : BaseViewModel
    {
        private Counter counterModel;

        public CounterViewModel()
        {
            //This is where you would load from a DB (or, better yet, call an async method to load from the DB). For now, we'll just create a new instance
            counterModel = new Counter();
        }

        public int Count
        {
            get
            {
                return counterModel.Count;
            }
            set
            {
                counterModel.Count = value;
                FirePropertyChanged();
            }
        }

        public void Increment()
        {
            Count++;
        }

        public void Reset()
        {
            Count = 0;
        }
    }
}
