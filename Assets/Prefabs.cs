using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{

    public GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObjects()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            Instantiate(objects[i], new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }

}
