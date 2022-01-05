using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class RhythmGameManager : MonoBehaviour
{
    [SerializeField] PlayableDirector playableDirector;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GameMain());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator GameMain()
    {
        // count down
        Debug.Log("3");     // 3
        yield return new WaitForSeconds(1);
        Debug.Log("2");     // 2
        yield return new WaitForSeconds(1);
        Debug.Log("1");     // 1
        yield return new WaitForSeconds(1);
        Debug.Log("start");     // Start
        yield return new WaitForSeconds(0.3f);
        playableDirector.Play();
    }

    public void OnEndEvent()
    {
        
    }

    // リセット
    public void GameRestart()
    {
        SceneManager.LoadScene("RhythmGame");     // シーン名    
    }

    // Menuに戻る
    public void moveMain()
    {
        SceneManager.LoadScene(0);     // シーンindex  
    }
}
