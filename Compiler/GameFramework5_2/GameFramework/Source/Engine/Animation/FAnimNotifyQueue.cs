#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifyQueue.h")]
public partial struct FAnimNotifyQueue {
// AnimNotifyQueue
	public TArray<FAnimNotifyEventReference> AnimNotifies;
	public TMap<string,FAnimNotifyArray> UnfilteredMontageAnimNotifies;
}
