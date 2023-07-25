#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingInstances.h")]
public partial class UAnimSharingAdditiveInstance : UAnimInstance {
// AnimSharingAdditiveInstance
	public TWeakObjectPtr<USkeletalMeshComponent> BaseComponent;
	public TWeakObjectPtr<UAnimSequence> AdditiveAnimation;
	public float Alpha;
	public bool bStateBool;
}
