namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/SubUVAnimation.h")]
///<summary>More bounding vertices results in reduced overdraw, but adds more triangle overhead.</summary>
public enum ESubUVBoundingVertexCount {
	BVC_FourVertices=0,
	BVC_EightVertices=1,
}
