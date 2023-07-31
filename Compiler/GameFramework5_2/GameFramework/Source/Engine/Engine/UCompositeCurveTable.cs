#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Curve table composed of a stack of other curve tables.</summary>
[CppInclude("Engine/CompositeCurveTable.h")]
public partial class UCompositeCurveTable : UCurveTable {
	///<summary>Parent tables</summary>
	public TArray<UCurveTable> ParentTables;
	///<summary>temporary copy used to detect changes so we can update delegates correctly on removal</summary>
	public TArray<UCurveTable> OldParentTables;
}
