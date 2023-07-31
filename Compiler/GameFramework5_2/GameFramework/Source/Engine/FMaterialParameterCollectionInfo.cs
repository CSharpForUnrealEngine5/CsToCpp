#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores information about a parameter collection that this material references, used to know when the material needs to be recompiled.</summary>
[CppInclude("MaterialCachedData.h")]
public partial struct FMaterialParameterCollectionInfo {
	public FGuid StateId;
	public UMaterialParameterCollection ParameterCollection;
}
