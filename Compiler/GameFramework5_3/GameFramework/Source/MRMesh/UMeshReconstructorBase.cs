namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshReconstructorBase.h")]
public partial class UMeshReconstructorBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>StartReconstruction</summary>
	public virtual void StartReconstruction() {}
	///<summary>StopReconstruction</summary>
	public virtual void StopReconstruction() {}
	///<summary>PauseReconstruction</summary>
	public virtual void PauseReconstruction() {}
	///<summary>IsReconstructionStarted</summary>
	public virtual bool IsReconstructionStarted() { return default; }
	///<summary>IsReconstructionPaused</summary>
	public virtual bool IsReconstructionPaused() { return default; }
	///<summary>ConnectMRMesh</summary>
	public virtual void ConnectMRMesh(UMRMeshComponent Mesh) {}
	///<summary>DisconnectMRMesh</summary>
	public virtual void DisconnectMRMesh() {}
}
