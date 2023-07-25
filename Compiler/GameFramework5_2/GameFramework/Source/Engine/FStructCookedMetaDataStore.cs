#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CookedMetaData.h")]
///<summary>Cooked meta-data for a UStruct, including its nested FProperty data.</summary>
public partial struct FStructCookedMetaDataStore {
// StructCookedMetaDataStore
	public FObjectCookedMetaDataStore ObjectMetaData;
	public TMap<string,FFieldCookedMetaDataStore> PropertiesMetaData;
}
