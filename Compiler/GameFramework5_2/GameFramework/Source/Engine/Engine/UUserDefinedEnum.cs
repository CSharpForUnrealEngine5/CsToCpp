#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/UserDefinedEnum.h")]
///<summary>An Enumeration is a list of named values.</summary>
public partial class UUserDefinedEnum : UEnum {
// UserDefinedEnum
	public uint UniqueNameIndex;
	public string EnumDescription;
	public TMap<string,string> DisplayNameMap;
	public UEnumCookedMetaData CachedCookedMetaDataPtr;
}
