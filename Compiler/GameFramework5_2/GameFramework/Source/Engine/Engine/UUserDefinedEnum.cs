namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An Enumeration is a list of named values.</summary>
[CppInclude("Engine/UserDefinedEnum.h")]
public partial class UUserDefinedEnum : UEnum {
	public static UClass StaticClass() {return default;}
	///<summary>UniqueNameIndex</summary>
	public uint UniqueNameIndex;
	///<summary>Shows up in the content browser when the enum asset is hovered</summary>
	public FText EnumDescription;
	///<summary>De-facto display names for enum entries mapped against their raw enum name (UEnum::GetNameByIndex).</summary>
	public TMap<FName,FText> DisplayNameMap;
	///<summary>CachedCookedMetaDataPtr</summary>
	public UEnumCookedMetaData CachedCookedMetaDataPtr;
}
