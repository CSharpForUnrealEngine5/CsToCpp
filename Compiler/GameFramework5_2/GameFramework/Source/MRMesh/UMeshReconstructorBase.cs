#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshReconstructorBase.h")]
public partial class UMeshReconstructorBase : UObject {
	///<summary>StartReconstruction</summary>
	public  void StartReconstruction() {}
	///<summary>StopReconstruction</summary>
	public  void StopReconstruction() {}
	///<summary>PauseReconstruction</summary>
	public  void PauseReconstruction() {}
	///<summary>IsReconstructionStarted</summary>
	public  bool IsReconstructionStarted() { return default; }
	///<summary>IsReconstructionPaused</summary>
	public  bool IsReconstructionPaused() { return default; }
	///<summary>ConnectMRMesh</summary>
	public  void ConnectMRMesh(UMRMeshComponent Mesh) {}
	///<summary>DisconnectMRMesh</summary>
	public  void DisconnectMRMesh() {}
}
