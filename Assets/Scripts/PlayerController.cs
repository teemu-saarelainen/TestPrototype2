using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 15.0f;
    private float maxOffsetX = 20.0f;
    private float projectileY = 0.5f;

    // The prefab the acts as a projectile
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        this.transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);

        if (this.transform.position.x < -maxOffsetX)
            this.transform.position = new Vector3(-maxOffsetX, transform.position.y, transform.position.z);
        else if (this.transform.position.x > maxOffsetX)
            this.transform.position = new Vector3(maxOffsetX, transform.position.y, transform.position.z);


        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(projectilePrefab, new Vector3(this.transform.position.x, projectileY, this.transform.position.z), projectilePrefab.transform.rotation);

    }
}
