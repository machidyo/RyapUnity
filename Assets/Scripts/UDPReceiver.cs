using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System;
using System.Collections;

public class UDPReceiver : MonoBehaviour
{
    private const int LOCAL_PORT = 22222;
    private const int DATA_NUMBER = 4;

    public float[] AhrsData = new float[DATA_NUMBER];

    private UdpClient udp;

    void Start()
    {
        Debug.Log("START Start");
        udp = new UdpClient(LOCAL_PORT) {Client = {ReceiveTimeout = 100}};
        StartCoroutine(ThreadMethod());
    }

    private IEnumerator ThreadMethod()
    {
        while (true)
        {
            IPEndPoint remoteEP = null;
            var data = udp.Receive(ref remoteEP);
            Read(data);
            yield return new WaitForSeconds(0.001f);
        }
    }

    // wifi のやつのところからひっぱってきたの
    private void ReadThreeFloatData(byte[] data)
    {
        if (data.Length == DATA_NUMBER * 4) // float または Int32 のサイズとして 4
        {
            for (var i = 0; i < DATA_NUMBER; i++)
            {
                AhrsData[i] = BitConverter.ToSingle(data, i * sizeof(float));
            }

            // Debug.Log(string.Join(", ", AhrsData));
        }
    }

    private void Read(byte[] data)
    {
        AhrsData = data.ToQuaternion(0);
        // var t = data.ToUInt(0);
        // var acc = data.ToVector3(4);
        // var gyro = data.ToVector3(16);
        // var quat = data.ToQuaternion(28);
    }
}