#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This node defines a list of layers inside the scene. The layer is a container of graphical objects defining a local coordinate system.</summary>
[CppInclude("MVR/Types/DMXMVRLayersNode.h")]
public partial class UDMXMVRLayersNode : UObject {
	///<summary>A[n array of] layer representation[s].</summary>
	public TArray<UDMXMVRLayerNode> LayerNodes;
}
