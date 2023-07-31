#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This node defines logical group of objects. The child objects are located inside a local coordinate system.</summary>
[CppInclude("MVR/Types/DMXMVRGroupObjectNode.h")]
public partial class UDMXMVRGroupObjectNode : UDMXMVRParametricObjectNodeBase {
	///<summary>The name of the GroupObject</summary>
	public FDMXOptionalString Name;
	///<summary>A list of graphic objects that are part of the group.</summary>
	public UDMXMVRChildListNode ChildListNode;
}
