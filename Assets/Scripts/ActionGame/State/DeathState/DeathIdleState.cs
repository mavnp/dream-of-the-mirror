using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathIdleState : DeathState
{
    public override void Enter(Death death_)
    {
        base.Enter(death_);
        death_.Anim_.Animator_.SetTrigger("Idle");
    }

    public override DeathState HandleCommand(TranslationCommand translationCommand, Command actionCommand)
    {
        if (actionCommand is SwordCommand)
        {
            return attacking;
        }
        if (actionCommand is ShootCommand)
        {
            return shooting;
        }
        return null;
    }

    protected override void Start()
    {
        
    }

    public override void StateFixedUpdate()
    {
        death_.Physics_.HorizontalMove(0, 0);
    }
}