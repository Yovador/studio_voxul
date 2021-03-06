﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBehaviour : InteractibleObject
{

    [SerializeField] protected GameObject objectToControl;


    public override void ActionOnInteraction()
    {

        if (Input.GetButtonDown("Use") && playerController.GetcharacterColor() == 0)
        {
            objectToControl.SetActive(!objectToControl.activeSelf);
            AudioSource.PlayClipAtPoint(sound, transform.position);
            Destroy(gameObject);
        }
    }
}
