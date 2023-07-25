using CSharpToCpp.Utilities;

namespace GameFramework
{

    [CppInclude("GameFramework/Actor.h")]
    public partial class AActor : UObject
    {
        //TODO: Net functionality
        //TODO Tags
        //TODO: Delegates OnActorBeginOverlap, OnActorEndOverlap
        //TODO: Input
        //TODO: GetTransform, ActorToWorld
        //TODO: AddComponent
        //TODO: GetOverlappingActors
        //TODO: OnEndPlay, OnDestroyed

        protected virtual void BeginPlay() { }
        protected virtual void EndPlay() { }

        protected USceneComponent RootComponent;

        public UInputComponent InputComponent;

        /** If true, all input on the stack below this actor will not be considered */
        bool bBlockInput;
        bool bAsyncPhysicsTickEnabled;

        /** How long this Actor lives before dying, 0=forever. Note this is the INITIAL value and should not be modified once play has begun. */
        public float InitialLifeSpan;

        /** Allow each actor to run at a different time speed. The DeltaTime for a frame is multiplied by the global TimeDilation (in WorldSettings) and this CustomTimeDilation for this actor's tick.  */
        public float CustomTimeDilation;

        public bool Destroy(bool bNetForce = false, bool bShouldModifyLevel = true) { return false; }
        public FVector GetVelocity() { return new FVector(); }
        public FVector GetActorLocation() { return new FVector(); }
        public FRotator GetActorRotation() { return new FRotator(); }
        public FVector GetActorScale() { return new FVector(); }

        public UWorld GetWorld() { return null; }

        public FActorTickFunction PrimaryActorTick;
    }

}