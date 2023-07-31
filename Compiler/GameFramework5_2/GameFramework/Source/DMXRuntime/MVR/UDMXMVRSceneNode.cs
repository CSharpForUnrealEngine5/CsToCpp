#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This node contains information about the scene.</summary>
[CppInclude("MVR/Types/DMXMVRSceneNode.h")]
public partial class UDMXMVRSceneNode : UObject {
	///<summary>This node defines a list of layers inside the scene. The layer is a container of graphical objects defining a local coordinate system.</summary>
	public UDMXMVRLayersNode LayersNode;
}
