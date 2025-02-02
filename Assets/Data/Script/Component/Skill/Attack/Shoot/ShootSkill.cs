using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootSkill : Skill
{
    //==========================================Variable==========================================
    [Header("Shoot")]
    [SerializeField] protected Transform bulletObj;
    [SerializeField] protected bool canShoot;

    //==========================================Get Set===========================================
    public Transform BulletObj { get => bulletObj; set => bulletObj = value; }
    public bool CanShoot { get => canShoot; set => canShoot = value; }

    //==========================================Override==========================================
    protected override void UsingSkill()
    {
        if (!this.canShoot) return;
        base.UsingSkill();
    }
}
