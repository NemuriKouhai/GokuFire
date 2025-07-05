using UnityEngine;

public class Player_Manager : MonoBehaviour
{
    float speed = 2f;
    float jumpForce = 5f;
    bool isGrounded = true;

    Rigidbody rb;

    Vector3 moveInput;

    [SerializeField] LayerMask whatIsEnemy;
    Vector3 direc;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


     void Update()
     {
      // W�L�[�i�O���ړ��j
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //          transform.position += speed * transform.forward * Time.deltaTime;
             
    //    }

    //    // S�L�[�i����ړ��j
    //    if (Input.GetKey(KeyCode.S))
    //    {
    //         transform.position -= speed * transform.forward * Time.deltaTime;
    //    }

    //     // D�L�[�i�E�ړ��j
    //     if (Input.GetKey(KeyCode.D))
    //     {
    //          transform.position += speed * transform.right * Time.deltaTime;
    //     }

    //      // A�L�[�i���ړ��j
    //      if (Input.GetKey(KeyCode.A))
    //      {
    //          transform.position -= speed * transform.right * Time.deltaTime;
    //      }

        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0 ,Input.GetAxisRaw("Vertical"));
        
        if (moveInput!=Vector3.zero)direc = moveInput;
        
        rb.MovePosition(rb.position + moveInput.normalized*speed*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.E))
        {
            
            Collider[] c = Physics.OverlapSphere(transform.position+direc.normalized*2f,1f, whatIsEnemy);

            if (c.Length > 0)
            {
                Debug.Log("aa");
                Destroy(c[0]);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
     }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }



}
