using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactuar : MonoBehaviour
{


    public float incremento = 1.0f;

    public float velocidad = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        transform.Translate(0, incremento*velocidad*Time.deltaTime, 0);
    }

    private void Algo()
    {

    }
}
