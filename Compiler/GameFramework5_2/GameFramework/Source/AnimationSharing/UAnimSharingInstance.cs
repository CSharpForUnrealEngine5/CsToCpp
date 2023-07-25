#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingManager.h")]
public partial class UAnimSharingInstance : UObject {
// AnimSharingInstance
	public TArray<AActor> RegisteredActors;
	public UAnimationSharingStateProcessor StateProcessor;
	public TArray<UAnimSequence> UsedAnimationSequences;
	public UEnum StateEnum;
	public AActor SharingActor;
}
