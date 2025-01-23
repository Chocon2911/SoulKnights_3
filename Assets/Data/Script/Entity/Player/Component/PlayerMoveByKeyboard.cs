using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveByKeyboard : MoveByKeyboard
{
    //==========================================Variable==========================================
    [Header("Player")]
    [SerializeField] private Player player;

    //==========================================Get Set===========================================
    public Player Player { get => player; set => player = value; }

    //===========================================Unity============================================
    private void FixedUpdate()
    {
        this.CheckCanMove();
    }

    //===========================================Method===========================================
    private void CheckCanMove()
    {
        if (player.Health <= 0) this.canMove = false;
        else this.canMove = true;
    }
}
