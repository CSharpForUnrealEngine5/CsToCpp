namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGManagedResource.h")]
public partial class UPCGManagedISMComponent : UPCGManagedComponent {
	public static UClass StaticClass() {return default;}
	///<summary>bHasDescriptor</summary>
	public bool bHasDescriptor;
	///<summary>Descriptor</summary>
	public FISMComponentDescriptor Descriptor;
	///<summary>bHasRootLocation</summary>
	public bool bHasRootLocation;
	///<summary>RootLocation</summary>
	public FVector RootLocation;
	///<summary>SettingsUID</summary>
	public ulong SettingsUID;
}
