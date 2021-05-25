using System;

namespace Interface
{
    public interface IModel
    {
        void Increment();
        IObservable<int> OnCounterChangedAsObservable();
    }
}