namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores information about a function that this material references, used to know when the material needs to be recompiled.</summary>
[CppInclude("MaterialCachedData.h")]
public partial struct FMaterialFunctionInfo {
	public FGuid StateId;
	public UMaterialFunctionInterface Function;
}
