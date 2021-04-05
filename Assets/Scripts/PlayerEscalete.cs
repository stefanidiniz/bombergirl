using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEscalete : MonoBehaviour
{
    public float speed = 2f;
    //public gameObject = Escalete;
    //public _sprite = spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer.getComponent<spriteRenderer> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.position = transform.position + new Vector3(1 * speed * Time.deltaTime, 0, 0);
            //GetComponent<SpriteRenderer>().FlipX = true;
        }

        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.position = transform.position + new Vector3(-1 * speed * Time.deltaTime, 0, 0);
            //Escalete.getComponent.Flip = true;
        }

        if(Input.GetKey(KeyCode.UpArrow)) {
            transform.position = transform.position + new Vector3(0, 1 * speed * Time.deltaTime, 0);
        }
        
        if(Input.GetKey(KeyCode.DownArrow)) {
            transform.position = transform.position + new Vector3(0, -1 * speed * Time.deltaTime, 0);
        }
    }
}
