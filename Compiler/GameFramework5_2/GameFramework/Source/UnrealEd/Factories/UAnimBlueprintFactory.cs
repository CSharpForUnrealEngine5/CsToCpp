#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/AnimBlueprintFactory.h")]
public partial class UAnimBlueprintFactory : UFactory {
// AnimBlueprintFactory
	public EBlueprintType BlueprintType;
	public UClass ParentClass;
	public USkeleton TargetSkeleton;
	public USkeletalMesh PreviewSkeletalMesh;
	public bool bTemplate;
}
