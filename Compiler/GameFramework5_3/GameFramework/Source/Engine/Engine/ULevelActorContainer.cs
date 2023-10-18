namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Root object for all level actors</summary>
[CppInclude("Engine/LevelActorContainer.h")]
public partial class ULevelActorContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Array of actors in a level</summary>
	public TArray<AActor> Actors;
}
