namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundClassGraph/SoundClassGraphNode.h")]
public partial class USoundClassGraphNode : UEdGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>The SoundNode this represents</summary>
	public USoundClass SoundClass;
}
