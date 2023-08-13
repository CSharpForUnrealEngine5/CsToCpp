namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UObject containers for the preset data</summary>
[CppInclude("FilterPresets.h")]
public partial class ULocalFilterPresetContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>UserPresets</summary>
	public TArray<FFilterData> UserPresets;
}
