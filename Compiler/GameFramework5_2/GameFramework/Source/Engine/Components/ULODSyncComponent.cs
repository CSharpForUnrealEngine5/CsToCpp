#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/LODSyncComponent.h")]
///<summary>Implement an Actor component for LOD Sync of different components</summary>
public partial class ULODSyncComponent : UActorComponent {
// LODSyncComponent
	public int NumLODs;
	public int ForcedLOD;
	public int MinLOD;
	public TArray<FComponentSync> ComponentsToSync;
	public TMap<string,FLODMappingData> CustomLODMapping;
	public string GetLODSyncDebugText() { return default; }
	public int CurrentLOD;
	public int CurrentNumLODs;
	public TArray<UPrimitiveComponent> DriveComponents;
	public TArray<UPrimitiveComponent> SubComponents;
}
