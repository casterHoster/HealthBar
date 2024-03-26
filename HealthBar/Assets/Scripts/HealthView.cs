using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    public void Construct(Health health)
    {
        health.ChangedCount += DrawHealthValue;
    }

    protected abstract void DrawHealthValue(float currentValue, float maxValue);
}
