using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("Components/SkeletalMeshComponent.h")]
    public partial class USkeletalMeshComponent : USkinnedMeshComponent {
        public UAnimInstance GetAnimInstance() { return null; }
    }

}