using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SkeletonController : MonoBehaviour {

   private float speed = 4f;
   private float rotSpeed = 80f;
   private float rot = 0f;
   private float gravity = 8f;

   private Vector3 moveDirection = Vector3.zero;

   private CharacterController controller;

   

   private Animator anim;
   // Start is called before the first frame update
    void Start() {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update() {

        
        
        //if (controller.isGrounded) {
            

			
        //}    
    }

}
