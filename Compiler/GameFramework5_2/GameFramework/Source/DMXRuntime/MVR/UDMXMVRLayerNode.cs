#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVR/Types/DMXMVRLayerNode.h")]
///<summary>A Layer node in the Layers Node of a Scene.</summary>
public partial class UDMXMVRLayerNode : UObject {
// DMXMVRLayerNode
	public FGuid UUID;
	public FDMXOptionalString Name;
	public FDMXOptionalTransform Matrix;
	public UDMXMVRChildListNode ChildListNode;
}
