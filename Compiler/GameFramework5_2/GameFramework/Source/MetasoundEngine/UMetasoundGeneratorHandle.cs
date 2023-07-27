#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundGeneratorHandle.h")]
public partial class UMetasoundGeneratorHandle : UObject {
// MetasoundGeneratorHandle
	public static UMetasoundGeneratorHandle CreateMetaSoundGeneratorHandle(UAudioComponent OnComponent) { return default; }
	public  bool ApplyParameterPack(UMetasoundParameterPack Pack) { return default; }
	public UAudioComponent AudioComponent;
	public UMetaSoundSource CachedMetasoundSource;
}
