namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionNoise.h")]
public enum ENoiseFunction {
	NOISEFUNCTION_SimplexTex=0,
	NOISEFUNCTION_GradientTex=1,
	NOISEFUNCTION_GradientTex3D=2,
	NOISEFUNCTION_GradientALU=3,
	NOISEFUNCTION_ValueALU=4,
	NOISEFUNCTION_VoronoiALU=5,
	NOISEFUNCTION_MAX=6,
}
