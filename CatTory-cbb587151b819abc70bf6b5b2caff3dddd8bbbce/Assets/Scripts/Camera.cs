using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Vector2 clickPoint;
    public float dragSpeed = 1f;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) clickPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if (Input.GetMouseButton(0)){
            Vector3 position = ((Vector2)Input.mousePosition - clickPoint);

            position.z = 0f;

            Vector3 move = position * (Time.deltaTime * dragSpeed);

            float z = transform.position.z;

            transform.Translate(move);
            transform.position
                = new Vector3(transform.position.x, transform.position.y, z);
        }
    }
}
