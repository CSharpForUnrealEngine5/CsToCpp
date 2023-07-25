#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPISchema.h")]
///<summary>Holds either UWebAPITypeInfo or FString.</summary>
public partial struct FWebAPITypeNameVariant {
// WebAPITypeNameVariant
	public TSoftObjectPtr<UWebAPITypeInfo> TypeInfo;
	public string TypeString;
	public string JsonName;
}
