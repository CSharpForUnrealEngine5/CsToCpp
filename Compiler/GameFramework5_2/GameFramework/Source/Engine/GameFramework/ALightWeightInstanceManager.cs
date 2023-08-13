namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/LightWeightInstanceManager.h")]
public partial class ALightWeightInstanceManager : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>RepresentedClass</summary>
	public UClass RepresentedClass;
	///<summary>AcceptedClass</summary>
	public UClass AcceptedClass;
	///<summary>Current per instance transforms</summary>
	public TArray<FTransform> InstanceTransforms;
	///<summary>OnRep_Transforms</summary>
	public virtual void OnRep_Transforms() {}
	///<summary>list of indices that we are no longer using</summary>
	public TArray<int> FreeIndices;
	///<summary>handy way to check indices quickly so we don&#39;t need to iterate through the free indices list</summary>
	public TArray<bool> ValidIndices;
}
