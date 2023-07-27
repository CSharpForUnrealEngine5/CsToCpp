#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionalAITest.h")]
///<summary>AFunctionalAITestBase</summary>
public partial class AFunctionalAITestBase : AFunctionalTest {
// FunctionalAITestBase
	public float SpawnLocationRandomizationRange;
	public TArray<APawn> SpawnedPawns;
	public TArray<FPendingDelayedSpawn> PendingDelayedSpawns;
	public int CurrentSpawnSetIndex;
	public string CurrentSpawnSetName;
	public FFunctionalTestAISpawned OnAISpawned;
	public FFunctionalTestEventSignature OnAllAISPawned;
	public FVector NavMeshDebugOrigin;
	public FVector NavMeshDebugExtent;
	public bool bWaitForNavMesh;
	public bool bDebugNavMeshOnTimeout;
	public  bool IsOneOfSpawnedPawns(AActor Actor) { return default; }
}
