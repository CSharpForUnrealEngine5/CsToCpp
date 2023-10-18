namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Physics Prediction Settings</summary>
[CppInclude("PhysicsEngine/PhysicsSettings.h")]
public partial struct FPhysicsPredictionSettings {
	public bool bEnablePhysicsPrediction;
	public bool bEnablePhysicsResimulation;
	public float ResimulationErrorThreshold;
	public float MaxSupportedLatencyPrediction;
}
