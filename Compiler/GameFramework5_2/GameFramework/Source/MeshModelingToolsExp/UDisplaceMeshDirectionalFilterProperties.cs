#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplaceMeshTool.h")]
///<summary>Properties for a directional filter. Allows for displacement to be applied only to vertices whose normals point in a given direction</summary>
public partial class UDisplaceMeshDirectionalFilterProperties : UInteractiveToolPropertySet {
// DisplaceMeshDirectionalFilterProperties
	public bool bEnableFilter;
	public FVector FilterDirection;
	public float FilterWidth;
}
