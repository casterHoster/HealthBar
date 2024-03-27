using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSlider : HealthView
{
    private Slider _slider;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    protected override void DrawHealthValue(float currentValue, float maxValue)
    {
        _slider.value = currentValue;
        _slider.maxValue = maxValue;
    }
}
