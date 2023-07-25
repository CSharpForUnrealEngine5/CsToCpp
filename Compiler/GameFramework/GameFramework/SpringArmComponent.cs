using CSharpToCpp.Utilities;

namespace GameFramework
{

    [CppInclude("GameFramework/SpringArmComponent.h")]
    public partial class USpringArmComponent : USceneComponent {
        public float TargetArmLength;
        public bool bUsePawnControlRotation;
        public static string SocketName;
        public bool bDoCollisionTest;

        public void SetUsingAbsoluteRotation (bool u) { }
        public void SetRelativeRotation(FRotator r) { }
    }

}