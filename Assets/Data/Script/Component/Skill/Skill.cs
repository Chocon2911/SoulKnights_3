using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : HuyMonoBehaviour
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
        this.UsingSkill();
        this.RechargingSkill();
    }

    //==========================================Recharge==========================================
    protected virtual void RechargingSkill()
    {
        if (!this.canRecharge || this.skillCD.IsReady) return;
        this.RechargeSkill();
    }

    protected virtual void RechargeSkill()
    {
        this.skillCD.CoolingDown();
    }

    //============================================Use=============================================
    protected virtual void UsingSkill()
    {
        if (!this.skillCD.IsReady) return;
        this.UseSkill();
    }

    protected abstract void UseSkill();

    //===========================================Finish===========================================
    protected virtual void FinishSkill()
    {
        this.skillCD.ResetStatus();
    }
}
