using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("GameFramework/CharacterMovementComponent.h")]
    public partial class UCharacterMovementComponent : UPawnMovementComponent {
        public bool bOrientRotationToMovement;
        public FRotator RotationRate;
        public float JumpZVelocity;
        public float AirControl;
        public float MaxWalkSpeed;
        public float MinAnalogWalkSpeed;
        public float BrakingDecelerationWalking;
        public bool bConstrainToPlane;
        public bool bSnapToPlaneAtStart;
    }

}