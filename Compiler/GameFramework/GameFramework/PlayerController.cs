using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("GameFramework/PlayerController.h")]
    public partial class APlayerController : AController {
        public ULocalPlayer GetLocalPlayer() { return null;  }
        public APlayerCameraManager PlayerCameraManager;

        public virtual void SetupInputComponent() { }
        public bool bShowMouseCursor = true;
        public EMouseCursor DefaultMouseCursor = EMouseCursor.Default;

        public void StopMovement() { }

        public bool GetHitResultUnderFinger(ETouchIndex FingerIndex, ECollisionChannel TraceChannel, bool bTraceComplex, FHitResult HitResult) { return false; }
        public bool GetHitResultUnderCursor(ECollisionChannel TraceChannel, bool bTraceComplex, FHitResult HitResult) { return false; }

    }


}