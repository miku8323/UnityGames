using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeBar : MonoBehaviour
{
    [SerializeField] RhythmGameManager gameManager = default;
    [SerializeField] AudioSource audioSource = default;
    [SerializeField] AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetScore(-3);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            GetScore(-2);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            GetScore(-1);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetScore(0);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            GetScore(1);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            GetScore(2);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            GetScore(3);
        }
    }

    private void GetScore(int xValue)
    {
        // rayをとばして当たり判定
        RaycastHit hit;
        if(Physics.SphereCast(transform.position + new Vector3(xValue, -3, 0), 0.5f, transform.up, out hit, 5))
        {
            float distance;
            distance = Mathf.Abs(hit.transform.position.z - transform.position.z);
            if(distance < 0.5f)
            {
                Debug.Log("perfect");
                gameManager.AddScore(100);
            }
            else if (distance < 0.8f)
            {
                Debug.Log("good");
                gameManager.AddScore(50);
            } else {
                Debug.Log("bad");
                gameManager.AddScore(10);
            }
            // 音鳴らして壊す
            audioSource.PlayOneShot(sound);
            Destroy(hit.collider.gameObject);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 0.5f);
    }
}
