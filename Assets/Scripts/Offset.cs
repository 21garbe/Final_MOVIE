using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offset : MonoBehaviour
{
    public GameObject Camera;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            Vector3 position = Camera.GetComponent<Transform>().position;
            Debug.Log(position);
            this.transform.SetPositionAndRotation(-position + offset, this.transform.rotation);

        }

    }
}
