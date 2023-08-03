#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGManagedResource.h")]
public partial class UPCGManagedISMComponent : UPCGManagedComponent {
	public static UClass StaticClass() {return default;}
	///<summary>bHasDescriptor</summary>
	public bool bHasDescriptor;
	///<summary>Descriptor</summary>
	public FISMComponentDescriptor Descriptor;
	///<summary>SettingsUID</summary>
	public ulong SettingsUID;
}
