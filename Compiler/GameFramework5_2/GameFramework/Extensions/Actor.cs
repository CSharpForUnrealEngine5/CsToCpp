namespace GameFramework;

public partial class AActor : UObject
{
    public UWorld GetWorld() { return default; }
    public FVector GetActorLocation() { return default; }
    protected virtual void BeginPlay() { }
    public virtual void Tick(float delta) { }

    public virtual void EndPlay(EEndPlayReason EndPlayReason) { }

    public virtual void Destroy() { }

}

