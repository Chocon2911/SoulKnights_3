using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRegenAmor : RegenIntSkill
{
    //==========================================Variable==========================================
    [Header("Player")]
    [SerializeField] private Player player;

    //===========================================Unity============================================
    private void OnEnable()
    {
        this.canRegen = true;
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        this.CheckRegen();
    }

    //===========================================Method===========================================
    protected override void Regen()
    {
        if (this.player.IsDamaging) return;
        base.Regen();
    }

    protected override void AddToCurrAmount()
    {
        this.player.Amor += this.regenAmount;
    }

    protected override int GetCurrAmount()
    {
        return this.player.Amor;
    }

    protected override int GetMaxAmount()
    {
        return this.player.MaxAmor;
    }

    private void CheckRegen()
    {
        if (this.isRegen) this.player.IsRegeningAmor = true;
        else this.player.IsRegeningAmor = false;
    }
}
