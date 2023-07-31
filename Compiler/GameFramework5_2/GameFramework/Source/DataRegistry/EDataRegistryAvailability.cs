#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistryTypes.h")]
///<summary>General rule about how hard it is to access an item, with later entries being the most available and faster to access</summary>
public enum EDataRegistryAvailability {
	DoesNotExist=0,
	Unknown=1,
	Remote=2,
	OnDisk=3,
	LocalAsset=4,
	PreCached=5,
}
