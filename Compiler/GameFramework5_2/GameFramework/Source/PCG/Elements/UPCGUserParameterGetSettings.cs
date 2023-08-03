#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Getter for user parameters defined in PCGGraph, by the user.</summary>
[CppInclude("Elements/PCGUserParameterGet.h")]
public partial class UPCGUserParameterGetSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>PropertyGuid</summary>
	public FGuid PropertyGuid;
	///<summary>PropertyName</summary>
	public string PropertyName;
}
