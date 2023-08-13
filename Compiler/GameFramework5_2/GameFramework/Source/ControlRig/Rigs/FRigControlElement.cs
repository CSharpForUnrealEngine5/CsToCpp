namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyElements.h")]
public partial struct FRigControlElement {
	public FRigControlSettings Settings;
	public FRigCurrentAndInitialTransform Offset;
	public FRigCurrentAndInitialTransform Shape;
	public FRigPreferredEulerAngles PreferredEulerAngles;
}
