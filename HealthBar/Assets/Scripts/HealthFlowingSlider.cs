using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthFlowingSlider : HealthView
{
    private Slider _slider;
    private Coroutine _coroutine;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    private IEnumerator FlowCurrentDraw(float currentValue)
    {
        while (_slider.value != currentValue)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, currentValue, Time.deltaTime * 10);
            yield return null;
        }
    }

    protected override void DrawHealthValue(float currentValue, float maxValue)
    {
        _slider.maxValue = maxValue;
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        if (currentValue < maxValue)
        {
        _coroutine = StartCoroutine(FlowCurrentDraw(currentValue));
        }
        else
        {
         _slider.value = maxValue;
        }
    }
}
