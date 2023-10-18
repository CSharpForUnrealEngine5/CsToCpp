namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassReplicationFragments.h")]
public partial struct FMassReplicationParameters {
	public float LODDistance;
	public float BufferHysteresisOnDistancePercentage;
	public int LODMaxCount;
	public int LODMaxCountPerViewer;
	public float UpdateInterval;
	public UClass BubbleInfoClass;
	public UClass ReplicatorClass;
}
