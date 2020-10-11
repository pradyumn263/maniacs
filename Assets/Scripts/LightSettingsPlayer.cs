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
    [SerializeField] GameObject flashLight;

    private bool isNightVision = false;
    private bool isFlashlightActive = false;


    void Start()
    {
        nightVisionOverlay.gameObject.SetActive(false);
        flashLight.gameObject.SetActive(false);


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

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isFlashlightActive == false)
            {
                
                flashLight.gameObject.SetActive(true);
                isFlashlightActive = true;
            }
            else
            {
                flashLight.gameObject.SetActive(false);
                isFlashlightActive = false;
            }

        }
    }
}
