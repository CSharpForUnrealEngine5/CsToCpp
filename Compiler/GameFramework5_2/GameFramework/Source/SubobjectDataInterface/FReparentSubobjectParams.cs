#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options for reparenting subobjects</summary>
[CppInclude("SubobjectDataSubsystem.h")]
public partial struct FReparentSubobjectParams {
	public FSubobjectDataHandle NewParentHandle;
	public UBlueprint BlueprintContext;
	public AActor ActorPreviewContext;
}
