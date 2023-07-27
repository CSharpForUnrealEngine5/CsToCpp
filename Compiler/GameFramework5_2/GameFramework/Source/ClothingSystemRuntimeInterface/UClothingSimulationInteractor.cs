#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothingSimulationInteractor.h")]
///<summary>If a clothing simulation is able to be interacted with at runtime then a derived</summary>
public partial class UClothingSimulationInteractor : UObject {
// ClothingSimulationInteractor
	public  void PhysicsAssetUpdated() {}
	public  void ClothConfigUpdated() {}
	public  void SetAnimDriveSpringStiffness(float InStiffness) {}
	public  void EnableGravityOverride(FVector InVector) {}
	public  void DisableGravityOverride() {}
	public  void SetNumIterations(int NumIterations/*=1*/) {}
	public  void SetMaxNumIterations(int MaxNumIterations/*=10*/) {}
	public  void SetNumSubsteps(int NumSubsteps/*=1*/) {}
	public  int GetNumCloths() { return default; }
	public  int GetNumKinematicParticles() { return default; }
	public  int GetNumDynamicParticles() { return default; }
	public  int GetNumIterations() { return default; }
	public  int GetNumSubsteps() { return default; }
	public  float GetSimulationTime() { return default; }
	public  UClothingInteractor GetClothingInteractor(string ClothingAssetName) { return default; }
	public TMap<string,UClothingInteractor> ClothingInteractors;
}
