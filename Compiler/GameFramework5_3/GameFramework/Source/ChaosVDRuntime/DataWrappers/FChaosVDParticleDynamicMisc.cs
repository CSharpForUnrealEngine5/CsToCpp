namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simplified UStruct version of FParticleDynamicMisc.</summary>
[CppInclude("DataWrappers/ChaosVDParticleDataWrapper.h")]
public partial struct FChaosVDParticleDynamicMisc {
	public double MAngularEtherDrag;
	public double MMaxLinearSpeedSq;
	public double MMaxAngularSpeedSq;
	public int MCollisionGroup;
	public EChaosVDObjectStateType MObjectState;
	public EChaosVDSleepType MSleepType;
	public uint MCollisionConstraintFlag;
	public FChaosVDFRigidParticleControlFlags MControlFlags;
	public bool bDisabled;
}
