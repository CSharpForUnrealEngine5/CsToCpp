namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/BaseDynamicMeshComponent.h")]
///<summary>Color Transform to apply to Vertex Colors when converting from internal DynamicMesh</summary>
public enum EDynamicMeshVertexColorTransformMode {
	NoTransform=0,
	LinearToSRGB=1,
	SRGBToLinear=2,
}
