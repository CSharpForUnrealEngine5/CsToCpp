#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingInstances.h")]
public partial class UAnimSharingStateInstance : UAnimInstance {
// AnimSharingStateInstance
	public UAnimSequence AnimationToPlay;
	public float PermutationTimeOffset;
	public float PlayRate;
	public bool bStateBool;
	public void GetInstancedActors(TArray<UObject> Actors) {}
	public UAnimSharingInstance Instance;
}
