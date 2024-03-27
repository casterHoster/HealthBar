using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    private Health _health;

    [SerializeField] private float _maxHealth;

    [SerializeField] private Button _increaseButton, _decreaseButton;
    [SerializeField] private float _increaseValue;
    [SerializeField] private float _decreaseValue;
    [SerializeField] private List<HealthView> _healthViews = new List<HealthView>();

    private void Start()
    { 
        _health = new Health(_maxHealth);

        foreach (var healthView in _healthViews)
        {
            healthView.BuildHealthBar(_health);
        }

        _increaseButton.onClick.AddListener(Increase);
        _decreaseButton.onClick.AddListener(Decrease);
    }

    private void Increase()
    {
        _health.IncreaseValue(_increaseValue);
    }

    private void Decrease()
    {
        _health.DecreaseValue(_decreaseValue);
    }
}
