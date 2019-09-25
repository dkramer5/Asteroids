using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float Option_FieldOfView = 60;

    void Start()
    {
        Option_FieldOfView = 60.0f;
    }

    void Update()
    {
        //Update the camera's field of view to be the variable returning from the Slider
        Camera.main.fieldOfView = Option_FieldOfView;
    }

    /*void OnGUI()
    {
        //Set up the maximum and minimum values the Slider can return (you can change these)
        float max, min;
        max = 150.0f;
        min = 10.0f;
        //This Slider changes the field of view of the Camera between the minimum and maximum values
        Option_FieldOfView = GUI.HorizontalSlider(new Rect(20, 20, 100, 40), Option_FieldOfView, min, max);
    }*/

}
