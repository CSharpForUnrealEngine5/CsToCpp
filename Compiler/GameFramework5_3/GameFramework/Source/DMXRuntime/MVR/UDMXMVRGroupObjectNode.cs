namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This node defines logical group of objects. The child objects are located inside a local coordinate system.</summary>
[CppInclude("MVR/Types/DMXMVRGroupObjectNode.h")]
public partial class UDMXMVRGroupObjectNode : UDMXMVRParametricObjectNodeBase {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the GroupObject</summary>
	public FDMXOptionalString Name;
	///<summary>A list of graphic objects that are part of the group.</summary>
	public UDMXMVRChildListNode ChildListNode;
}
