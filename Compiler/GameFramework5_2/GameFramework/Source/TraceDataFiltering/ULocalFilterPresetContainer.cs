#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UObject containers for the preset data</summary>
[CppInclude("FilterPresets.h")]
public partial class ULocalFilterPresetContainer : UObject {
	///<summary>UserPresets</summary>
	public TArray<FFilterData> UserPresets;
}
