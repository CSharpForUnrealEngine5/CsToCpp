#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Interfaces/TypedElementSelectionInterface.h")]
public partial struct FTypedElementSelectionOptions {
	public bool bAllowHidden;
	public bool bAllowGroups;
	public bool bAllowLegacyNotifications;
	public bool bWarnIfLocked;
	public ETypedElementChildInclusionMethod ChildElementInclusionMethod;
}
