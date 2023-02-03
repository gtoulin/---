using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaverCtrl : MonoBehaviour
{
    public float volume;
    Rigidbody2D rg;
    public float jumpForce;
    float tempTime=0;
    float maxSpeed =5f;
    // Start is called before the first frame update
    void Start()
    {
        rg =GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        volume =MicInput.volume;//获取Micinput脚本中volume值

        if (volume>0)
        {
            MoveForward();
            if(rg.velocity.x>maxSpeed)
            {
                rg.velocity =new Vector2(maxSpeed,rg.velocity.y);
            }//限制x轴最大速度
        }
        if(volume>0.3){
            if(Time.time-tempTime>2){

                Jump();
                tempTime =Time.time;
            }
        }//将Micinput中的音量导入该脚本，并且根据音量判断Bird是跳起还是前进，且避免Bird跳得太高
    }
    void Jump(){
        rg.AddForce(Vector2.up*jumpForce*volume);
    }//设置跳起的高度
    void MoveForward(){
        rg.AddForce(Vector2.right*50*volume);
    }//设置前进的长度，其中“100”为根据自己的计算机设置不同的力度
}
