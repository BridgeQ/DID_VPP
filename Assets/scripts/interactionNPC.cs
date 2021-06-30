using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionNPC : MonoBehaviour
{
    public bool talks;

    public GameObject player;
    public string message;
    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log(message);
    }
 
}
