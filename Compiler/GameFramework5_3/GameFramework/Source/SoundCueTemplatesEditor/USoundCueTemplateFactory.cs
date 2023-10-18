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
