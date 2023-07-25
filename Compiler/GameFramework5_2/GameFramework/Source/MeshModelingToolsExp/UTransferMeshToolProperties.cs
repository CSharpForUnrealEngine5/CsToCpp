#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TransferMeshTool.h")]
///<summary>Standard properties of the Transfer operation</summary>
public partial class UTransferMeshToolProperties : UInteractiveToolPropertySet {
// TransferMeshToolProperties
	public bool bTransferMaterials;
	public string SourceLOD;
	public string TargetLOD;
	public bool bIsStaticMeshSource;
	public TArray<string> GetSourceLODNamesFunc() { return default; }
	public TArray<string> SourceLODNamesList;
	public TArray<string> GetTargetLODNamesFunc() { return default; }
	public TArray<string> TargetLODNamesList;
	public bool bIsStaticMeshTarget;
}
