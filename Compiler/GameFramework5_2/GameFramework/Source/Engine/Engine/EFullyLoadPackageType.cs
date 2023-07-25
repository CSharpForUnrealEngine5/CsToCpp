#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
///<summary>Enumerates types of fully loaded packages.</summary>
public enum EFullyLoadPackageType {
	FULLYLOAD_Map=0,
	FULLYLOAD_Game_PreLoadClass=1,
	FULLYLOAD_Game_PostLoadClass=2,
	FULLYLOAD_Always=3,
	FULLYLOAD_Mutator=4,
	FULLYLOAD_MAX=5,
}
