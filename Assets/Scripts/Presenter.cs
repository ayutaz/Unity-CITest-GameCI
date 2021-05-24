using UniRx;
using UnityEngine;

public class Presenter : MonoBehaviour
{
    [SerializeField] private TextView textView;
    [SerializeField] private ButtonView buttonView;

    [SerializeField] private Model model;
    // Start is called before the first frame update
    private void Start()
    {
        buttonView.OnTriggerAsObservable().Subscribe(_ => model.Increment());
        model.OnCounterChangedAsObservable().Subscribe(count => textView.SetText(count.ToString()));
    }
    
}
