#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationAttributeBlueprintLibrary.h")]
public partial class UAnimationAttributeBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>SetAttributeKey</summary>
	public static bool SetAttributeKey(object /*AnimationDataController*/ AnimationDataController,FAnimationAttributeIdentifier AttributeIdentifier,float Time,int Value) { return default; }
	///<summary>SetAttributeKeys</summary>
	public static bool SetAttributeKeys(object /*AnimationDataController*/ AnimationDataController,FAnimationAttributeIdentifier AttributeIdentifier,TArray<float> Times,TArray<int> Values) { return default; }
	///<summary>GetAttributeKey</summary>
	public static bool GetAttributeKey(object /*AnimationDataModel*/ AnimationDataModel,FAnimationAttributeIdentifier AttributeIdentifier,float Time,int Value) { return default; }
	///<summary>GetAttributeKeys</summary>
	public static bool GetAttributeKeys(object /*AnimationDataModel*/ AnimationDataModel,FAnimationAttributeIdentifier AttributeIdentifier,TArray<float> OutTimes,TArray<int> Values) { return default; }
}
