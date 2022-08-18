using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public buyukCember buyukCemberScript;
    public spawner spawnerScript;
    // bool isDead;
    public Animator anim;
    
    public void EndGame()
    {
        buyukCemberScript.enabled = false;
        spawnerScript.enabled = false;
        anim.SetTrigger("die");
        //  isDead = true;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//eger bir sahne varsa devamli onu cagiracak demektir
    }
    
}