using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionWithEnviromentCacpReal : MonoBehaviour
{
    private Animator currentAnimator;
    // Start is called before the first frame update
    void Start()
    {
        currentAnimator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerGeneralControlls>())
        {
            currentAnimator.SetBool("Play", true);
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.GetComponent<PlayerGeneralControlls>())
        {
            currentAnimator.SetBool("Play", true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.GetComponent<PlayerGeneralControlls>())
        {
            currentAnimator.SetBool("Play", false);
        }
    }
}
