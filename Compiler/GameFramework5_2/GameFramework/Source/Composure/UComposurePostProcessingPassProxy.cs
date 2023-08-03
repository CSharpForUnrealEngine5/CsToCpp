#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generic component class which takes a UComposurePostProcessPassPolicy and</summary>
[CppInclude("ComposurePostProcessingPassProxy.h")]
public partial class UComposurePostProcessingPassProxy : UComposurePostProcessPass {
	public static UClass StaticClass() {return default;}
	///<summary>Execute</summary>
	public  void Execute(UTexture PrePassInput,UComposurePostProcessPassPolicy PostProcessPass) {}
	///<summary>SetupMID</summary>
	public UMaterialInstanceDynamic SetupMID;
}
