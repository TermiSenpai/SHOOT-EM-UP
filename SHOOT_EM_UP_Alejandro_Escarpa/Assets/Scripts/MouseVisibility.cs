using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseVisibility : MonoBehaviour
{

    private void Start()
    {
        mouseInvisible();
    }

    public void MouseVisible() => Cursor.visible = true;

    public void mouseInvisible() => Cursor.visible = false;
}
