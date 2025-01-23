using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    //==========================================Variable==========================================
    [Header("Skill")]
    [SerializeField] protected Cooldown skillCD;
    [SerializeField] protected bool canRecharge;

    //==========================================Get Set===========================================
    public Cooldown SkillCD { get => skillCD; set => skillCD = value; }
    public bool CanRecharge { get => canRecharge; set => canRecharge = value; }

    //===========================================Unity============================================
    protected virtual void FixedUpdate()
    {
        this.RechargeSkill();
    }

    //===========================================Method===========================================
    protected virtual void RechargeSkill()
    {
        if (this.canRecharge && !this.skillCD.IsReady) this.skillCD.CoolingDown();
    }
}
