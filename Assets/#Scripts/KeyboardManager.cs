﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    TouchScreenKeyboard kbRef;
    Polaroid currPolaroid;

    // Update is called once per frame
    private void Update()
    {
        if (currPolaroid != null)
        {
            if (kbRef.status == TouchScreenKeyboard.Status.Done)
                currPolaroid = null;
            else
                currPolaroid.SetPicText(kbRef.text);
        }
    }

    public void SetPicText(Polaroid p)
    {
        currPolaroid = p;
        kbRef = TouchScreenKeyboard.Open(p.GetPicText(), TouchScreenKeyboardType.Default, true, true, false, false, "", 80);
    }
}
