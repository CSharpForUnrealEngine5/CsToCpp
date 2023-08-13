namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A wrapper struct used to allow the use of either FoliageType assets or FoliageType blueprint classes</summary>
[CppInclude("FoliageTypeObject.h")]
public partial struct FFoliageTypeObject {
	public UObject FoliageTypeObject;
	public UFoliageType TypeInstance;
	public bool bIsAsset;
	public UClass Type_DEPRECATED;
}
