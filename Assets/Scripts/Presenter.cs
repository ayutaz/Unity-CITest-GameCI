using Interface;
using UniRx;
using VContainer.Unity;

public class Presenter : IStartable
{
    private readonly IModel _model;

    private readonly ITextView _textView;

    private readonly IButtonView _buttonView;

    private Presenter(IModel model, ITextView textView, IButtonView buttonView)
    {
        _model = model;
        _textView = textView;
        _buttonView = buttonView;
    }
    // Start is called before the first frame update
    void IStartable.Start()
    {
        _buttonView.OnTriggerAsObservable().Subscribe(_ => _model.Increment());
        _model.OnCounterChangedAsObservable().Subscribe(count => _textView.SetText(count.ToString()));
    }
    
}
