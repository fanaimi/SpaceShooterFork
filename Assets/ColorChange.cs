using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color startColor;
    public Color endColor;
    // Start is called before the first frame update
    void Start()
    {
        Color.Lerp(startColor, endColor, 3);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnEnable()
    {
        Color.Lerp(startColor, endColor, 3 * Time.deltaTime);
    }
}
