#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Manages logic for combining filters in the editor.</summary>
[CppInclude("Data/Filters/LevelSnapshotsFilterPreset.h")]
public partial class ULevelSnapshotsFilterPreset : ULevelSnapshotFilter {
	public static UClass StaticClass() {return default;}
	///<summary>Children</summary>
	public TArray<UConjunctionFilter> Children;
}
