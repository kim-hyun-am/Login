using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PubilcNetwork : MonoBehaviour
{
    public UILabel stLabel;
    private string stText;
    // Start is called before the first frame update
    void Start()
    {
        stText = stLabel.text;
        Debug.Log(stText);
        stText.Substring(0,10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
