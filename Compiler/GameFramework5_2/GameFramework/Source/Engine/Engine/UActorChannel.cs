#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A channel for exchanging actor and its subobject&#39;s properties and RPCs.</summary>
[CppInclude("Engine/ActorChannel.h")]
public partial class UActorChannel : UChannel {
	public static UClass StaticClass() {return default;}
	///<summary>Variables.</summary>
	public AActor Actor;
	///<summary>CreateSubObjects</summary>
	public TArray<UObject> CreateSubObjects;
}
