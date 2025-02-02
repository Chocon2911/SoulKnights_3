using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RegenIntSkill : Skill
{
    //==========================================Variable==========================================
    [Header("Regen Int")]
    [SerializeField] protected Cooldown regenCD;
    [SerializeField] protected int regenAmount;
    [SerializeField] protected bool canRegen;
    [SerializeField] protected bool isRegen;

    //==========================================Get Set===========================================
    public Cooldown RegenCD { get => regenCD; set => regenCD = value; }
    public int RegenAmount { get => regenAmount; set => regenAmount = value; }
    public bool CanRegen { get => canRegen; set => canRegen = value; }
    public bool IsRegen { get => isRegen; set => isRegen = value; }

    //===========================================Unity============================================
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        this.RechargingRegen();
        this.Regening();
        this.FinishingRegen();
    }

    //==========================================Override==========================================
    protected override void UsingSkill()
    {
        if (!this.canRegen) return;
        base.UsingSkill();
    }

    protected override void UseSkill()
    {
        this.isRegen = true;
    }

    //=======================================Recharge Regen=======================================
    protected virtual void RechargingRegen()
    {
        if (!this.isRegen) return;
        this.RechargeRegen();
    }

    protected virtual void RechargeRegen()
    {
        this.regenCD.CoolingDown();
    }

    //===========================================Regen============================================
    protected virtual void Regening()
    {
        if (!this.regenCD.IsReady) return;
        this.Regen();
    }

    protected virtual void Regen()
    {
        this.AddToCurrAmount();
        this.regenCD.ResetStatus();
    }

    //========================================Finish Regen========================================
    protected virtual void FinishingRegen()
    {
        if (this.GetCurrAmount() < this.GetMaxAmount()) return;
        this.FinishRegen();
    }

    protected virtual void FinishRegen()
    {
        this.skillCD.ResetStatus();
        this.regenCD.ResetStatus();
        this.isRegen = false;
    }

    //=========================================Sub Method=========================================
    protected abstract void AddToCurrAmount();
    protected abstract int GetCurrAmount();
    protected abstract int GetMaxAmount();
}
