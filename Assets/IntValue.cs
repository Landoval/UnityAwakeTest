
using UnityEngine;

[CreateAssetMenu(menuName = "TestValue")]

public class IntValue : BaseValue
{
    private void Awake()
    {
        Value = 15;
    }
}