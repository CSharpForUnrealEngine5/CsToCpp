#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Adds custom attribute to Collection</summary>
public partial struct FAddCustomCollectionAttributeDataflowNode {
// AddCustomCollectionAttributeDataflowNode
	public FManagedArrayCollection Collection;
	public EStandardGroupNameEnum GroupName;
	public string CustomGroupName;
	public string AttrName;
	public ECustomAttributeTypeEnum CustomAttributeType;
	public int NumElements;
}
