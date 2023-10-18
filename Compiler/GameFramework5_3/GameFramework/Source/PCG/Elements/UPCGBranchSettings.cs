namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Routes input data to one of two outputs,based on a boolean condition.</summary>
[CppInclude("Elements/PCGBranch.h")]
public partial class UPCGBranchSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>bOutputToB</summary>
	public bool bOutputToB;
}
