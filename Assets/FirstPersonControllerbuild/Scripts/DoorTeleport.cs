using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTeleport : MonoBehaviour
{
    public void NewDestination(string d)
    {
        SceneManager.LoadScene(d);
    }
}
