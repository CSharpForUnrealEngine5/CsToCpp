#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the Transfer operation</summary>
[CppInclude("TransferMeshTool.h")]
public partial class UTransferMeshToolProperties : UInteractiveToolPropertySet {
	///<summary>bTransferMaterials</summary>
	public bool bTransferMaterials;
	///<summary>Specify which LOD from the Source (First) mesh to copy from</summary>
	public string SourceLOD;
	///<summary>Specify which LOD on the Target (Second) mesh to copy to</summary>
	public string TargetLOD;
	///<summary>non-exposed properties used to provide custom lists to SourceLOD/TargetLOD</summary>
	public bool bIsStaticMeshSource;
	///<summary>GetSourceLODNamesFunc</summary>
	public  TArray<string> GetSourceLODNamesFunc() { return default; }
	///<summary>SourceLODNamesList</summary>
	public TArray<string> SourceLODNamesList;
	///<summary>GetTargetLODNamesFunc</summary>
	public  TArray<string> GetTargetLODNamesFunc() { return default; }
	///<summary>TargetLODNamesList</summary>
	public TArray<string> TargetLODNamesList;
	///<summary>bIsStaticMeshTarget</summary>
	public bool bIsStaticMeshTarget;
}
