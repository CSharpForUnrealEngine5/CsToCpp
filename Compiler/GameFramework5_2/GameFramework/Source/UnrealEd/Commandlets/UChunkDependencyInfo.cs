#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is read out of config and defines a tree of chunk dependencies</summary>
[CppInclude("Commandlets/ChunkDependencyInfo.h")]
public partial class UChunkDependencyInfo : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>List of dependencies used to remove redundant chunks</summary>
	public TArray<FChunkDependency> DependencyArray;
}
