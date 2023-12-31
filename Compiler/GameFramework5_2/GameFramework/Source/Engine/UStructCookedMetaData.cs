namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cooked meta-data for a UScriptStruct, including its nested FProperty data.</summary>
[CppInclude("CookedMetaData.h")]
public partial class UStructCookedMetaData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>StructMetaData</summary>
	public FStructCookedMetaDataStore StructMetaData;
}
