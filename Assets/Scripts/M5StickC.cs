using UnityEngine;

public class M5StickC : MonoBehaviour
{
    [SerializeField] private UDPReceiver receiver;

    private bool isRyap = true;
    private Quaternion baseQuaternion = Quaternion.identity;

    void Update()
    {
        if (receiver.AhrsData != null)
        {
            if (isRyap)
            {
                UpdateQuaternion(receiver.AhrsData);
            }
            else
            {
                var x = receiver.AhrsData[0];
                var y = receiver.AhrsData[2];
                var z = receiver.AhrsData[1];
                transform.rotation = Quaternion.Euler(x, y, z);
            }
        }
    }

    private void UpdateQuaternion(float[] raw)
    {
        var quaternion = new Quaternion(raw[1], raw[3], raw[2], -raw[0]).normalized;

        if (baseQuaternion == Quaternion.identity) {
            baseQuaternion = quaternion;
        }
        
        transform.rotation = Quaternion.Inverse(baseQuaternion) * quaternion;
    }
}