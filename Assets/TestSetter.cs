using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestSetter : MonoBehaviour
{
    public TMP_Text text;
    public IntValue value;
    // Start is called before the first frame update
    void Start()
    {
        text.text = value.GetValue().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
