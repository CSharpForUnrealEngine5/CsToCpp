#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Collect geometry from selected actors and merge them into single mesh.</summary>
[CppInclude("DataprepEditingOperations.h")]
public partial class UDataprepMergeActorsOperation : UDataprepEditingOperation {
	///<summary>Settings to use for the merge operation</summary>
	public string NewActorLabel;
	///<summary>Settings to use for the merge operation</summary>
	public bool bDeleteMergedActors_DEPRECATED;
	///<summary>Settings to use for the merge operation</summary>
	public bool bDeleteMergedMeshes_DEPRECATED;
	///<summary>MergeSettings_DEPRECATED</summary>
	public FMeshMergingSettings MergeSettings_DEPRECATED;
	///<summary>Whether merged mesh should have pivot at world origin, or at first merged component otherwise</summary>
	public bool bPivotPointAtZero;
}
