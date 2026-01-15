namespace Engine.Core;

public readonly struct Event
{
    public readonly long Sequence;
    public readonly int Type;
    public readonly long Timestamp;

    public Event(long sequence, int type, long timestamp)
    {
        Sequence = sequence;
        Type = type;
        Timestamp = timestamp;
    }
}

