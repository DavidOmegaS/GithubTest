using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rörelse : MonoBehaviour
{
    [SerializeField]
    KeyCode up;
    [SerializeField]
    KeyCode down;
    // Start is called before the first frame update
    void Start()
    {

        print("start game");

        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3, 3), 0);
       
        if (Input.GetKey(up))
        {
            
            transform.position += new Vector3(0, 5, 0)* Time.deltaTime;
        }

        if (Input.GetKey(down))
        {
            
            transform.position += new Vector3(0, -5, 0) * Time.deltaTime;
        }
    }
}
