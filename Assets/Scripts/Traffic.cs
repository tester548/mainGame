using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic : MonoBehaviour
{
   public GameObject red;
   public GameObject green;
   
   private bool Switch =  true;
   
   void Start ()
   {
      ChangeLight();
   }
 
   void Update ()
   {
      red.enabled = Switch;
      green.enabled = !Switch;
   }
 
   void ChangeLight()
   {
      while (true)
      {
         Switch = !Switch;
         yield WaitForSeconds(30);
      }
}
