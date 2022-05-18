  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    [SerializeField] private float m_Xspeed;
    [SerializeField] private float m_Yspeed;
    [SerializeField] RectTransform m_rect;
    private Vector3 m_originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        m_originalPosition = m_rect.position;
    }

    // Update is called once per frame
    void Update()
    {
        m_rect.position = new Vector3(
            m_rect.position.x + Mathf.Sin(Time.time*m_Xspeed) , 
            m_rect.position.y  + m_Yspeed * Time.deltaTime,
            -.5f);

    }
}
