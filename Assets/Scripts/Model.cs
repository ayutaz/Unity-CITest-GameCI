using System;
using UniRx;
using UnityEngine;

public class Model : MonoBehaviour
{
    private int _counter = 0;

    private readonly Subject<int> _onCounterChangedSubject = new Subject<int>();
    public IObservable<int> OnCounterChangedAsObservable() => _onCounterChangedSubject;

    public void Increment()
    {
        _onCounterChangedSubject.OnNext(++_counter);
    }
}