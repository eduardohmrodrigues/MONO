using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class Background : MonoBehaviour {
    [Tooltip("Background Initial Color")]
    public EColor color;

    // Use this for initialization
    void Start () {
        if (color == EColor.Both)
            color = EColor.White;
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    //this function change the background color to the opposite color
    public void ChangeColor()
    {
        color = (color == EColor.White) ? EColor.Black : EColor.White;
    }

    public EColor GetColor()
    {
        return color;
    }
}
