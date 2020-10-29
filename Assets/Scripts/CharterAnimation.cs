using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharterAnimation : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.RightArrow)||(Input.GetKey(KeyCode.LeftArrow))||
                                (Input.GetKey(KeyCode.DownArrow)) || (Input.GetKey(KeyCode.UpArrow))) 
       {
           anim.SetBool("IsRun",true);
       }
       else
       {
           anim.SetBool("IsRun",false);
       }
    }
}
