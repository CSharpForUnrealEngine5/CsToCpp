#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor container class used to duplicate actors during cells streaming in PIE</summary>
[CppInclude("Engine/Level.h")]
public partial class UActorContainer : UObject {
	///<summary>Actors</summary>
	public TMap<string,AActor> Actors;
}
