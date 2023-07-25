#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeTool.h")]
///<summary>Bake map enums</summary>
public enum EBakeMapType {
	None=0,
	TangentSpaceNormal=-1,
	ObjectSpaceNormal=-1,
	FaceNormal=-1,
	BentNormal=-1,
	Position=-1,
	Curvature=-1,
	AmbientOcclusion=-1,
	Texture=-1,
	MultiTexture=-1,
	VertexColor=-1,
	MaterialID=-1,
	All=2047,
}
