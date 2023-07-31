#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingInstances.h")]
public partial class UAnimSharingAdditiveInstance : UAnimInstance {
	///<summary>BaseComponent</summary>
	public TWeakObjectPtr<USkeletalMeshComponent> BaseComponent;
	///<summary>AdditiveAnimation</summary>
	public TWeakObjectPtr<UAnimSequence> AdditiveAnimation;
	///<summary>Alpha</summary>
	public float Alpha;
	///<summary>bStateBool</summary>
	public bool bStateBool;
}
