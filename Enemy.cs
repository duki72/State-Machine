public class Enemy : MonoBehaviour
{
    private StateMachine stateMachine;

    void Start()
    {
        stateMachine = new StateMachine(gameObject);
    }

    void Update()
    {
        stateMachine.Update();
    }

    public void OnPlayerSpotted()
    {
        stateMachine.HandleEvent(Event.PlayerSpotted);
    }

    public void OnPlayerInRange()
    {
        stateMachine.HandleEvent(Event.PlayerInRange);
    }

    public void OnDead()
    {
        stateMachine.HandleEvent(Event.Dead);
    }
}
// the HandleEvent method is used to trigger state transitions based on external events.