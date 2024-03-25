using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthView : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;

    }

    private void ChangeValue(float value)
    {
        _currentHealth += value;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }

        if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }
    }


}
