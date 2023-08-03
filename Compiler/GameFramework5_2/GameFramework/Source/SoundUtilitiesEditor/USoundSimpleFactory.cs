#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundSimpleFactory.h")]
public partial class USoundSimpleFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Sound waves to create the simple sound with</summary>
	public TArray<USoundWave> SoundWaves;
}
