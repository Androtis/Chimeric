using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : MonoBehaviour
{
    private Vector2 resolutionSize = new Vector2(800f,600f); //used for the resolution of the computer
    private float scaleAmount = 1; //used to set the scale of ui for buttons, etc.
    [SerializeField] private GameObject settingsMenu; //pulls out the settings menu
    private bool isFullscreen = false; //to switch between fullscreen & windowed

    // used to check if any changers were made, and to close & open the settings menu
    public void exitSettingsMenu(bool isClose){
        bool isOverride = false;
        if (isClose){
            settingsMenu.SetActive(isClose);
        } else {
            if(hasChanged(isOverride)){
                settingsMenu.SetActive(isClose); //change it to pop up a menu before hand
            } else {
                settingsMenu.SetActive(isClose);
            }
        }
        
    }
    
    //sets the scalefactor for all the canvases
    public void setUIScale(float scaleAmount){
        int objectLength = FindObjectsByType<CanvasScaler>(FindObjectsSortMode.None).Length;
        for (int i = 0; i < objectLength; i++){
            FindObjectsByType<CanvasScaler>(FindObjectsSortMode.None)[i].scaleFactor = scaleAmount;
        }
        
    }

    //applies all the settings that were changed
    public void Apply(){
        Screen.SetResolution((int)resolutionSize.x, (int)resolutionSize.y, fullscreen:isFullscreen);
        setUIScale(scaleAmount);
    }

    //checks if any settings have changed
    private bool hasChanged(bool changeOverride){
        if (changeOverride){
            return false;
        }
        return false;
    }

}
