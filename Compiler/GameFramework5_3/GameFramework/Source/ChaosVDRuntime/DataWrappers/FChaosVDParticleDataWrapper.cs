namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simplified UStruct version of FChaosVDParticleDataWrapper.</summary>
[CppInclude("DataWrappers/ChaosVDParticleDataWrapper.h")]
public partial struct FChaosVDParticleDataWrapper {
	public uint GeometryHash;
	public string DebugName;
	public int ParticleIndex;
	public int SolverID;
	public EChaosVDParticleType Type;
	public FChaosVDParticlePositionRotation ParticlePositionRotation;
	public FChaosVDParticleVelocities ParticleVelocities;
	public FChaosVDParticleDynamics ParticleDynamics;
	public FChaosVDParticleDynamicMisc ParticleDynamicsMisc;
	public FChaosVDParticleMassProps ParticleMassProps;
	public TArray<FChaosVDParticlePairMidPhase> ParticleMidPhases;
	public TArray<FChaosVDConstraint> ParticleConstraints;
}
