using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSlider : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    private float _decreaseValue = 10;
    private float _increaseValue = 10;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _maxHealth;
    }

    private void Start()
    {
        _slider.value = _maxHealth;
    }
    public void Increase()
    {
        _slider.value += _increaseValue;

        if (_slider.value > _maxHealth)
        {
            _slider.value = _maxHealth;
        }
    }

    public void Decrease()
    {
        _slider.value -= _decreaseValue;

        if (_slider.value < 0)
        {
            _slider.value = 0;
        }
    }
}
