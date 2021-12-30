using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.z > -3.5)
            {
                this.transform.position += Vector3.back * speed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.z < 3.5)
            {
                this.transform.position += Vector3.forward * speed * Time.deltaTime;
            }
        }
        
    }
}
