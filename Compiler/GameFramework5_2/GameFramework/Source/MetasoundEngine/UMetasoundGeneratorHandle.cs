#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundGeneratorHandle.h")]
public partial class UMetasoundGeneratorHandle : UObject {
	///<summary>CreateMetaSoundGeneratorHandle</summary>
	public static UMetasoundGeneratorHandle CreateMetaSoundGeneratorHandle(UAudioComponent OnComponent) { return default; }
	///<summary>Makes a copy of the supplied parameter pack and passes it to the MetaSoundGenerator</summary>
	public  bool ApplyParameterPack(UMetasoundParameterPack Pack) { return default; }
	///<summary>AudioComponent</summary>
	public UAudioComponent AudioComponent;
	///<summary>CachedMetasoundSource</summary>
	public UMetaSoundSource CachedMetasoundSource;
}
