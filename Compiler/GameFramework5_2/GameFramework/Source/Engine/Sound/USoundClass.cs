#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundClass.h")]
public partial class USoundClass : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Configurable properties like volume and priority.</summary>
	public FSoundClassProperties Properties;
	///<summary>ChildClasses</summary>
	public TArray<USoundClass> ChildClasses;
	///<summary>SoundMix Modifiers to activate automatically when a sound of this class is playing.</summary>
	public TArray<FPassiveSoundMixModifier> PassiveSoundMixModifiers;
	///<summary>ParentClass</summary>
	public USoundClass ParentClass;
}
