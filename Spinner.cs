using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float Spinnerx = 0;
    [SerializeField] float Spinnery = 1;
    [SerializeField] float Spinnerz = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Spinnerx,Spinnery, Spinnerz);
    }
}
