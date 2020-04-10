using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lastPosition = transform.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime);
        if ((transform.position.x > 6.25F || transform.position.x < -6.25F) || (transform.position.y > 0 || transform.position.y < -4.30F))
        {
            transform.position = lastPosition;
        }
    }
}
