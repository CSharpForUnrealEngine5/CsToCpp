#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Get attribute data from a Collection</summary>
public partial struct FGetCollectionAttributeDataTypedDataflowNode {
// GetCollectionAttributeDataTypedDataflowNode
	public FManagedArrayCollection Collection;
	public EStandardGroupNameEnum GroupName;
	public string CustomGroupName;
	public string AttrName;
	public TArray<bool> BoolAttributeData;
	public TArray<float> FloatAttributeData;
	public TArray<double> DoubleAttributeData;
	public TArray<int> Int32AttributeData;
	public TArray<string> StringAttributeData;
	public TArray<FVector3f> Vector3fAttributeData;
	public TArray<FVector3d> Vector3dAttributeData;
}
