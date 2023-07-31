#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The ML mesh deformer component.</summary>
[CppInclude("MLDeformerComponent.h")]
public partial class UMLDeformerComponent : UActorComponent {
	///<summary>Get the current ML Deformer weight. A value of 0 means it is fully disabled, while 1 means fully active.</summary>
	public  float GetWeight() { return default; }
	///<summary>Set the ML Deformer weight. This determines how active the deformer is. You can see it as a blend weight.</summary>
	public  void SetWeight(float NormalizedWeightValue) {}
	///<summary>The quality level of the deformer. A value of 0 is the highest quality, 1 is a step lower, etc.</summary>
	public  void SetQualityLevel(int InQualityLevel) {}
	///<summary>The quality level of the deformer. A value of 0 is the highest quality, 1 is a step lower, etc.</summary>
	public  int GetQualityLevel() { return default; }
	///<summary>Get the ML Deformer asset that is used by this component.</summary>
	public  UMLDeformerAsset GetDeformerAsset() { return default; }
	///<summary>Set the deformer asset that is used by this component.</summary>
	public  void SetDeformerAsset(UMLDeformerAsset InDeformerAsset) {}
	///<summary>Find the skeletal mesh component to apply the deformer on.</summary>
	public  USkeletalMeshComponent FindSkeletalMeshComponent(UMLDeformerAsset Asset) { return default; }
	///<summary>Get the skeletal mesh component that the ML Deformer will work on.</summary>
	public  USkeletalMeshComponent GetSkeletalMeshComponent() { return default; }
	///<summary>Find the skeletal mesh component that this deformer should work on, and set it as our target component.</summary>
	public  void UpdateSkeletalMeshComponent() {}
	///<summary>The deformer asset to use.</summary>
	public UMLDeformerAsset DeformerAsset;
	///<summary>How active is this deformer? Can be used to blend it in and out.</summary>
	public float Weight;
	///<summary>The quality level of the deformer. A value of 0 is the highest quality, 1 is a step lower, etc.</summary>
	public int QualityLevel;
	///<summary>The deformation model instance. This is used to perform the runtime updates and run the inference.</summary>
	public UMLDeformerModelInstance ModelInstance;
}
