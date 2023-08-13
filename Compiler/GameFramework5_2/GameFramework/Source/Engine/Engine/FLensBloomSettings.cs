namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Scene.h")]
public partial struct FLensBloomSettings {
	public FGaussianSumBloomSettings GaussianSum;
	public FConvolutionBloomSettings Convolution;
	public EBloomMethod Method;
}
