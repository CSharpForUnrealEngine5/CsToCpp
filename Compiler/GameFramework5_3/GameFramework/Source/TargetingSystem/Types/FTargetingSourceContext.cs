namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@struct FTargetingSourceContext</summary>
[CppInclude("Types/TargetingSystemTypes.h")]
public partial struct FTargetingSourceContext {
	public AActor SourceActor;
	public AActor InstigatorActor;
	public FVector SourceLocation;
	public FName SourceSocketName;
	public UObject SourceObject;
}
