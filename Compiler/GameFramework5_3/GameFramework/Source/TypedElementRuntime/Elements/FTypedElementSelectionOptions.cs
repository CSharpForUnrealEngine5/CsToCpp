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
