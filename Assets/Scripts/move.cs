using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{public Transform transform;
    public float speed = 7f;
    public float rotationSpeed = 5f;
public  AudioSource CoinSound;

    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
       
       Movment();
       Clamp();


    }

    void Movment() {
 if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(speed * Time.deltaTime ,0,0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,303), rotationSpeed * Time.deltaTime);
        }

         if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position -= new Vector3(speed * Time.deltaTime ,0,0);
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,27), rotationSpeed * Time.deltaTime);
        }

        if (transform.rotation.z != 90) {
             transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,0), rotationSpeed * Time.deltaTime);
        }
    }

    void Clamp() {

     

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-2.92f,2.92f);
        transform.position = pos;
    }

    
        
    
}