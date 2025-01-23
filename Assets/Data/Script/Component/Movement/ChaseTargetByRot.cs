using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseTargetByRot : HuyMonoBehaviour
{
    //==========================================Variable==========================================
    [Header("Chase Target")]
    [SerializeField] protected MoveForward moveForward;
    [SerializeField] protected LookAtTarget lookAtTarget;
    [SerializeField] protected bool canChase = true;

    //==========================================Get Set===========================================
    public MoveForward MoveForward { get => moveForward; set => moveForward = value; }
    public LookAtTarget LookAtTarget { get => lookAtTarget; set => lookAtTarget = value; }
    public bool CanChase { get => canChase; set => canChase = value; }

    //===========================================Unity============================================
    protected virtual void FixedUpdate()
    {
        this.Chase();
    }

    //===========================================Method===========================================
    protected virtual void Chase()
    {
        if (this.canChase)
        {
            this.moveForward.CanMove = true;
            this.lookAtTarget.CanLook = true;
        }

        else 
        {
            this.moveForward.CanMove = false;
            this.lookAtTarget.CanLook = false;
        }
    }
}
