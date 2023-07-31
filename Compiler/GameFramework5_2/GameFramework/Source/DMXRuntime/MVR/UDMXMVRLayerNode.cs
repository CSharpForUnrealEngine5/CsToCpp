#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Layer node in the Layers Node of a Scene.</summary>
[CppInclude("MVR/Types/DMXMVRLayerNode.h")]
public partial class UDMXMVRLayerNode : UObject {
	///<summary>The unique identifier of the object.</summary>
	public FGuid UUID;
	///<summary>The name of the object</summary>
	public FDMXOptionalString Name;
	///<summary>The transformation matrix that defines the location and orientation of this the layer inside its global coordinate space.</summary>
	public FDMXOptionalTransform Matrix;
	///<summary>A list of graphic objects that are part of the group.</summary>
	public UDMXMVRChildListNode ChildListNode;
}
