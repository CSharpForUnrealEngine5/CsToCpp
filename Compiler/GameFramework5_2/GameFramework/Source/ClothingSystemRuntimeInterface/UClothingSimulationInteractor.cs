#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>If a clothing simulation is able to be interacted with at runtime then a derived</summary>
[CppInclude("ClothingSimulationInteractor.h")]
public partial class UClothingSimulationInteractor : UObject {
	///<summary>Called to update collision status without restarting the simulation.</summary>
	public  void PhysicsAssetUpdated() {}
	///<summary>Called to update the cloth config without restarting the simulation.</summary>
	public  void ClothConfigUpdated() {}
	///<summary>Set the stiffness of the spring force for the animation drive.</summary>
	public  void SetAnimDriveSpringStiffness(float InStiffness) {}
	///<summary>Set a new gravity override and enable the override.</summary>
	public  void EnableGravityOverride(FVector InVector) {}
	///<summary>Disable any currently set gravity override.</summary>
	public  void DisableGravityOverride() {}
	///<summary>Set the number of time dependent solver iterations.</summary>
	public  void SetNumIterations(int NumIterations/*=1*/) {}
	///<summary>Set the maximum number of solver iterations.</summary>
	public  void SetMaxNumIterations(int MaxNumIterations/*=10*/) {}
	///<summary>Set the number of substeps or subdivisions.</summary>
	public  void SetNumSubsteps(int NumSubsteps/*=1*/) {}
	///<summary>Return the number of cloths run by the simulation.</summary>
	public  int GetNumCloths() { return default; }
	///<summary>Return the number of kinematic (animated) particles.</summary>
	public  int GetNumKinematicParticles() { return default; }
	///<summary>Return the number of dynamic (simulated) particles.</summary>
	public  int GetNumDynamicParticles() { return default; }
	///<summary>Return the solver number of iterations.</summary>
	public  int GetNumIterations() { return default; }
	///<summary>Return the solver number of subdivisions./</summary>
	public  int GetNumSubsteps() { return default; }
	///<summary>Return the instant average simulation time in ms.</summary>
	public  float GetSimulationTime() { return default; }
	///<summary>Return a cloth interactor for this simulation.</summary>
	public  UClothingInteractor GetClothingInteractor(string ClothingAssetName) { return default; }
	///<summary>Cloth interactors currently created.</summary>
	public TMap<string,UClothingInteractor> ClothingInteractors;
}
