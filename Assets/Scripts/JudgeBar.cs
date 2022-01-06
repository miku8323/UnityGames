using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeBar : MonoBehaviour
{
    [SerializeField] RhythmGameManager gameManager = default;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            // rayをとばして当たり判定
            RaycastHit hit;
            if(Physics.SphereCast(transform.position + new Vector3(0, -3, 0), 0.5f, transform.up, out hit, 5))
            {
                float distance;
                distance = Mathf.Abs(hit.transform.position.z - transform.position.z);
                if(distance < 0.3f)
                {
                    Debug.Log("perfect");
                    gameManager.AddScore(100);
                }
                else if (distance < 0.5f)
                {
                    Debug.Log("good");
                    gameManager.AddScore(50);
                } else {
                    Debug.Log("bad");
                    gameManager.AddScore(10);
                }
                Destroy(hit.collider.gameObject);
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {

        }

        if (Input.GetKeyDown(KeyCode.F))
        {

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

        }

        if (Input.GetKeyDown(KeyCode.J))
        {

        }

        if (Input.GetKeyDown(KeyCode.K))
        {

        }

        if (Input.GetKeyDown(KeyCode.L))
        {

        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 0.5f);
    }
}
