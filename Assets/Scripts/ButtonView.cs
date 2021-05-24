using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    [SerializeField]
    private Button mvrpSampleButton;

    private readonly Subject<Unit> _onTriggerSubject = new Subject<Unit>();
    public IObservable<Unit> OnTriggerAsObservable() => _onTriggerSubject;

    private void Awake()
    {
        mvrpSampleButton.OnClickAsObservable()
            .Subscribe(_ => _onTriggerSubject.OnNext(Unit.Default))
            .AddTo(this);
    }
}
