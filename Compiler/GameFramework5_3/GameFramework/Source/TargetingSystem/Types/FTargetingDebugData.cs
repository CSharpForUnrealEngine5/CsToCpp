namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@struct FTargetingDebugData</summary>
[CppInclude("Types/TargetingSystemTypes.h")]
public partial struct FTargetingDebugData {
	public UTargetingPreset TargetingPreset;
	public TMap<string,string> DebugScratchPadStrings;
	public TArray<FTargetingDefaultResultData> CachedTargetResults;
}
