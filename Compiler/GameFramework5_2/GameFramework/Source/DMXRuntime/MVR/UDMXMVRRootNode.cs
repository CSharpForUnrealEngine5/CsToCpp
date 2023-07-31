#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The root node of an MVR General Scene Description as typically held in an MVR&#39;s GeneralSceneDescription.xml.</summary>
[CppInclude("MVR/Types/DMXMVRRootNode.h")]
public partial class UDMXMVRRootNode : UObject {
	///<summary>This node contains a collection of user data nodes defined and used by provider applications if required.</summary>
	public UDMXMVRUserDataNode UserDataNode;
	///<summary>This node contains information about the scene.</summary>
	public UDMXMVRSceneNode SceneNode;
}
