using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // breakout
    public void clickBreakOut()
    {
        SceneManager.LoadScene("BreakOut");     // シーン名    
    }

    // rhythmgame
    public void clickRhythmGame()
    {
        SceneManager.LoadScene("RhythmGame");     // シーン名    
    }

    // janken
    public void clickJnaken()
    {
        SceneManager.LoadScene("Janken");     // シーン名    
    }
}
