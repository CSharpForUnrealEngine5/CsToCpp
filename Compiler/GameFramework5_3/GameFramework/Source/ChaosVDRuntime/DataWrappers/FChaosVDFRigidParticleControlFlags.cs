namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataWrappers/ChaosVDParticleDataWrapper.h")]
public partial struct FChaosVDFRigidParticleControlFlags {
	public bool bGravityEnabled;
	public bool bCCDEnabled;
	public bool bOneWayInteractionEnabled;
	public bool bMaxDepenetrationVelocityOverrideEnabled;
	public bool bInertiaConditioningEnabled;
	public int GravityGroupIndex;
}
