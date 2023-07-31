#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingInstances.h")]
public partial class UAnimSharingStateInstance : UAnimInstance {
	///<summary>AnimationToPlay</summary>
	public UAnimSequence AnimationToPlay;
	///<summary>PermutationTimeOffset</summary>
	public float PermutationTimeOffset;
	///<summary>PlayRate</summary>
	public float PlayRate;
	///<summary>bStateBool</summary>
	public bool bStateBool;
	///<summary>GetInstancedActors</summary>
	public  void GetInstancedActors(TArray<AActor> Actors) {}
	///<summary>Instance</summary>
	public UAnimSharingInstance Instance;
}
