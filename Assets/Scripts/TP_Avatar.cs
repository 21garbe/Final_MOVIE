using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_Avatar : MonoBehaviour
{
    public GameObject Camera;
    public Transform avatar_transform;
    public void TP_avatar()
    {
        Vector3 Offset = new Vector3(0.0f, avatar_transform.position[1], 0.0f);
        Vector3 camera_pos = Camera.GetComponent<Transform>().position;
        camera_pos[1] = avatar_transform.position[1];
        this.transform.SetPositionAndRotation(camera_pos, Camera.GetComponent<Transform>().rotation);
        Debug.Log(Camera.GetComponent<Transform>());
        Debug.Log(this.GetComponent<Transform>());
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
