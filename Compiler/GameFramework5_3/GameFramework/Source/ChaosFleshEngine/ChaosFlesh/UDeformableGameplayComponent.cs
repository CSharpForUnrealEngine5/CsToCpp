namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDeformableGameplayComponent</summary>
[CppInclude("ChaosFlesh/ChaosDeformableGameplayComponent.h")]
public partial class UDeformableGameplayComponent : UDeformableTetrahedralComponent {
	public static UClass StaticClass() {return default;}
	///<summary>GameplayColllisions</summary>
	public FGameplayColllisions GameplayColllisions;
}
