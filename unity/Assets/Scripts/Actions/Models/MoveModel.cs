public class MoveModel
{
    private float defaultSpeed = 5f;

    public float Speed { get; private set; }

    public MoveModel()
    {
        Speed = defaultSpeed;
    }

    public void SetSpeed(float speed)
    {
        Speed = speed;
    }
}
