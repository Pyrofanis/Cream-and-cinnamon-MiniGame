using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingDirection : MonoBehaviour
{
    [SerializeField]
    [Header("Sprite of Gun")]
    private GameObject gunObj;
    [Header("Range Relative to Char")]
    [SerializeField]
    [Range(0, 2)]
    private float rangeOfObject = 0.5f;

    private Vector3 mousePosRelativeToCamera, mouseDir;
    private SpriteRenderer gunSprite;
    private void Awake()
    {
        gunSprite = gunObj.GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        //set rotation and position of Object
        gunObj.transform.rotation = Quaternion.Euler(0, 0, AngleZ());
        gunObj.transform.position = ObjectPosition();

        //flips Sprite
        FlipSprite();
    }
    private Vector3 ObjectPosition()
    {
        Vector2 mousePos = PlayerGeneralControlls.inputActions.MovementSchemeFighting.Aim.ReadValue<Vector2>();
        mousePosRelativeToCamera = Camera.main.ScreenToWorldPoint(mousePos);
        float mouseOffsetedY = mousePosRelativeToCamera.y - transform.position.y;
        mouseDir = new Vector3(mousePosRelativeToCamera.x, mouseOffsetedY, 0).normalized;

        float gunLocY = transform.position.y +Mathf.Abs(mouseDir.y) * rangeOfObject; //here mouseDirIsabsIn Order to not clip under the floor
        float gunLocX = transform.position.x + mouseDir.x * rangeOfObject;
        return new Vector3(gunLocX, gunLocY, 0);
    }
    private float AngleZ()
    {
        float angleInRadiants = Mathf.Atan2(mouseDir.y, mouseDir.x);
        float angleInDegrees = Mathf.Rad2Deg * angleInRadiants;
        return angleInDegrees;
    }
    private void FlipSprite()
    {
        if (mouseDir.x < 0)
            gunSprite.flipY = true;
        else
            gunSprite.flipY = false;
    }
}
