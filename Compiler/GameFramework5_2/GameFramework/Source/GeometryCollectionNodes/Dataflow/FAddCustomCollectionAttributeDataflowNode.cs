namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds custom attribute to Collection</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FAddCustomCollectionAttributeDataflowNode {
	public FManagedArrayCollection Collection;
	public EStandardGroupNameEnum GroupName;
	public string CustomGroupName;
	public string AttrName;
	public ECustomAttributeTypeEnum CustomAttributeType;
	public int NumElements;
}
