#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundCueTemplateFactory.h")]
public partial class USoundCueTemplateFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>SoundCueTemplateClass</summary>
	public UClass SoundCueTemplateClass;
	///<summary>SoundWaves</summary>
	public TArray<TWeakObjectPtr<USoundWave>> SoundWaves;
}
