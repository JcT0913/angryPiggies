using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beDestroyed : MonoBehaviour
{
    public scoreCounter score;
    public float scorePerObject = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Be Destroyed");
        if (collision.gameObject.tag == "Piggie")
        {
            Destroy(gameObject);
            score.scoreCount += scorePerObject;
        }
    }
}
