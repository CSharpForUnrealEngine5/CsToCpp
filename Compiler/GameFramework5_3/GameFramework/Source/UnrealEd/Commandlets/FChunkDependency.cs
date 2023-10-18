namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single dependency, read from ini file</summary>
[CppInclude("Commandlets/ChunkDependencyInfo.h")]
public partial struct FChunkDependency {
	public int ChunkID;
	public int ParentChunkID;
}
