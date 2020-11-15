namespace Base
{
    public enum PlayerStates
    {
        PLATFORM,   // Player is in Platforming mode
        PUZZLE,     // Player is in Puzzle mode
        WON
    }

    public enum CameraStates
    {
        TRACKING,
        TRANSITION,
        NEW_SPOT,
        REVERT
    }
}