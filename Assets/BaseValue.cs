using UnityEngine;

public abstract class BaseValue : ScriptableObject
{
    protected int Value = 0;
    public int GetValue()
    {
        return Value;
    }
}