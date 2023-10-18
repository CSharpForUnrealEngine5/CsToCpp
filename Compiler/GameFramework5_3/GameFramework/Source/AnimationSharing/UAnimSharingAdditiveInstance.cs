namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingInstances.h")]
public partial class UAnimSharingAdditiveInstance : UAnimInstance {
	public static UClass StaticClass() {return default;}
	///<summary>BaseComponent</summary>
	public TWeakObjectPtr<USkeletalMeshComponent> BaseComponent;
	///<summary>AdditiveAnimation</summary>
	public TWeakObjectPtr<UAnimSequence> AdditiveAnimation;
	///<summary>Alpha</summary>
	public float Alpha;
	///<summary>bStateBool</summary>
	public bool bStateBool;
}
