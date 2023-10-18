namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassLWISubsystem.h")]
public partial class UMassLWISubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>RegisteredManagers</summary>
	public TArray<AMassLWIStaticMeshManager> RegisteredManagers;
	///<summary>DefaultConfig</summary>
	public FMassEntityConfig DefaultConfig;
	///<summary>LWISpawnerSubsystem</summary>
	public UMassLWIClientActorSpawnerSubsystem LWISpawnerSubsystem;
}
