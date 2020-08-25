using UnityEngine;

public class rotateChik : MonoBehaviour
{

    public float rotateSpeed = 15.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
