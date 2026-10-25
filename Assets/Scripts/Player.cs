using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 60f;


    void Start()
    {
        
    }

    void Update()
    {
        float x= Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(-x,0,z) * Time.deltaTime * speed);

    }
}
