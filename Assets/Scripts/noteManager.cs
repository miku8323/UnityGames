using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteManager : MonoBehaviour
{
    // BPM120 半小節 : 1秒
    // bar z : -6
    // note z : 8
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 14;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -speed * Time.deltaTime);
    }
}
