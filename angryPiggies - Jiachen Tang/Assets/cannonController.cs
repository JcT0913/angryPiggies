using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonController : MonoBehaviour
{
    public Rigidbody2D piggyRigidbody;
    public float power = 100;
    public float maxAngle = 80;
    public float minAngle = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // give piggy a force to shoot according to mouse
        Vector3 mouseOnScreen = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
        Vector3 mouseInWorld = Camera.main.ScreenToWorldPoint(mouseOnScreen);
        Vector3 direction3D = mouseInWorld - transform.position;

        // calculate the angle in which cannon will rotate according to mouse
        // to get the angle between direction of mouse and that of cannon
        float dotProduct = Vector2.Dot(Vector2.right, new Vector2(direction3D.x, direction3D.y).normalized);
        // Rad2Deg -> Rad to Degree
        float angle = Mathf.Acos(dotProduct) * Mathf.Rad2Deg;

        if ((mouseInWorld.y - transform.position.y) > 0 && angle >= minAngle && angle <= maxAngle)
        {
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            piggyRigidbody.transform.parent = null;
            piggyRigidbody.gravityScale = 1.0f;
            piggyRigidbody.AddForce(direction3D * power);
        }
    }
}
