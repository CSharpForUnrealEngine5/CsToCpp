#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure representing an individual preset in configuration (ini) files</summary>
[CppInclude("FilterPresets.h")]
public partial struct FFilterData {
	public string Name;
	public TArray<string> AllowlistedNames;
}
