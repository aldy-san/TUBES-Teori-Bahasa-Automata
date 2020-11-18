using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBall : MonoBehaviour
{
    public GameObject ball;
    private Vector3 target;
    void Start()
    {
        Cursor.visible = false;
        ball.transform.position = new Vector2(0, 0);
    }
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        ball.transform.position = new Vector2(target.x,target.y);
    }
}
