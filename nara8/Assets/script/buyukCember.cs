using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyukCember : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0,0,speed*Time.deltaTime);
    }
}
