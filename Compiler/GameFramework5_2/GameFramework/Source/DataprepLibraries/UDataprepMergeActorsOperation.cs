#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepEditingOperations.h")]
///<summary>Collect geometry from selected actors and merge them into single mesh.</summary>
public partial class UDataprepMergeActorsOperation : UDataprepEditingOperation {
// DataprepMergeActorsOperation
	public string NewActorLabel;
	public bool bDeleteMergedActors_DEPRECATED;
	public bool bDeleteMergedMeshes_DEPRECATED;
	public FMeshMergingSettings MergeSettings_DEPRECATED;
	public bool bPivotPointAtZero;
}
