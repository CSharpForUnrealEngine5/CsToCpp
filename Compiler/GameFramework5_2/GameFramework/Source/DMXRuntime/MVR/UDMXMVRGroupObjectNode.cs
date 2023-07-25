#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVR/Types/DMXMVRGroupObjectNode.h")]
///<summary>This node defines logical group of objects. The child objects are located inside a local coordinate system.</summary>
public partial class UDMXMVRGroupObjectNode : UDMXMVRParametricObjectNodeBase {
// DMXMVRGroupObjectNode
	public FDMXOptionalString Name;
	public UDMXMVRChildListNode ChildListNode;
}
