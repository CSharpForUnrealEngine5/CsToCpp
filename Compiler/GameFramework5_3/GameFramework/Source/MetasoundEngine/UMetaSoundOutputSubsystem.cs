namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provides access to a playing Metasound generator&#39;s outputs</summary>
[CppInclude("MetasoundOutputSubsystem.h")]
public partial class UMetaSoundOutputSubsystem : UTickableWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Watch an output on a Metasound playing on a given audio component.</summary>
	public bool WatchOutput(UAudioComponent AudioComponent,FName OutputName,FOnMetasoundOutputValueChanged OnOutputValueChanged,FName AnalyzerName/*=NAME_None*/,FName AnalyzerOutputName/*=NAME_None*/) { return default; }
	///<summary>TrackedGenerators</summary>
	public TArray<UMetasoundGeneratorHandle> TrackedGenerators;
}
