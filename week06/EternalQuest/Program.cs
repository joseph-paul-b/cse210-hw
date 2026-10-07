class Program
{
    static void Main(string[] args)
    {
        // Creativity: I added a level system based on the player's score.
        // Every 1,000 points increases the player's level.
        // This gives the player an additional reason to keep recording goals.

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}