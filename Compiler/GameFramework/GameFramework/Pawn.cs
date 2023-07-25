using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("GameFramework/Pawn.h")]
    public partial class APawn : AActor {
        public bool bUseControllerRotationPitch;
        public bool bUseControllerRotationYaw;
        public bool bUseControllerRotationRoll;

        public AController Controller;
        public AController GetController() { return Controller; }
        public void AddControllerYawInput(double X) { }
        public void AddControllerPitchInput(double Y) { }

        public virtual void AddMovementInput(FVector WorldDirection, double ScaleValue = 1.0f, bool bForce = false) { }

    }

}