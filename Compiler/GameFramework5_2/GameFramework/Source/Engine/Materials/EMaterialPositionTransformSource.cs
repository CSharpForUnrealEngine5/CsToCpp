#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTransformPosition.h")]
public enum EMaterialPositionTransformSource {
	TRANSFORMPOSSOURCE_Local=0,
	TRANSFORMPOSSOURCE_World=1,
	TRANSFORMPOSSOURCE_TranslatedWorld=2,
	TRANSFORMPOSSOURCE_View=3,
	TRANSFORMPOSSOURCE_Camera=4,
	TRANSFORMPOSSOURCE_Particle=5,
	TRANSFORMPOSSOURCE_Instance=6,
	TRANSFORMPOSSOURCE_MAX=7,
}
