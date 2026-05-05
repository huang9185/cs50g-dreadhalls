using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMazeNumber : MonoBehaviour
{
    public static int mazeNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10,10,100,20), "Maze: " + mazeNumber);
    }
}
