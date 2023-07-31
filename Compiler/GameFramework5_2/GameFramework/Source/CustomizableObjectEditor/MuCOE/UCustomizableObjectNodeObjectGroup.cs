#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeObjectGroup.h")]
public partial class UCustomizableObjectNodeObjectGroup : UCustomizableObjectNode {
	///<summary>GroupName</summary>
	public string GroupName;
	///<summary>GroupType</summary>
	public ECustomizableObjectGroupType GroupType;
	///<summary>ParamUIMetadata</summary>
	public FMutableParamUIMetadata ParamUIMetadata;
	///<summary>The sockets defined in meshes deriving from this node will inherit this socket priority. When in the generated merged mesh there</summary>
	public int SocketPriority;
}
