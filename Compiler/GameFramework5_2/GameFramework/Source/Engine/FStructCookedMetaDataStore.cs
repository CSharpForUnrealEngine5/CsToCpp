namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cooked meta-data for a UStruct, including its nested FProperty data.</summary>
[CppInclude("CookedMetaData.h")]
public partial struct FStructCookedMetaDataStore {
	public FObjectCookedMetaDataStore ObjectMetaData;
	public TMap<string,FFieldCookedMetaDataStore> PropertiesMetaData;
}
