#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Root object for all level actors</summary>
[CppInclude("Engine/LevelActorContainer.h")]
public partial class ULevelActorContainer : UObject {
	///<summary>Array of actors in a level</summary>
	public TArray<AActor> Actors;
}
