#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/CompositeDataTable.h")]
///<summary>Data table composed of a stack of other data tables.</summary>
public partial class UCompositeDataTable : UDataTable {
// CompositeDataTable
	public TArray<UDataTable> ParentTables;
	public TArray<UDataTable> OldParentTables;
}
