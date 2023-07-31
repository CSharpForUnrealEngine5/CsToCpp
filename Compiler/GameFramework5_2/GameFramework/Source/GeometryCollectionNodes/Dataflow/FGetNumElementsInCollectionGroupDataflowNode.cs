#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns number of elements in a group in a Collection</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FGetNumElementsInCollectionGroupDataflowNode {
	public FManagedArrayCollection Collection;
	public EStandardGroupNameEnum GroupName;
	public string CustomGroupName;
	public int NumElements;
}
