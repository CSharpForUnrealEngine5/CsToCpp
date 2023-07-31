#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifyQueue.h")]
public partial struct FAnimNotifyQueue {
	public TArray<FAnimNotifyEventReference> AnimNotifies;
	public TMap<string,FAnimNotifyArray> UnfilteredMontageAnimNotifies;
}
