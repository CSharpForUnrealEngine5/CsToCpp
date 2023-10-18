namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ActorComponent for running basic Parametric movement.</summary>
[CppInclude("ParametricMovement.h")]
public partial class UParametricMovementComponent : UBaseMovementComponent {
	public static UClass StaticClass() {return default;}
	///<summary>EnableInterpolationMode</summary>
	public void EnableInterpolationMode(bool bValue) {}
	///<summary>Disables starting the simulation. For development/testing ease of use</summary>
	public bool bDisableParametricMovementSimulation;
	///<summary>ParametricMotion</summary>
	public FSimpleParametricMotion ParametricMotion;
	///<summary>bEnableDependentSimulation</summary>
	public bool bEnableDependentSimulation;
	///<summary>bEnableInterpolation</summary>
	public bool bEnableInterpolation;
	///<summary>Calls ForceNetUpdate every frame. Has slightly different behavior than a very high NetUpdateFrequency</summary>
	public bool bEnableForceNetUpdate;
	///<summary>Sets NetUpdateFrequency on parent. This is editable on the component and really just meant for use during development/test maps</summary>
	public float ParentNetUpdateFrequency;
}
