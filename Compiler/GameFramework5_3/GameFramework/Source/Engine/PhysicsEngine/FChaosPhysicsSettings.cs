namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings container for Chaos physics engine settings, accessed in Chaos through a setting provider interface.</summary>
[CppInclude("PhysicsEngine/PhysicsSettings.h")]
public partial struct FChaosPhysicsSettings {
	public EChaosThreadingMode DefaultThreadingModel;
	public EChaosSolverTickMode DedicatedThreadTickMode;
	public EChaosBufferMode DedicatedThreadBufferMode;
}
