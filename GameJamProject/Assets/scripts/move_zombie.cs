using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_zombie : MonoBehaviour
{
    public GameObject player;
    public float blocksize = 48f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            player.transform.position -= transform.position + new Vector3(0, blocksize, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.transform.position += transform.position + new Vector3(0, blocksize, 0);
        }
    }
}
