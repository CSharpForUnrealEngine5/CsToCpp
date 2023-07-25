namespace GameFramework;

public enum ESpawnActorCollisionHandlingMethod
{
    /** Fall back to default settings. */
    Undefined,
	/** Actor will spawn in desired location, regardless of collisions. */
	AlwaysSpawn,
	/** Actor will try to find a nearby non-colliding location (based on shape components), but will always spawn even if one cannot be found. */
	AdjustIfPossibleButAlwaysSpawn,
	/** Actor will try to find a nearby non-colliding location (based on shape components), but will NOT spawn unless one is found. */
	AdjustIfPossibleButDontSpawnIfColliding,
	/** Actor will fail to spawn. */
	DontSpawnIfColliding
};
enum EActorUpdateOverlapsMethod
{
    // Use the default value specified by the native class or config value.
    UseConfigDefault,
    // Always update overlap state on initialization.
    AlwaysUpdate,
    // Only update if root component has Movable mobility.
    OnlyUpdateMovable,
    // Never update overlap state on initialization.
    NeverUpdate
};

public enum ESpawnActorScaleMethod
{
    /** Ignore the default scale in the actor's root component and hard-set it to the value of SpawnTransform Parameter */
    OverrideRootScale,
    /** Multiply value of the SpawnTransform Parameter with the default scale in the actor's root component */
    MultiplyWithRoot,
    SelectDefaultAtRuntim
};
