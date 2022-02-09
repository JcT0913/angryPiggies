using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreDisplay : MonoBehaviour
{
    public scoreCounter score;
    Text displayContent;

    // Start is called before the first frame update
    void Start()
    {
        displayContent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        displayContent.text = "Player Score: " + score.scoreCount;
    }
}
