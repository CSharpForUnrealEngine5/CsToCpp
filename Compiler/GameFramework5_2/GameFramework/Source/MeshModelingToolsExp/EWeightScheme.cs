#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DeformMeshPolygonsTool.h")]
///<summary>Laplacian weight schemes determine how we will look at the curvature at a given vertex in relation to its neighborhood</summary>
public enum EWeightScheme {
	Uniform=0,
	Umbrella=1,
	Valence=2,
	MeanValue=3,
	Cotangent=4,
	ClampedCotangent=5,
	IDTCotangent=6,
}
