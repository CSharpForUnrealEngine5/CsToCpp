namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>hold template informations common to all AActors.</summary>
[CppInclude("ObjectTemplates/DatasmithActorTemplate.h")]
public partial class UDatasmithActorTemplate : UDatasmithObjectTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>Layers this actor belongs to. (see AActor::Layers)</summary>
	public TSet<FName> Layers;
	///<summary>Tags on this actor. (see AActor::Tags)</summary>
	public TSet<FName> Tags;
}
