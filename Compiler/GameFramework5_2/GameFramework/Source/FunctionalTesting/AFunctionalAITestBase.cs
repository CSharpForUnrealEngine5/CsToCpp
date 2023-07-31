#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AFunctionalAITestBase</summary>
[CppInclude("FunctionalAITest.h")]
public partial class AFunctionalAITestBase : AFunctionalTest {
	///<summary>SpawnLocationRandomizationRange</summary>
	public float SpawnLocationRandomizationRange;
	///<summary>SpawnedPawns</summary>
	public TArray<APawn> SpawnedPawns;
	///<summary>PendingDelayedSpawns</summary>
	public TArray<FPendingDelayedSpawn> PendingDelayedSpawns;
	///<summary>CurrentSpawnSetIndex</summary>
	public int CurrentSpawnSetIndex;
	///<summary>CurrentSpawnSetName</summary>
	public string CurrentSpawnSetName;
	///<summary>Called when a single AI finished spawning</summary>
	public FFunctionalTestAISpawned OnAISpawned;
	///<summary>Called when a all AI finished spawning</summary>
	public FFunctionalTestEventSignature OnAllAISPawned;
	///<summary>navmesh debug: log navoctree modifiers around this point</summary>
	public FVector NavMeshDebugOrigin;
	///<summary>navmesh debug: extent around NavMeshDebugOrigin</summary>
	public FVector NavMeshDebugExtent;
	///<summary>if set, ftest will postpone start until navmesh is fully generated</summary>
	public bool bWaitForNavMesh;
	///<summary>if set, ftest will postpone start until navmesh is fully generated</summary>
	public bool bDebugNavMeshOnTimeout;
	///<summary>IsOneOfSpawnedPawns</summary>
	public  bool IsOneOfSpawnedPawns(AActor Actor) { return default; }
}
