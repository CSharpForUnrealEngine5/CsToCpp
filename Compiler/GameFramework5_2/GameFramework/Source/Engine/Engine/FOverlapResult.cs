#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure containing information about one hit of an overlap test</summary>
[CppInclude("Engine/OverlapResult.h")]
public partial struct FOverlapResult {
	public FActorInstanceHandle OverlapObjectHandle;
	public TWeakObjectPtr<UPrimitiveComponent> Component;
	public bool bBlockingHit;
}
