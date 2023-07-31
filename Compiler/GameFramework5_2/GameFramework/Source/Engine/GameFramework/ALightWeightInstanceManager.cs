#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/LightWeightInstanceManager.h")]
public partial class ALightWeightInstanceManager : AActor {
	///<summary>RepresentedClass</summary>
	public UClass RepresentedClass;
	///<summary>AcceptedClass</summary>
	public UClass AcceptedClass;
	///<summary>Current per instance transforms</summary>
	public TArray<FTransform> InstanceTransforms;
	///<summary>OnRep_Transforms</summary>
	public  void OnRep_Transforms() {}
	///<summary>list of indices that we are no longer using</summary>
	public TArray<int> FreeIndices;
	///<summary>handy way to check indices quickly so we don&#39;t need to iterate through the free indices list</summary>
	public TArray<bool> ValidIndices;
}
