#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class which contains a simple list of sound wave variations</summary>
[CppInclude("SoundSimple.h")]
public partial class USoundSimple : USoundBase {
	///<summary>List of variations for the simple sound</summary>
	public TArray<FSoundVariation> Variations;
	///<summary>The current chosen sound wave</summary>
	public USoundWave SoundWave;
}
