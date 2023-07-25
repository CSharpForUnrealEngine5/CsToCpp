#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundSubmixGraph/SoundSubmixGraph.h")]
public partial class USoundSubmixGraph : UEdGraph {
// SoundSubmixGraph
	public USoundSubmixBase RootSoundSubmix;
	public TArray<USoundSubmixBase> StaleRoots;
}
