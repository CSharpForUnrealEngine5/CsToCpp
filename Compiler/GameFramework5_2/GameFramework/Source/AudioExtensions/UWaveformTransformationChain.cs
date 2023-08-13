namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object that holds an ordered list of transformations to perform on a sound wave</summary>
[CppInclude("IWaveformTransformation.h")]
public partial class UWaveformTransformationChain : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Transformations</summary>
	public TArray<UWaveformTransformationBase> Transformations;
}
