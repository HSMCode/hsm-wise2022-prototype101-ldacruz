using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] float turnSpeed;    
    [SerializeField] float speed;

    private Animator _playerAnim;

    private Rigidbody _playerRb;
    public Vector3 force;

    public bool isOnGround;


    // Start is called before the first frame update
    void Start()
    {
        _playerAnim = GetComponent<Animator>();
        _playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * turnSpeed);
        transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);
        
        _playerAnim.SetFloat("Run", forwardInput);

        if(forwardInput != 0 || horizontalInput != 0)
        {
            _playerAnim.SetBool("Walk", true);
        } 
        else 
        {
            _playerAnim.SetBool("Walk", false);    
        }


        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            _playerRb.AddForce(force, ForceMode.Impulse);
            _playerAnim.SetTrigger("Jump");

            isOnGround = false;
        }
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if(other.gameObject.CompareTag("Ground"))
    //     {
    //         isOnGround = true;
    //     }
    // }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

}



























