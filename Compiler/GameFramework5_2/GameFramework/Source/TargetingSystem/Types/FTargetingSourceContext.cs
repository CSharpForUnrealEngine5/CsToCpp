#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/TargetingSystemTypes.h")]
///<summary>@struct FTargetingSourceContext</summary>
public partial struct FTargetingSourceContext {
// TargetingSourceContext
	public AActor SourceActor;
	public AActor InstigatorActor;
	public FVector SourceLocation;
	public string SourceSocketName;
	public UObject SourceObject;
}
