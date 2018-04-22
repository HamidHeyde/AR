using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Action : MonoBehaviour {

    public GameObject Model;

    private float sx,sy,sz;
    private float speed = 1.1f;

    private void get_scale()
    {
        sx = Model.transform.localScale.x;
        sy = Model.transform.localScale.y;
        sz = Model.transform.localScale.z;
    }

    private void set_scale()
    {
        Model.transform.localScale = new Vector3(sx, sy, sz);
    }

    public void Zoomin()
    {
        get_scale();
        sx *= speed;
        sy *= speed; 
        sz *= speed;
        set_scale();
    }

    public void Zoomout()
    {
        get_scale();
        sx /= speed;
        sy /= speed;
        sz /= speed;
        set_scale();
    }
}
