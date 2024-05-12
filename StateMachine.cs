public class StateMachine
{
    //state machine class to manage the state transitions
    private StateBase currentState;

    public StateMachine(GameObject owner)
    {
        currentState = new IdleState(owner);
        currentState.Enter();
    }

    public void Update()
    {
        currentState.Update();
    }

    public void ChangeState(StateBase newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public void HandleEvent(Event ev)
    {
        currentState.OnEvent(ev);
    }
}