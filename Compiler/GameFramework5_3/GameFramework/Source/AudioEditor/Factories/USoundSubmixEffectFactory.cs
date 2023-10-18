namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/SoundSubmixEffectFactory.h")]
public partial class USoundSubmixEffectFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The type of sound source effect preset that will be created</summary>
	public UClass SoundEffectSubmixPresetClass;
}
