namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Controls the selection of the system used to simplify skeletal meshes.</summary>
[CppInclude("Engine/SkeletalMeshSimplificationSettings.h")]
public partial class USkeletalMeshSimplificationSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Mesh reduction plugin to use when simplifying skeletal meshes</summary>
	public FName SkeletalMeshReductionModuleName;
}
