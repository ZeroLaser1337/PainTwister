using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Teleport : MonoBehaviour
{
   void Update()
   {
       if(Input.GetButtonDown("Oculus_CrossPlatform_Button2"))
       {
           SceneManager.LoadScene("Consult");
       }
       if(Input.GetButtonDown("Oculus_CrossPlatform_Button4"))
       {
           SceneManager.LoadScene("Storage Room");
       }
   }
}
