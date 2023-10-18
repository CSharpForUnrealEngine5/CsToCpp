namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataWrappers/ChaosVDCollisionDataWrappers.h")]
public partial struct FChaosVDParticlePairMidPhase {
	public int SolverID;
	public bool bIsActive;
	public bool bIsCCD;
	public bool bIsCCDActive;
	public bool bIsSleeping;
	public bool bIsModified;
	public int LastUsedEpoch;
	public int Particle0Idx;
	public int Particle1Idx;
	public TArray<FChaosVDConstraint> Constraints;
}
