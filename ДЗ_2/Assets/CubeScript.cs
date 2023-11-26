using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private bool counter = true;
    void Start()
    {
        onClick1();
    }

    void Update()
    {
        
    }
    public void onClick1()
    {
        gameObject.SetActive(counter);
        counter = !counter;
    }
}
