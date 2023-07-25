using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("Components/PrimitiveComponent.h")]
    public partial class UPrimitiveComponent : USceneComponent {
        public FBodyInstance BodyInstance;
        public FComponentHitSignature OnComponentHit;
        public FComponentBeginOverlapSignature OnComponentBeginOverlap;

        public ECanBeCharacterBase CanCharacterStepUpOn;

        protected virtual void BeginPlay() { }
        public bool IsSimulatingPhysics() { return false; }
        public void SetWalkableSlopeOverride(FWalkableSlopeOverride NewOverride) { }
        public void AddImpulseAtLocation(FVector Impulse, FVector Location, string BoneName = "") { }
        public void SetOwnerNoSee(bool bNewOwnerNoSee) { }

        /** Changes the value of bOnlyOwnerSee. */
        public void SetOnlyOwnerSee(bool bNewOnlyOwnerSee) { }
        public bool CastShadow, bCastDynamicShadow;
    }

}