#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubobjectDataSubsystem.h")]
///<summary>Options for reparenting subobjects</summary>
public partial struct FReparentSubobjectParams {
// ReparentSubobjectParams
	public FSubobjectDataHandle NewParentHandle;
	public UBlueprint BlueprintContext;
	public AActor ActorPreviewContext;
}
