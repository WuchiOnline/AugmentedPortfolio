using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_TapButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToRandomColor()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Random.ColorHSV();
    }
}
