#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set attribute data in a Collection</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FSetCollectionAttributeDataTypedDataflowNode {
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
