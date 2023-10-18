#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;

public partial class AActor : UObject
{
    public UWorld GetWorld() { return default; }
    public FVector GetActorLocation() { return default; }
    public FRotator GetActorRotation() { return default; }
    public void SetActorRotation(FRotator NewRotation) { }
    protected virtual void BeginPlay() { }
    public virtual void Tick(float delta) { }

    public virtual void EndPlay(EEndPlayReason EndPlayReason) { }

    public virtual void Destroy() { }

    public void AddActorWorldOffset(FVector DeltaLocation) { }
    public void AddActorWorldRotation(FRotator DeltaRotation) { }

    public void AddActorWorldTransformKeepScale(FTransform DeltaTransform) { }

    public bool SetActorTransform(FTransform DeltaTransform) { return false; }
    public void AddActorLocalOffset(FVector DeltaLocation) { }

    public void AddActorLocalRotation(FRotator DeltaRotation) { }

    public void AddActorLocalTransform(FTransform NewTransform) { }

    public void SetActorRelativeLocation(FVector NewRelativeLocation) { }

    public void SetActorRelativeRotation(FRotator NewRelativeRotation) { }
    public void SetActorRelativeTransform(FTransform NewRelativeTransform) { }
}

