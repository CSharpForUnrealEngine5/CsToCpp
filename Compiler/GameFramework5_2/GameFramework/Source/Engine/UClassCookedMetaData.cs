#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CookedMetaData.h")]
///<summary>Cooked meta-data for a UClass, including its nested FProperty and UFunction data.</summary>
public partial class UClassCookedMetaData : UObject {
// ClassCookedMetaData
	public FStructCookedMetaDataStore ClassMetaData;
	public TMap<string,FStructCookedMetaDataStore> FunctionsMetaData;
}
