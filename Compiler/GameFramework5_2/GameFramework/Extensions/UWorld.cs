#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;

public partial class UWorld
{
    public APlayerController GetFirstPlayerController() { return default; }

    public T SpawnActor<T>(FActorSpawnParameters p = new FActorSpawnParameters()) { return default; }

    public T SpawnActor<T>(UObject klass, FVector location, FRotator rotation, FActorSpawnParameters p) { return default(T); }

    public float GetDeltaSeconds() { return 0; }
}

public struct FActorSpawnParameters
{

    /* A name to assign as the Name of the Actor being spawned. If no value is specified, the name of the spawned Actor will be automatically generated using the form [Class]_[Number]. */
    public string Name;

    /* An Actor to use as a template when spawning the new Actor. The spawned Actor will be initialized using the property values of the template Actor. If left NULL the class default object (CDO) will be used to initialize the spawned Actor. */
    public AActor Template;

    /* The Actor that spawned this Actor. (Can be left as NULL). */
    public AActor Owner;

    /* The APawn that is responsible for damage done by the spawned Actor. (Can be left as NULL). */
    public APawn Instigator;

    /* The ULevel to spawn the Actor in, i.e. the Outer of the Actor. If left as NULL the Outer of the Owner is used. If the Owner is NULL the persistent level is used. */
    public ULevel OverrideLevel;

    /* The parent component to set the Actor in. */
    public UChildActorComponent OverrideParentComponent;

    /** Method for resolving collisions at the spawn point. Undefined means no override, use the actor's setting. */
    public ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingOverride;

    /** Determines whether to multiply or override root component with provided spawn transform */
    public ESpawnActorScaleMethod TransformScaleMethod;
}

