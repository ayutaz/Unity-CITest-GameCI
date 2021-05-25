using Interface;
using UniRx;
using UnityEngine;

public class Presenter : MonoBehaviour
{
    [SerializeField] private TextView textView;
    [SerializeField] private ButtonView buttonView;

    [SerializeField] private Model model;

    private IModel _model;

    private ITextView _textView;

    private IButtonView _buttonView;
    // Start is called before the first frame update
    private void Start()
    {
        _model = model;
        _textView = textView;
        _buttonView = buttonView;
        
        _buttonView.OnTriggerAsObservable().Subscribe(_ => _model.Increment());
        _model.OnCounterChangedAsObservable().Subscribe(count => _textView.SetText(count.ToString()));
    }
    
}
