using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StagesManager : MonoBehaviour
{
    public enum stages{
        first,
        second,
        final
    }

    public delegate void ChangeStage(stages stages);
    public ChangeStage onStageChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
