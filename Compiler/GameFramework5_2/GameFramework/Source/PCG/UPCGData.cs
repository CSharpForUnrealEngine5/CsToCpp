#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for any &quot;data&quot; class in the PCG framework.</summary>
[CppInclude("PCGData.h")]
public partial class UPCGData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Unique ID for this object instance.</summary>
	public ulong UID;
}
