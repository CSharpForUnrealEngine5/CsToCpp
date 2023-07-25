#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ShaderCookerStats.h")]
///<summary>Statistics page for shader cooker stats.</summary>
public partial class UShaderCookerStats : UObject {
// ShaderCookerStats
	public string Name;
	public string Platform;
	public string Category;
	public int Compiled;
	public int Cooked;
	public int Permutations;
	public float CompileTime;
	public string Path;
}
