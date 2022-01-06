using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource = default;
    [SerializeField] AudioClip sound1;
    [SerializeField] AudioClip sound2;
    [SerializeField] TextMeshProUGUI ScoreValue = default;

    int score = 0;

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
        // score
        score += 100;
        // ScoreValue.text = score.ToString();
        // 音鳴らして壊す
        audioSource.PlayOneShot(sound1);
        Destroy(this.gameObject);
    }
}
