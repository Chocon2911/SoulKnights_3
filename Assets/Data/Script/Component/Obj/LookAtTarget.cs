using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : HuyMonoBehaviour
{
    //==========================================Variable==========================================
    [Header("Look At Target")]
    [SerializeField] protected Transform mainObj;
    [SerializeField] protected Transform target;
    [SerializeField] protected float lookSpeed;
    [SerializeField] protected bool canLook;

    //==========================================Get Set===========================================
    public Transform MainObj { get => mainObj; set => mainObj = value; }
    public Transform Target { get => target; set => target = value; }
    public float LookSpeed { get => lookSpeed; set => lookSpeed = value; }
    public bool CanLook { get => canLook; set => canLook = value; }

    //===========================================Unity============================================
    protected virtual void Update()
    {
        this.Looking();
    }

    //===========================================Method===========================================
    protected virtual void Looking()
    {
        if (this.target != null) this.DoLook();
    }

    protected virtual void DoLook()
    {
        Quaternion mainObjRot = this.mainObj.rotation;
        Quaternion targetRot = this.target.rotation;
        float trueLookSpeed = this.lookSpeed;

        this.mainObj.rotation = Quaternion.Lerp(mainObjRot, targetRot, trueLookSpeed);
    }
}
