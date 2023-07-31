#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implement an Actor component for LOD Sync of different components</summary>
[CppInclude("Components/LODSyncComponent.h")]
public partial class ULODSyncComponent : UActorComponent {
	///<summary>if -1, it&#39;s default and it will calculate the max number of LODs from all sub components</summary>
	public int NumLODs;
	///<summary>if -1, it&#39;s automatically switching</summary>
	public int ForcedLOD;
	///<summary>Minimum LOD to use when syncing components</summary>
	public int MinLOD;
	///<summary>Array of components whose LOD may drive or be driven by this component.</summary>
	public TArray<FComponentSync> ComponentsToSync;
	///<summary>by default, the mapping will be one to one</summary>
	public TMap<string,FLODMappingData> CustomLODMapping;
	///<summary>Returns a string detailing</summary>
	public  string GetLODSyncDebugText() { return default; }
	///<summary>CurrentLOD</summary>
	public int CurrentLOD;
	///<summary>num of LODs</summary>
	public int CurrentNumLODs;
	///<summary>component that drives the LOD</summary>
	public TArray<UPrimitiveComponent> DriveComponents;
	///<summary>all the components that ticks</summary>
	public TArray<UPrimitiveComponent> SubComponents;
}
