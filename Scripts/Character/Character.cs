﻿using Godot;
namespace MovementFramework.Scripts.Character;

public partial class Character : CharacterBody2D
{
    [Export] public AnimatedSprite2D SpriteNode { get; private set; }
    [Export] public StateMachine.StateMachine _stateMachine;
    [Export(PropertyHint.Range, "200,500,10")] public float Speed = 300.0f;
    [Export(PropertyHint.Range, "-600,-200,10")] public float JumpVelocity = -400.0f;
    
    
    // Get the gravity from the project settings to be synced with RigidBody nodes.
    public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
    
    
    public override void _Ready()
    {
        _stateMachine = GetNode<StateMachine.StateMachine>("StateMachine");
    }

    public override void _Process(double delta)
    {
    }
}