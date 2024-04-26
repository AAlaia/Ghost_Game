using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneFade : MonoBehaviour
{
    public static SceneFade instance; 
    public Animator animator; 
    
    public void FadeToLevel()
    {
        animator.SetTrigger("FadeOut"); 
    }

    public void OnFadeComplete(int i)
    {
        SceneManager.LoadScene(i); 
    }
}
