namespace Yahtzee
{
    public interface IRandom
    {
        int Next(int start, int endNotInclusive);
    }
}