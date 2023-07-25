using CSharpToCpp.Utilities;

namespace GameFramework
{

    [CppInclude("Components/SceneComponent.h")]
    public partial class USceneComponent : UActorComponent {
        public void SetupAttachment(USceneComponent InParent, string InSocketName) { }
        public void SetupAttachment(USceneComponent InParent) { }
        public void SetRelativeLocation(FVector loc) { }
        public void AttachToComponent(USceneComponent Parent, FAttachmentTransformRules AttachmentRules, string SocketName) { }
    }

}