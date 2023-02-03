using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicInput : MonoBehaviour
{
    public static float volume; //储存音量大小
    AudioClip micRecord; //储存声音信息
    string device;//设备的名字

    // Start is called before the first frame update
    void Start()
    {
        device = Microphone.devices[0]; //获取默认设备
        micRecord =Microphone.Start(device,true,999,44100);
    }

    // Update is called once per frame
    void Update()
    {
        volume = GetMaxVolume();
    }
    float GetMaxVolume()
    {
        float maxVolume =0f;
        float [] volumeData =new float[128];
        int offset =Microphone.GetPosition(device) -128+1;
        if (offset<0)
        {
            return 0;
        }
        micRecord.GetData(volumeData,offset);

        for (int i =0;i<128;i++)
        {
            float tempMax = volumeData[i];
            if (maxVolume<tempMax)
            {
                maxVolume=tempMax;
            }
        }
        return maxVolume;
    }
}
