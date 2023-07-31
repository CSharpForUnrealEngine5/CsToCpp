#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@struct FTargetingDebugData</summary>
[CppInclude("Types/TargetingSystemTypes.h")]
public partial struct FTargetingDebugData {
	public UTargetingPreset TargetingPreset;
	public TMap<string,string> DebugScratchPadStrings;
	public TArray<FTargetingDefaultResultData> CachedTargetResults;
}
