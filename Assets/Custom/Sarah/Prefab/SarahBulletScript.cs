using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SarahBulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.localScale = new Vector2(Mathf.Sin(Time.time*5) , Mathf.Sin(Time.time * 5));
        transform.position += new Vector3(0, 1);
    }
}
