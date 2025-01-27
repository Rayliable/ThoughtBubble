using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    public Texture2D mouseCursor;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 cursorOffset = new Vector2(mouseCursor.width / 2, mouseCursor.height / 2);
        Cursor.SetCursor(mouseCursor, cursorOffset, CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
            //Vector3 mousePos = Input.mousePosition;
            //mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            //mousePos.z = 0;
            //transform.position = mousePos;
    }
}
