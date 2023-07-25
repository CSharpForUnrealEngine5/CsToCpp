namespace GameFramework
{
    public enum EWalkableSlopeBehavior
    {
        /** Don't affect the walkable slope. Walkable slope angle will be ignored. */
        WalkableSlope_Default,

        /**
         * Increase walkable slope.
         * Makes it easier to walk up a surface, by allowing traversal over higher-than-usual angles.
         * @see FWalkableSlopeOverride::WalkableSlopeAngle
         */
        WalkableSlope_Increase,

        /**
         * Decrease walkable slope.
         * Makes it harder to walk up a surface, by restricting traversal to lower-than-usual angles.
         * @see FWalkableSlopeOverride::WalkableSlopeAngle
         */
        WalkableSlope_Decrease,

        /**
         * Make surface unwalkable.
         * Note: WalkableSlopeAngle will be ignored.
         */
        WalkableSlope_Unwalkable,

        WalkableSlope_Max,
    }
}
