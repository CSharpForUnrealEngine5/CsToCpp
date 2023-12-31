namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/SoundSourceEffectFactory.h")]
public partial class USoundSourceEffectFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The type of sound source effect preset that will be created</summary>
	public UClass SoundEffectSourcepresetClass;
}
