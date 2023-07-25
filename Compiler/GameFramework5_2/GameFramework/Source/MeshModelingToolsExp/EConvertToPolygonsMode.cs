#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConvertToPolygonsTool.h")]
public enum EConvertToPolygonsMode {
	FaceNormalDeviation=0,
	FindPolygons=1,
	FromUVIslands=2,
	FromNormalSeams=3,
	FromConnectedTris=4,
	FromFurthestPointSampling=5,
	CopyFromLayer=6,
}
