#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshReconstructorBase.h")]
public partial class UMeshReconstructorBase : UObject {
// MeshReconstructorBase
	public void StartReconstruction() {}
	public void StopReconstruction() {}
	public void PauseReconstruction() {}
	public bool IsReconstructionStarted() { return default; }
	public bool IsReconstructionPaused() { return default; }
	public void ConnectMRMesh(UObject Mesh) {}
	public void DisconnectMRMesh() {}
}
