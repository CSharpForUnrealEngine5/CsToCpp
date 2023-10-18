namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cooked meta-data for a UEnum.</summary>
[CppInclude("CookedMetaData.h")]
public partial class UEnumCookedMetaData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>EnumMetaData</summary>
	public FObjectCookedMetaDataStore EnumMetaData;
}
