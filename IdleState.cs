public class IdleState : StateBase
{
    public IdleState(GameObject owner) : base(owner) { }

    public override void Enter()
    {
        
    }

    public override void Update()
    {
      
    }

    public override void Exit()
    {
        
    }

    public override void OnEvent(Event ev)
    {
        switch (ev)
        {
            case Event.PlayerSpotted:
                owner.GetComponent<StateMachine>().ChangeState(new ChaseState(owner));
                break;
            // handle other events
        }
    }
}

// similar classes for Chase, Attack, and Death states