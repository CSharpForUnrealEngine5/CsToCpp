#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsSettings.h")]
///<summary>Settings container for Chaos physics engine settings, accessed in Chaos through a setting provider interface.</summary>
public partial struct FChaosPhysicsSettings {
// ChaosPhysicsSettings
	public EChaosThreadingMode DefaultThreadingModel;
	public EChaosSolverTickMode DedicatedThreadTickMode;
	public EChaosBufferMode DedicatedThreadBufferMode;
}
