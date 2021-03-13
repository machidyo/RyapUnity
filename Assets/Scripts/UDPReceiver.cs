using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Collections;

public class UDPReceiver : MonoBehaviour
{
    private const int DATA_NUMBER = 4;
    
    [SerializeField] private int localPort = 22222;
    
    public float[] AhrsData { get; private set; } = new float[DATA_NUMBER];

    private UdpClient udp;

    void Start()
    {
        udp = new UdpClient(localPort) {Client = {ReceiveTimeout = 100}};
        StartCoroutine(ThreadMethod());
    }

    private IEnumerator ThreadMethod()
    {
        while (true)
        {
            IPEndPoint remoteEp = null;
            var data = udp.Receive(ref  remoteEp);
            AhrsData = data.ToQuaternion(0);

            yield return new WaitForSeconds(0.001f);
        }
    }
}