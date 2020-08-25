using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    public float destroyDistance = 40.0f;
    private float destroyAnimal = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > destroyDistance)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < destroyAnimal)
        {
            Destroy(gameObject);
            Debug.Log("gameover");
        }
    }
}
