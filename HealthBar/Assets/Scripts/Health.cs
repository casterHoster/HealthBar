using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
   [SerializeField] private float _decreaseValue;
   [SerializeField] private float _increaseValue;

    public event UnityAction<float> ChangeCount;

    public void Increase()
    {
        ChangeCount?.Invoke(_increaseValue);
    }

    public void Decrease()
    {
        ChangeCount?.Invoke(_decreaseValue);
    }
}
