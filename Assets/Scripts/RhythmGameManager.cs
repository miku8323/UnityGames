using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RhythmGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
