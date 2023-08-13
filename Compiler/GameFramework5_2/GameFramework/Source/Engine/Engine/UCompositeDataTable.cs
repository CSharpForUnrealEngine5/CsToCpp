namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data table composed of a stack of other data tables.</summary>
[CppInclude("Engine/CompositeDataTable.h")]
public partial class UCompositeDataTable : UDataTable {
	public static UClass StaticClass() {return default;}
	///<summary>Parent tables</summary>
	public TArray<UDataTable> ParentTables;
	///<summary>temporary copy used to detect changes so we can update delegates correctly on removal</summary>
	public TArray<UDataTable> OldParentTables;
}
