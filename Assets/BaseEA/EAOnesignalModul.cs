using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OneSignalSDK;

public class EAOnesignalModul : MonoBehaviour
{
        private string ONESIGNAL_ID = "cefc832b-22f7-47f2-aa30-2d56ee19b680";
    // Start is called before the first frame update
    void Start()
    {
        OneSignal.Default.Initialize(ONESIGNAL_ID);
    }

}
