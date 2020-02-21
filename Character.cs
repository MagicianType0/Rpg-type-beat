using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Stats
{
    #region Variables
    [Header("Character Data")]
    public new string name;
    public float speed = 5f, crouch = 2.5f, sprint = 10f;
    public float jumpspeed = 8f;
    #endregion

    #region
    public virtual void Movement()
    {
        //default movement in here
        Debug.Log("Parent Movement");
    }
    #endregion

public virtual void Update()
    {
        Movement();
    }
}
