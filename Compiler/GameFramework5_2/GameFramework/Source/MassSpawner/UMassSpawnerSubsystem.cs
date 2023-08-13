namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassSpawnerSubsystem.h")]
public partial class UMassSpawnerSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>SpawnDataInitializers</summary>
	public TArray<UMassProcessor> SpawnDataInitializers;
}
