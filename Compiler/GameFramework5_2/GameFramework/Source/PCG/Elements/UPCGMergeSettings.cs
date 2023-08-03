#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Merges multiple data sources (currently only points supported) into a single output.</summary>
[CppInclude("Elements/PCGMergeElement.h")]
public partial class UPCGMergeSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Controls whether the resulting merge data will have any metadata</summary>
	public bool bMergeMetadata;
}
