using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float time;
    public float timer;

    // Update is called once per frame
    void Start()
    {
        time = 2;
        timer = time;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer<0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = time;
        }
    }
}
