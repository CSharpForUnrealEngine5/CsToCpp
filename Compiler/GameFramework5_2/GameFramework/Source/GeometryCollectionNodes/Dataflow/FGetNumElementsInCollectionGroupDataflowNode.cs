#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Returns number of elements in a group in a Collection</summary>
public partial struct FGetNumElementsInCollectionGroupDataflowNode {
// GetNumElementsInCollectionGroupDataflowNode
	public FManagedArrayCollection Collection;
	public EStandardGroupNameEnum GroupName;
	public string CustomGroupName;
	public int NumElements;
}
