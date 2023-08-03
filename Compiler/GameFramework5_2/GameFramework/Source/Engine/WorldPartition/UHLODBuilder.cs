#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all HLOD builders</summary>
[CppInclude("WorldPartition/HLOD/HLODBuilder.h")]
public partial class UHLODBuilder : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>HLODBuilderSettings</summary>
	public UHLODBuilderSettings HLODBuilderSettings;
}
