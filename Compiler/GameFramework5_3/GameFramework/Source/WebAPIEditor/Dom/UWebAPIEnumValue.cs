namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a single value within a enum.</summary>
[CppInclude("Dom/WebAPIEnum.h")]
public partial class UWebAPIEnumValue : UWebAPIModelBase {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the EnumValue.</summary>
	public FWebAPINameVariant Name;
}
