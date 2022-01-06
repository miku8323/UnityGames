using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource = default;
    [SerializeField] AudioClip sound1;
    [SerializeField] AudioClip sound2;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent <AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision) // 衝突したら消す
    {
        // 音鳴らして壊す
        audioSource.PlayOneShot(sound1);
        Destroy(this.gameObject);
    }
}
