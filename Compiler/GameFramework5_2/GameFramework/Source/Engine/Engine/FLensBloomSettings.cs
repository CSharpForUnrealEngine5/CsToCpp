#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Scene.h")]
public partial struct FLensBloomSettings {
	public FGaussianSumBloomSettings GaussianSum;
	public FConvolutionBloomSettings Convolution;
	public EBloomMethod Method;
}
