namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTransform.h")]
public enum EMaterialVectorCoordTransformSource {
	TRANSFORMSOURCE_Tangent=0,
	TRANSFORMSOURCE_Local=1,
	TRANSFORMSOURCE_World=2,
	TRANSFORMSOURCE_View=3,
	TRANSFORMSOURCE_Camera=4,
	TRANSFORMSOURCE_ParticleWorld=5,
	TRANSFORMSOURCE_Instance=6,
	TRANSFORMSOURCE_MAX=7,
}
