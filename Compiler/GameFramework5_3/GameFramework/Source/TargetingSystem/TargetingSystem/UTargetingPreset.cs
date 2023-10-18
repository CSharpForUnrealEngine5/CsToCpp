namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@class UTargetingPreset</summary>
[CppInclude("TargetingSystem/TargetingPreset.h")]
public partial class UTargetingPreset : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>The tasks that make up this targeting preset</summary>
	public FTargetingTaskSet TargetingTaskSet;
}
