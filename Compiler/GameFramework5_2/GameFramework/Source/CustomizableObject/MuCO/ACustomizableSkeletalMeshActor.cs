#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableSkeletalMeshActor.h")]
public partial class ACustomizableSkeletalMeshActor : ASkeletalMeshActor {
	public static UClass StaticClass() {return default;}
	///<summary>CustomizableSkeletalComponents</summary>
	public TArray<UCustomizableSkeletalComponent> CustomizableSkeletalComponents;
	///<summary>SkeletalMeshComponents</summary>
	public TArray<USkeletalMeshComponent> SkeletalMeshComponents;
	///<summary>TODO: This is a temporary fix to not break the demos, we should update the demos to support the arrays of components</summary>
	public UCustomizableSkeletalComponent CustomizableSkeletalComponent;
}
