#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FoliageTypeObject.h")]
///<summary>A wrapper struct used to allow the use of either FoliageType assets or FoliageType blueprint classes</summary>
public partial struct FFoliageTypeObject {
// FoliageTypeObject
	public UObject FoliageTypeObject;
	public UFoliageType TypeInstance;
	public bool bIsAsset;
	public UClass Type_DEPRECATED;
}
