#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundClass.h")]
public partial class USoundClass : UObject {
// SoundClass
	public FSoundClassProperties Properties;
	public TArray<USoundClass> ChildClasses;
	public TArray<FPassiveSoundMixModifier> PassiveSoundMixModifiers;
	public USoundClass ParentClass;
}
