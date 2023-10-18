namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexSculptTool.h")]
///<summary>Mesh Sculpting Brush Types</summary>
public enum EMeshVertexSculptBrushType {
	Move=0,
	PullKelvin=1,
	PullSharpKelvin=2,
	Smooth=3,
	SmoothFill=4,
	Offset=5,
	SculptView=6,
	SculptMax=7,
	Inflate=8,
	ScaleKelvin=9,
	Pinch=10,
	TwistKelvin=11,
	Flatten=12,
	Plane=13,
	PlaneViewAligned=14,
	FixedPlane=15,
	LastValue=16,
}
