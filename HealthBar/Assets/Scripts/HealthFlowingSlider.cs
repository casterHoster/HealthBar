using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthFlowingSlider : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    private float _decreaseValue = 10;
    private float _increaseValue = 10;
    private float _value;
    private bool _isEnabled;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _maxHealth;
    }

    private void Start()
    {
        _value = _maxHealth;
        _slider.value = _maxHealth;
    }

    private void Update()
    {
        if (_isEnabled == false && _slider.value != _value) 
        {
            _isEnabled = true;
            StartCoroutine(FlowingChange());
        }
    }

    public void Increase()
    {
        _value += _increaseValue;

        if (_slider.value > _maxHealth)
        {
            _slider.value = _maxHealth;
        }
    }

    public void Decrease()
    {
        _value -= _decreaseValue;

        if (_slider.value < 0)
        {
            _slider.value = 0;
        }
    }

    private IEnumerator FlowingChange()
    {
        if (_slider.value > _value)
        {
            _slider.value += Time.deltaTime;
            yield return null;
        }

        else
        {
            _slider.value -= Time.deltaTime;
            yield return null;
        }

        _isEnabled = false;
    }
}
