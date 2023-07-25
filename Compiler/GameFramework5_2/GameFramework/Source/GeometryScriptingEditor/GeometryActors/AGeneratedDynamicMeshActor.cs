#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryActors/GeneratedDynamicMeshActor.h")]
///<summary>AGeneratedDynamicMeshActor is an Editor-only subclass of ADynamicMeshActor that provides</summary>
public partial class AGeneratedDynamicMeshActor : ADynamicMeshActor {
// GeneratedDynamicMeshActor
	public bool bFrozen;
	public bool bResetOnRebuild;
	public void OnRebuildGeneratedMesh(UObject TargetMesh) {}
	public void CopyPropertiesToStaticMesh(UObject StaticMeshActor,bool bCopyComponentMaterials/*=false*/) {}
	public void CopyPropertiesFromStaticMesh(UObject StaticMeshActor,bool bCopyComponentMaterials/*=false*/) {}
	public bool bEnableRebuildProgress;
	public float DialogDelay;
	public int NumProgressSteps;
	public string ProgressMessage;
	public void IncrementProgress(int NumSteps,string Message) {}
}
