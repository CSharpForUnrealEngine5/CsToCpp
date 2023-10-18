namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundGeneratorHandle.h")]
public partial class UMetasoundGeneratorHandle : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CreateMetaSoundGeneratorHandle</summary>
	public static UMetasoundGeneratorHandle CreateMetaSoundGeneratorHandle(UAudioComponent OnComponent) { return default; }
	///<summary>Makes a copy of the supplied parameter pack and passes it to the MetaSoundGenerator</summary>
	public bool ApplyParameterPack(UMetasoundParameterPack Pack) { return default; }
	///<summary>Watch an output value.</summary>
	public bool WatchOutput(FName OutputName,FOnMetasoundOutputValueChanged OnOutputValueChanged,FName AnalyzerName/*=NAME_None*/,FName AnalyzerOutputName/*=NAME_None*/) { return default; }
	///<summary>Multicast delegate to broadcast to users calling WatchOutput</summary>
	public void FOnOutputValueChangedMulticast(FName Name,FMetaSoundOutput Output) {}
}
