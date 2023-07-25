using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("GameFramework/Character.h",
        "GameFramework/CharacterMovementComponent.h",
        "Components/CapsuleComponent.h"
        )]
    public partial class ACharacter : APawn {
        public UCapsuleComponent GetCapsuleComponent() { return null; }

        public UCharacterMovementComponent GetCharacterMovement() { return null; }

        public void Jump() { }
        public void StopJumping() { }
    }

}