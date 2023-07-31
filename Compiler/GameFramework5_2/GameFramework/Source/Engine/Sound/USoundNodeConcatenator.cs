#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Plays child nodes sequentially</summary>
[CppInclude("Sound/SoundNodeConcatenator.h")]
public partial class USoundNodeConcatenator : USoundNode {
	///<summary>Volume multiplier for each input.</summary>
	public TArray<float> InputVolume;
}
