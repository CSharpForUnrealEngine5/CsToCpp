#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/AnimBlueprintFactory.h")]
public partial class UAnimBlueprintFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The type of blueprint that will be created</summary>
	public EBlueprintType BlueprintType;
	///<summary>The parent class of the created blueprint</summary>
	public UClass ParentClass;
	///<summary>The kind of skeleton that animation graphs compiled from the blueprint will animate</summary>
	public USkeleton TargetSkeleton;
	///<summary>The preview mesh to use with this animation blueprint</summary>
	public USkeletalMesh PreviewSkeletalMesh;
	///<summary>Whether the created blueprint should be a template with no target skeleton</summary>
	public bool bTemplate;
}
