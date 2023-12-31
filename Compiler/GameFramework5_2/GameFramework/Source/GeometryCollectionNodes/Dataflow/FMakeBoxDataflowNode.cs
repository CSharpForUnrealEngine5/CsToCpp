namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Description for this node</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FMakeBoxDataflowNode {
	public EMakeBoxDataTypeEnum DataType;
	public FVector Min;
	public FVector Max;
	public FVector Center;
	public FVector Size;
	public FBox Box;
}
