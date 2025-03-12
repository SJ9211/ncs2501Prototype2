using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float horizontalInput;
    public float spped = 20.0f;
    public float xRange = 18;
    void Start()
    {

    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // x 좌표 넘지 않게하는 코드
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,
                                                  transform.position.z);
        }
        if (transform.position.x > xRange)
        {
        transform.position = new Vector3(xRange, transform.position.y,
                                                  transform.position.z);
        }
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * spped);
        
        // 발사체
        if ( Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, 
                projectilePrefab.transform.rotation);
        }

    }
}
