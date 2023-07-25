#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialCachedData.h")]
///<summary>Stores information about a function that this material references, used to know when the material needs to be recompiled.</summary>
public partial struct FMaterialFunctionInfo {
// MaterialFunctionInfo
	public FGuid StateId;
	public UMaterialFunctionInterface Function;
}
