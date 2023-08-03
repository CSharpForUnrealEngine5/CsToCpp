#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundSubmixGraph/SoundSubmixGraphNode.h")]
public partial class USoundSubmixGraphNode : UEdGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>The SoundSubmix this represents</summary>
	public USoundSubmixBase SoundSubmix;
	///<summary>A user widget to use to represent the graph node</summary>
	public UUserWidget SubmixNodeUserWidget;
}
