#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AGeneratedDynamicMeshActor is an Editor-only subclass of ADynamicMeshActor that provides</summary>
[CppInclude("GeometryActors/GeneratedDynamicMeshActor.h")]
public partial class AGeneratedDynamicMeshActor : ADynamicMeshActor {
	///<summary>If true, the DynamicMeshComponent will be &quot;Frozen&quot; in its current state, and automatic rebuilding will be disabled. However the DynamicMesh can still be modified by explicitly-called functions/etc.</summary>
	public bool bFrozen;
	///<summary>If true, the DynamicMeshComponent will be cleared before the OnRebuildGeneratedMesh event is executed.</summary>
	public bool bResetOnRebuild;
	///<summary>This event will be fired to notify the BP that the generated Mesh should</summary>
	public  void OnRebuildGeneratedMesh(UDynamicMesh TargetMesh) {}
	///<summary>Attempt to copy Actor Properties to a StaticMeshActor. Optionally copy DynamicMeshComponent material list to the StaticMeshComponent.</summary>
	public  void CopyPropertiesToStaticMesh(AStaticMeshActor StaticMeshActor,bool bCopyComponentMaterials/*=false*/) {}
	///<summary>Attempt to copy Actor Properties from a StaticMeshActor. Optionally copy DynamicMeshComponent material list to the StaticMeshComponent.</summary>
	public  void CopyPropertiesFromStaticMesh(AStaticMeshActor StaticMeshActor,bool bCopyComponentMaterials/*=false*/) {}
	///<summary>If enabled, a long-running OnRebuildGeneratedMesh event will show a progress dialog (The Script being executed must call IncrementProgress regularly)</summary>
	public bool bEnableRebuildProgress;
	///<summary>Delay in seconds before the progress dialog is shown, if enabled</summary>
	public float DialogDelay;
	///<summary>Number of progress steps/ticks that the progress bar will be subdivided into</summary>
	public int NumProgressSteps;
	///<summary>The default progress message</summary>
	public string ProgressMessage;
	///<summary>Call this function from within OnRebuildGeneratedMesh to update progress tracking.</summary>
	public  void IncrementProgress(int NumSteps,string Message) {}
}
