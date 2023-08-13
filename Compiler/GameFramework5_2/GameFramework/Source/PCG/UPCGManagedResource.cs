namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is used to hold resources and their mechanism to delete them on demand.</summary>
[CppInclude("PCGManagedResource.h")]
public partial class UPCGManagedResource : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Crc</summary>
	public FPCGCrc Crc;
	///<summary>bIsMarkedUnused</summary>
	public bool bIsMarkedUnused;
}
