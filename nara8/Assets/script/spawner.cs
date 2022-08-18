using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject ignePrefabs;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            igneSpawner();

        }
    }
    void igneSpawner()
    {
        Instantiate(ignePrefabs,transform.position,transform.rotation);//surekli igne olusturmus oluyor
    }
}
