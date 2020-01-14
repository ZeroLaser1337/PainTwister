using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Loading : MonoBehaviour
{
    public Animator transition;
    public int loadingTime;

    public void LevelLoader(string sceneIndex)
    {
        StartCoroutine(LoadLevel(sceneIndex));
    }
    IEnumerator LoadLevel(string sceneIndex)
    {
        transition.SetTrigger("Play");

        yield return new WaitForSeconds(loadingTime);

        SceneManager.LoadScene(sceneIndex);
    }
}
