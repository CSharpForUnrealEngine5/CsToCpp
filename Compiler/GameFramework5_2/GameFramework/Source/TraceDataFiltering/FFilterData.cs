#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FilterPresets.h")]
///<summary>Structure representing an individual preset in configuration (ini) files</summary>
public partial struct FFilterData {
// FilterData
	public string Name;
	public TArray<string> AllowlistedNames;
}
