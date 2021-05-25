using System;
using UniRx;

namespace Interface
{
    public interface IButtonView
    {
        IObservable<Unit> OnTriggerAsObservable();
    }
}