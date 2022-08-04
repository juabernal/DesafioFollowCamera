using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float MovHorizontal;
    public float MovVertical;
    
    public float speed = 8f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovHorizontal = Input.GetAxis("Horizontal");
        MovVertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(MovHorizontal, 0, MovVertical);
        transform.Translate(direction * speed * Time.deltaTime);

    }
}
