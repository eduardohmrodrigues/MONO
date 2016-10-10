﻿using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class ColliderController : MonoBehaviour {

    [Tooltip("Color that the sprite should exist")]
    public EColor color;

    private BoxCollider2D _boxCollider;
    private ColorController _parentColorController;
    private Background _background;

    void Start()
    {
        _boxCollider = GetComponent<BoxCollider2D>();
        _parentColorController = transform.parent.GetComponent<ColorController>();
        _background = FindObjectOfType<Background>();
    }

    // Update is called once per frame
    void Update()
    {

        //if the respective sprite color are equals to the 
        //actual parent color we activate the sprite
        if (((color == _parentColorController.actualColor) || color == EColor.Both) && color != _background.color)
        {
            _boxCollider.enabled = true;
        }
        else
        {
            _boxCollider.enabled = false;
        }
    }
}
