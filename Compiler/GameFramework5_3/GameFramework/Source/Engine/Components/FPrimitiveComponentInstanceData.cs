namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component instance cached data base class for primitive components.</summary>
[CppInclude("Components/PrimitiveComponent.h")]
public partial struct FPrimitiveComponentInstanceData {
	public FTransform ComponentTransform;
	public int VisibilityId;
	public UPrimitiveComponent LODParent;
}
