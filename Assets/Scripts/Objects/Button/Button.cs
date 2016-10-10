using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class Button : MonoBehaviour {

    public bool isPressed;

    [HideInInspector]
    public bool isPressedByPlayer;
    [HideInInspector]
    public bool isPressedByBox;

    // Use this for initialization
    void Start()
    {
        isPressedByPlayer = false;
        isPressedByBox = false;
        isPressed = false;
    }

    // Update Is called once per frame
    void Update()
    {
        isPressed = (isPressedByPlayer || isPressedByBox);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ETagName.Player.GetDescription())
            isPressedByPlayer = true;

        if (col.gameObject.tag == ETagName.Box.GetDescription())
            isPressedByBox = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == ETagName.Player.GetDescription())
            isPressedByPlayer = false;

        if (col.gameObject.tag == ETagName.Box.GetDescription())
            isPressedByBox = false;
    }

    public void resetButton()
    {
        isPressedByBox = false;
        isPressedByPlayer = false;
        isPressed = false;
    }
}
