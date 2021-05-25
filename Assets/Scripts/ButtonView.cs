using System;
using Interface;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour,IButtonView
{
    [SerializeField]
    private Button button;

    private readonly Subject<Unit> _onTriggerSubject = new Subject<Unit>();
    public IObservable<Unit> OnTriggerAsObservable() => _onTriggerSubject;

    private void Awake()
    {
        button.OnClickAsObservable()
            .Subscribe(_ => _onTriggerSubject.OnNext(Unit.Default))
            .AddTo(this);
    }
}
