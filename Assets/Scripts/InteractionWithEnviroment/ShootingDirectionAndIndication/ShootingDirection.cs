using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingDirection : PlayerGeneralControlls
{
    enum Controlls { pc, console }

    [SerializeField]
    private Controlls currentControll;

    [SerializeField]
    [Header("Sprite of Gun")]
    public GameObject gunObj;
    [Header("Range Relative to Char")]
    [SerializeField]
    [Range(0, 2)]
    private float rangeOfObject = 0.5f;

    private Vector3 mousePosRelativeToCamera, mouseDir, triggerDir;
    private bool aimingActive;
    private SpriteRenderer gunSprite;
    private void Awake()
    {
        gunSprite = gunObj.GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        PlayerGeneralControlls.inputActions.AimPc.ActivateAIM.started += _ => ActivateCalculation();
        PlayerGeneralControlls.inputActions.AimPc.ActivateAIM.canceled += _ => ResetMouseDir();
    }
    // Update is called once per frame
    void Update()
    {
        ControllsSwapper();

        //set rotation and position of Object
        gunObj.transform.rotation = Quaternion.Euler(0, 0, AngleZ());
        gunObj.transform.position = ObjectPosition();

        //flips Sprite
        FlipSprite();
    }
    private void ControllsSwapper()
    {
        if (triggerDir.x != 0 || triggerDir.y != 0)
        {
            currentControll = Controlls.console;
        }
        if (mouseDir.x != 0 || mouseDir.y != 0)
        {
            currentControll = Controlls.pc;
        }
    }
    //pc Controlls
    private Vector3 ObjectPosition()
    {
        float gunLocY;
        float gunLocX;
        //Pc
        CalculateMouseDir(aimingActive);

        //console
        triggerDir = PlayerGeneralControlls.inputActions.AimConsole.AimConsole.ReadValue<Vector2>();


        switch (currentControll)
        {
            case Controlls.console:
                if (PlayerGeneralControlls.currentGroundType.Equals(PlayerGeneralControlls.GroundType.ground))
                    gunLocY = transform.position.y + Mathf.Abs(triggerDir.y) * rangeOfObject;//here DirIsabsIn Order to not clip under the floor
                else gunLocY = transform.position.y + triggerDir.y * rangeOfObject;

                gunLocX = transform.position.x + triggerDir.x * rangeOfObject;

                return new Vector3(gunLocX, gunLocY, 0);
            case Controlls.pc:
                if (PlayerGeneralControlls.currentGroundType.Equals(PlayerGeneralControlls.GroundType.ground))
                    gunLocY = transform.position.y + Mathf.Abs(mouseDir.y) * rangeOfObject; //here DirIsabsIn Order to not clip under the floor
                else gunLocY = transform.position.y + mouseDir.y * rangeOfObject;

                gunLocX = transform.position.x + mouseDir.x * rangeOfObject;

                return new Vector3(gunLocX, gunLocY, 0);
        }

        return Vector3.zero;

    }

    private float AngleZ()
    {
        float angleInRadiants;
        float angleInDegrees;
        switch (currentControll)
        {
            case Controlls.console:
                angleInRadiants = Mathf.Atan2(triggerDir.y, triggerDir.x);
                angleInDegrees = angleInRadiants * Mathf.Rad2Deg;
                return angleInDegrees;
            case Controlls.pc:
                angleInRadiants = Mathf.Atan2(mouseDir.y, mouseDir.x);
                angleInDegrees = Mathf.Rad2Deg * angleInRadiants;
                return angleInDegrees;
        }
        return 0;

    }
    private void FlipSprite()
    {
        switch (currentControll)
        {
            case Controlls.console:
                if (triggerDir.x < 0)
                    gunSprite.flipY = true;
                else
                    gunSprite.flipY = false;
                break;
            case Controlls.pc:
                if (mouseDir.x < 0)
                    gunSprite.flipY = true;
                else
                    gunSprite.flipY = false;
                break;
        }
    }
    ////PC Adjustent
    private void ActivateCalculation()
    {
        aimingActive = true;
    }
    private void CalculateMouseDir(bool isItAiming)
    {
        switch (isItAiming)
        {
            case true:
                Vector2 mousePos = PlayerGeneralControlls.inputActions.AimPc.Aim.ReadValue<Vector2>();
                mousePosRelativeToCamera = Camera.main.ScreenToWorldPoint(mousePos);
                float mouseOffsetedY = mousePosRelativeToCamera.y - transform.position.y;
                float mouseOffsetedX = mousePosRelativeToCamera.x - transform.position.x;
                mouseDir = new Vector3(mouseOffsetedX, mouseOffsetedY, 0).normalized;
                break;
        }

    }
    private void ResetMouseDir()
    {
        aimingActive = false;
        mouseDir = Vector3.zero;
    }
}

