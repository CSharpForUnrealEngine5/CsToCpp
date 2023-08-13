namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor container class used to duplicate actors during cells streaming in PIE</summary>
[CppInclude("Engine/Level.h")]
public partial class UActorContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Actors</summary>
	public TMap<string,AActor> Actors;
}
