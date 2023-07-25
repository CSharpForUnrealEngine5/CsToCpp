#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IWaveformTransformation.h")]
///<summary>Object that holds an ordered list of transformations to perform on a sound wave</summary>
public partial class UWaveformTransformationChain : UObject {
// WaveformTransformationChain
	public TArray<UWaveformTransformationBase> Transformations;
}
