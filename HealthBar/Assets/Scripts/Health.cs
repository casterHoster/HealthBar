using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    private float _maxValue;
    private float _currentValue;

    public float MaxValue { get => _maxValue; }
    public float CurrentValue { get => _currentValue; }

    public event UnityAction<float, float> ChangedCount;

    public void IncreaseValue(float value)
    {
        _currentValue += value;

        if (_currentValue > _maxValue)
        {
            _currentValue = _maxValue;
        }

        ChangedCount?.Invoke(_currentValue, _maxValue);
    }

    public void DecreaseValue(float value)
    {
        _currentValue -= value;

        if (_currentValue < 0)
        {
            _currentValue = 0;
        }

        ChangedCount?.Invoke(_currentValue, _maxValue);
    }
}

