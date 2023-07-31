#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings container for Chaos physics engine settings, accessed in Chaos through a setting provider interface.</summary>
[CppInclude("PhysicsEngine/PhysicsSettings.h")]
public partial struct FChaosPhysicsSettings {
	public EChaosThreadingMode DefaultThreadingModel;
	public EChaosSolverTickMode DedicatedThreadTickMode;
	public EChaosBufferMode DedicatedThreadBufferMode;
}
