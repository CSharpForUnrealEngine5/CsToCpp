namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a delay</summary>
[CppInclude("Sound/SoundNodeDelay.h")]
public partial class USoundNodeDelay : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>The lower bound of delay time in seconds.</summary>
	public float DelayMin;
	///<summary>The upper bound of delay time in seconds.</summary>
	public float DelayMax;
}
