using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float acompanha = 0.125f;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // Se necessário, inicialize offset aqui
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;

        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, acompanha);
        transform.position = smoothedPosition;    
    }
}
