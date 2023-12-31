namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundSubmixGraph/SoundSubmixGraph.h")]
public partial class USoundSubmixGraph : UEdGraph {
	public static UClass StaticClass() {return default;}
	///<summary>SoundSubmix which forms the root of this graph</summary>
	public USoundSubmixBase RootSoundSubmix;
	///<summary>StaleRoots</summary>
	public TArray<USoundSubmixBase> StaleRoots;
}
