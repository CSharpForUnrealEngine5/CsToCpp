#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ParametricMovement.h")]
///<summary>ActorComponent for running basic Parametric movement.</summary>
public partial class UParametricMovementComponent : UBaseMovementComponent {
// ParametricMovementComponent
	public  void EnableInterpolationMode(bool bValue) {}
	public bool bDisableParametricMovementSimulation;
	public FSimpleParametricMotion ParametricMotion;
	public bool bEnableDependentSimulation;
	public bool bEnableInterpolation;
	public bool bEnableForceNetUpdate;
	public float ParentNetUpdateFrequency;
}
