using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInfoHolder : MonoBehaviour
{
    [SerializeField]
    private SwitchInfo switchInfo;
    protected AudioSource switchSource;

    void Start()
    {
        switchSource = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.CompareTag("Hand"))
        {
            switchInfo.switchState = !switchInfo.switchState;
            print(switchInfo.switchToggle.name);
            switchSource.PlayOneShot(switchInfo.switchAudio);
        }
    }
}
