namespace GameFramework;

public enum EMouseCursor
{
    /** Causes no mouse cursor to be visible */
    None,

    /** Default cursor (arrow) */
    Default,

    /** Text edit beam */
    TextEditBeam,

    /** Resize horizontal */
    ResizeLeftRight,

    /** Resize vertical */
    ResizeUpDown,

    /** Resize diagonal */
    ResizeSouthEast,

    /** Resize other diagonal */
    ResizeSouthWest,

    /** MoveItem */
    CardinalCross,

    /** Target Cross */
    Crosshairs,

    /** Hand cursor */
    Hand,

    /** Grab Hand cursor */
    GrabHand,

    /** Grab Hand cursor closed */
    GrabHandClosed,

    /** a circle with a diagonal line through it */
    SlashedCircle,

    /** Eye-dropper cursor for picking colors */
    EyeDropper,

    /** Custom cursor shape for platforms that support setting a native cursor shape. Same as specifying None if not set. */
    Custom,

    /** Number of cursors we support */
    TotalCursorCount
};

