#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PCG Data meant only to be used internally.</summary>
[CppInclude("Data/PCGUserParametersData.h")]
public partial class UPCGUserParametersData : UPCGData {
	public static UClass StaticClass() {return default;}
	///<summary>~End UPCGData interface</summary>
	public UPCGGraphInterface OriginalGraph;
	///<summary>UserParameters</summary>
	public FInstancedStruct UserParameters;
}
