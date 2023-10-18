namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class which contains a simple list of sound wave variations</summary>
[CppInclude("SoundSimple.h")]
public partial class USoundSimple : USoundBase {
	public static UClass StaticClass() {return default;}
	///<summary>List of variations for the simple sound</summary>
	public TArray<FSoundVariation> Variations;
	///<summary>The current chosen sound wave</summary>
	public USoundWave SoundWave;
}
