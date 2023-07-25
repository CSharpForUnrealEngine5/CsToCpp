#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/OverlapResult.h")]
///<summary>Structure containing information about one hit of an overlap test</summary>
public partial struct FOverlapResult {
// OverlapResult
	public FActorInstanceHandle OverlapObjectHandle;
	public TWeakObjectPtr<UPrimitiveComponent> Component;
	public bool bBlockingHit;
}
