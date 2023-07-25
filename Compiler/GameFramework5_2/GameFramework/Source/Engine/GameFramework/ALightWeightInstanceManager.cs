#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/LightWeightInstanceManager.h")]
public partial class ALightWeightInstanceManager : AActor {
// LightWeightInstanceManager
	public UClass RepresentedClass;
	public UClass AcceptedClass;
	public TArray<FTransform> InstanceTransforms;
	public void OnRep_Transforms() {}
	public TArray<int> FreeIndices;
	public TArray<bool> ValidIndices;
}
