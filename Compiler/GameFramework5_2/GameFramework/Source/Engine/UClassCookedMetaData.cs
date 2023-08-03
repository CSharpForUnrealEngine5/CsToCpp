#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cooked meta-data for a UClass, including its nested FProperty and UFunction data.</summary>
[CppInclude("CookedMetaData.h")]
public partial class UClassCookedMetaData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ClassMetaData</summary>
	public FStructCookedMetaDataStore ClassMetaData;
	///<summary>FunctionsMetaData</summary>
	public TMap<string,FStructCookedMetaDataStore> FunctionsMetaData;
}
