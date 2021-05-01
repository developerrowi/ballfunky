
using UnityEngine;
using System.Collections;
public class GlobalClass : MonoBehaviour {

       const int ScreenFadingIn = -1;
       const int ScreenIdle = 0;
       const int ScreenFadingOut   =   1;
       public static float ScreenFadeAlpha = 1.0f;
       public static bool isGoingDown = false;

       public static float speedCount = 5;
}