using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    private Text _text;
    private float _currentHealth;
    private float _decreaseValue = 10;
    private float _increaseValue = 10;

    private void Awake()
    {
        _text = GetComponent<Text>();
        _currentHealth = _maxHealth;
    }

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    private void Update()
    {
        _text.text = $"{_currentHealth} / {_maxHealth}";
    }

    public void Increase()
    {
        _currentHealth += _increaseValue;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }

    public void Decrease()
    {
        _currentHealth -= _decreaseValue;

        if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }
    }
}
