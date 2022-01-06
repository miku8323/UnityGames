using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{

    public float speed = 10.0f;
    private Rigidbody myRigid;
    public BreakOutManager myManager;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        speed += 0.00001f;

        // start
        if (Input.GetKeyDown(KeyCode.Return))
        {   
            myRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
        }
    }

    private void OnCollisionEnter(Collision collision) // 衝突したら消す
    {
        if(collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
            myManager.GameOver();
        }
    }
}
