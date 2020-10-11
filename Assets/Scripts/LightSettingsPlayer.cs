using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class LightSettingsPlayer : MonoBehaviour
{
    [SerializeField] PostProcessVolume myVolume;
    [SerializeField] PostProcessProfile standard;
    [SerializeField] PostProcessProfile nightVision;
    [SerializeField] GameObject nightVisionOverlay;

    private bool isNightVision = false;

    void Start()
    {
        nightVisionOverlay.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {
            if(isNightVision == false)
            {
                myVolume.profile = nightVision;
                nightVisionOverlay.gameObject.SetActive(true);
                isNightVision = true; 
            } else
            {
                myVolume.profile = standard;
                isNightVision = false;
                nightVisionOverlay.gameObject.SetActive(false);
            }

        }
    }
}
