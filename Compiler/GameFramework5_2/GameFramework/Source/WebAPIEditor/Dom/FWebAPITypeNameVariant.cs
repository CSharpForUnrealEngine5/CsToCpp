#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds either UWebAPITypeInfo or FString.</summary>
[CppInclude("Dom/WebAPISchema.h")]
public partial struct FWebAPITypeNameVariant {
	public TSoftObjectPtr<UWebAPITypeInfo> TypeInfo;
	public string TypeString;
	public string JsonName;
}
