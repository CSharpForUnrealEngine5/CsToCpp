namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassLWIClientActorSpawnerSubsystem.h")]
public partial class UMassLWIClientActorSpawnerSubsystem : UMassActorSpawnerSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>PendingActors</summary>
	public TMap<UClass,FMassStoredActorsContainer> PendingActors;
}
