#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingManager.h")]
public partial class UAnimSharingInstance : UObject {
	///<summary>Actors currently registered to be animation driven by the AnimManager using this setup</summary>
	public TArray<AActor> RegisteredActors;
	///<summary>(Blueprint)class instance used for determining the state enum value for each registered actor</summary>
	public UAnimationSharingStateProcessor StateProcessor;
	///<summary>UsedAnimationSequences</summary>
	public TArray<UAnimSequence> UsedAnimationSequences;
	///<summary>Enum class set up by the user to &#39;describe&#39; the animation states</summary>
	public UEnum StateEnum;
	///<summary>Actor to which all the running SkeletalMeshComponents used for the sharing are attached to</summary>
	public AActor SharingActor;
}
