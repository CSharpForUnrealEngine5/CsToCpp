#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/CompositeCurveTable.h")]
///<summary>Curve table composed of a stack of other curve tables.</summary>
public partial class UCompositeCurveTable : UCurveTable {
// CompositeCurveTable
	public TArray<UCurveTable> ParentTables;
	public TArray<UCurveTable> OldParentTables;
}
