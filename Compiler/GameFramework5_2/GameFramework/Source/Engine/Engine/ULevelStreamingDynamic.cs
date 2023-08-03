#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/LevelStreamingDynamic.h")]
public partial class ULevelStreamingDynamic : ULevelStreaming {
	public static UClass StaticClass() {return default;}
	///<summary>Whether the level should be loaded at startup</summary>
	public bool bInitiallyLoaded;
	///<summary>Whether the level should be visible at startup if it is loaded</summary>
	public bool bInitiallyVisible;
	///<summary>Stream in a level with a specific location and rotation. You can create multiple instances of the same level!</summary>
	public static ULevelStreamingDynamic LoadLevelInstance(UObject WorldContextObject,string LevelName,FVector Location,FRotator Rotation,bool bOutSuccess,string OptionalLevelNameOverride/*=TEXT("")*/,UClass OptionalLevelStreamingClass/*=nullptr*/,bool bLoadAsTempPackage/*=false*/) { return default; }
	///<summary>LoadLevelInstanceBySoftObjectPtr</summary>
	public static ULevelStreamingDynamic LoadLevelInstanceBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,FVector Location,FRotator Rotation,bool bOutSuccess,string OptionalLevelNameOverride/*=TEXT("")*/,UClass OptionalLevelStreamingClass/*=nullptr*/,bool bLoadAsTempPackage/*=false*/) { return default; }
}
