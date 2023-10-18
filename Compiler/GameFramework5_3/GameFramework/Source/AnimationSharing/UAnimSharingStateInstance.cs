namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingInstances.h")]
public partial class UAnimSharingStateInstance : UAnimInstance {
	public static UClass StaticClass() {return default;}
	///<summary>AnimationToPlay</summary>
	public UAnimSequence AnimationToPlay;
	///<summary>PermutationTimeOffset</summary>
	public float PermutationTimeOffset;
	///<summary>PlayRate</summary>
	public float PlayRate;
	///<summary>bStateBool</summary>
	public bool bStateBool;
	///<summary>GetInstancedActors</summary>
	public void GetInstancedActors(TArray<AActor> Actors) {}
	///<summary>Instance</summary>
	public UAnimSharingInstance Instance;
}
