using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : DashSkill
{
    //==========================================Variable==========================================
    [Header("Player")]
    [SerializeField] private Player player;

    //===========================================Unity============================================
    protected virtual void Update()
    {
        this.CheckDash();
    }

    //==========================================Override==========================================
    protected override void UseSkill()
    {
        base.UseSkill();
        this.dashDir = InputManager.Instance.MoveDir;
        this.player.IsDashing = true;
    }

    protected override void FinishingDash()
    {
        base.FinishingDash();
        this.player.IsDashing = false;
    }

    //===========================================Method===========================================
    private void CheckDash()
    {
        if (InputManager.Instance.SpaceState == 1)
        {
            this.canDash = true;
        }

        else
        {
            this.canDash = false;
        }
    }
}
