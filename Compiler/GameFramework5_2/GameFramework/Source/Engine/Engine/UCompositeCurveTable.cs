namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Curve table composed of a stack of other curve tables.</summary>
[CppInclude("Engine/CompositeCurveTable.h")]
public partial class UCompositeCurveTable : UCurveTable {
	public static UClass StaticClass() {return default;}
	///<summary>Parent tables</summary>
	public TArray<UCurveTable> ParentTables;
	///<summary>temporary copy used to detect changes so we can update delegates correctly on removal</summary>
	public TArray<UCurveTable> OldParentTables;
}
