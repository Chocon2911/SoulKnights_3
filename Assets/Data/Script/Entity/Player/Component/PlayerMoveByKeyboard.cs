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
        this.CheckMove();
    }

    //===========================================Method===========================================
    private void CheckMove()
    {
        if (this.player.Health <= 0 || this.player.IsDashing) this.canMove = false;
        else this.canMove = true;

        if (InputManager.Instance.MoveDir != Vector2.zero) this.player.IsMoving = true;
        else this.player.IsMoving = false;
    }
}
