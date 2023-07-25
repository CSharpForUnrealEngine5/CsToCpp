#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Scene.h")]
public partial struct FLensBloomSettings {
// LensBloomSettings
	public FGaussianSumBloomSettings GaussianSum;
	public FConvolutionBloomSettings Convolution;
	public byte Method;
}
