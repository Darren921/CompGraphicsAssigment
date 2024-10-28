using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorGradingSwap : MonoBehaviour
{
   [SerializeField] RenderTexture ColorGrading;
   [SerializeField] RenderTexture MainTexture;
  [SerializeField] Camera targetCamera;
   [SerializeField] RawImage Main;
   [SerializeField] Image imageColorGrading;
   [SerializeField] Material ColorGradingCool;
   [SerializeField] Material ColorGradingWarm;
   [SerializeField] Material ColorGradingCustom;


   private void Update()
   {
      if(Input.GetKeyDown(KeyCode.Alpha4))SwapColorGradingCool();
      if(Input.GetKeyDown(KeyCode.Alpha5))SwapColorGradingWarm();
      if(Input.GetKeyDown(KeyCode.Alpha6))SwapColorGradingCustom();
      if(Input.GetKeyDown(KeyCode.Alpha7))SwapColorGradingNone();

   }

   public void SwapColorGradingNone()
   {
      SwitchToMain();
   }

   private void SwitchToMain()
   {
      Main.enabled = true;
      targetCamera.targetTexture = MainTexture;
   }
   
   private void SwitchToColorGrading()
   {
      Main.enabled = false;
      targetCamera.targetTexture = ColorGrading;
   }

   private void SwapColorGradingCool()
   {
      if (targetCamera.targetTexture == MainTexture) SwitchToColorGrading();
      imageColorGrading.material = ColorGradingCool;
   }
   private void SwapColorGradingWarm()
   {
      if (targetCamera.targetTexture == MainTexture) SwitchToColorGrading();
      imageColorGrading.material = ColorGradingWarm;
   }

   private void SwapColorGradingCustom()
   {
      if (targetCamera.targetTexture == MainTexture) SwitchToColorGrading();
      imageColorGrading.material = ColorGradingCustom;
   }
   
   
}
