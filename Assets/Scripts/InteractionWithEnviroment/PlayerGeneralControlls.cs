using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGeneralControlls : MonoBehaviour
{
    public  enum ControllType{fighter,peacful}
    public  enum GroundType{ground,air}


    [SerializeField]
    [Header("Running Speed")]
    [Range(1,100)]
    private float speed;
    [SerializeField]
    [Header("JumpPower")]
    [Range(1,500)]
    private float jumpPower;

    [SerializeField]
    [Header("ControllType")]
    public static ControllType controllScheme;
    //used by shooting direction
    public static GroundType currentGroundType;
    private Rigidbody2D rb;
   public static CacpRealControlls inputActions;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        inputActions = new CacpRealControlls();
        inputActions.Enable();
    }
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(0,5);

     if (controllScheme.Equals(ControllType.fighter))
        {
            inputActions.MovementSchemeFighting.Jump.performed += _ => Jump();
            //inputActions.MovementSchemeFighting.Shoot.performed += _ => Shoot();
        }   
    }
    private void Update()
    {
        Movement();
    }
    private void Movement()
    {
        float horizontalMovement = inputActions.MovementSchemeNoFighting.HorizontalMovement.ReadValue<float>();
        transform.position=Vector2.MoveTowards(transform.position, transform.position+Vector3.right* horizontalMovement, speed * Time.deltaTime);
    }
    private void Jump()
    {
        if (currentGroundType.Equals(GroundType.ground))
        {
            rb.AddForce(Vector2.up * jumpPower);
            currentGroundType=GroundType.air;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("ground"))
        {
            currentGroundType=GroundType.ground;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.gameObject.tag.Contains("ground"))
        {
            currentGroundType = GroundType.ground;
        }
    }

}
