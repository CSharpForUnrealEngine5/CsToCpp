#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundSubmixGraph/SoundSubmixGraph.h")]
public partial class USoundSubmixGraph : UEdGraph {
	///<summary>SoundSubmix which forms the root of this graph</summary>
	public USoundSubmixBase RootSoundSubmix;
	///<summary>StaleRoots</summary>
	public TArray<USoundSubmixBase> StaleRoots;
}
