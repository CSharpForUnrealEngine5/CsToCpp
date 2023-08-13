namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifyQueue.h")]
public partial struct FAnimNotifyQueue {
	public TArray<FAnimNotifyEventReference> AnimNotifies;
	public TMap<string,FAnimNotifyArray> UnfilteredMontageAnimNotifies;
}
