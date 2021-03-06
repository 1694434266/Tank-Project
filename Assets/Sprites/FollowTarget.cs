using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    private Vector3 offset;
    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - (player1.position + player2.position) / 2;
        camera = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (player1.position + player2.position) / 2 + offset;
        float distance = Vector3.Distance(player1.position, player2.position);
        float size = distance * 0.65f;
        camera.orthographicSize = size;
    }
}
