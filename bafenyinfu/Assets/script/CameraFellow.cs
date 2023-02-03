using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFellow : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetPos();
    }
    void SetPos()
    {
        transform.position =new Vector3(player.position.x,transform.position.y,transform.position.z);
    }//将bird的x值赋给相机.y值和z值不变
}
