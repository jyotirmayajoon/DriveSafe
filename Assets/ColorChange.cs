using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ColorChange: MonoBehaviour
{
    //Reference to button to access its components
    public Button theButton;

    //this get the Transitions of the Button as its pressed
    public ColorBlock theColor;

    /// <summary>
    /// Example
    /// just add this to your Button component On Click()
    /// </summary>
    public void ButtonTransitionColors()
    {

        theColor.highlightedColor = Color.blue;
        theColor.normalColor = Color.red;
        theColor.pressedColor = Color.green;

        theButton.colors = theColor;
        Debug.Log("pressed");
    }
}