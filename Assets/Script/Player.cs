using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public float moveSpeed = 3f;
    // Update is called once per frame
    void Update()
    {
        Move();

    }
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        Vector3 vector3 = new Vector3();
        float playerSpeed = h * moveSpeed * Time.deltaTime;
        vector3.x = playerSpeed;
        transform.Translate(vector3);

        if (h < 0)
        {
            this.GetComponent<Animator>().SetBool("Walk", true);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(h==0)
        {
            this.GetComponent<Animator>().SetBool("Walk", false);
        }
        else
        {
            this.GetComponent<Animator>().SetBool("Walk", true);
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
    

}
