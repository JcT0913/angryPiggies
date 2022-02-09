using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform piggie;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 17.2 && transform.position.x >= -13.5)
        {
            //transform.position = new Vector3(piggie.position.x, transform.position.y, transform.position.z);
            Vector3 newPositionOfCamera = new Vector3(piggie.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPositionOfCamera, Time.deltaTime * 3f);
        }


        
    }
}
