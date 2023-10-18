namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundSimpleFactory.h")]
public partial class USoundSimpleFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Sound waves to create the simple sound with</summary>
	public TArray<USoundWave> SoundWaves;
}
