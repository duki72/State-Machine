public abstract class StateBase
{
    protected GameObject owner;

    public StateBase(GameObject owner)
    {
        this.owner = owner;
    }

    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();

    public abstract void OnEvent(Event ev);
}