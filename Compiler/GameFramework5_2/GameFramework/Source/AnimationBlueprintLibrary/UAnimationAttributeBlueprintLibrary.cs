#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationAttributeBlueprintLibrary.h")]
public partial class UAnimationAttributeBlueprintLibrary : UBlueprintFunctionLibrary {
// AnimationAttributeBlueprintLibrary
	public static bool SetAttributeKey(object /*AnimationDataController*/ AnimationDataController,FAnimationAttributeIdentifier AttributeIdentifier,float Time,int Value) { return default; }
	public static bool SetAttributeKeys(object /*AnimationDataController*/ AnimationDataController,FAnimationAttributeIdentifier AttributeIdentifier,TArray<float> Times,TArray<int> Values) { return default; }
	public static bool GetAttributeKey(object /*AnimationDataModel*/ AnimationDataModel,FAnimationAttributeIdentifier AttributeIdentifier,float Time,int Value) { return default; }
	public static bool GetAttributeKeys(object /*AnimationDataModel*/ AnimationDataModel,FAnimationAttributeIdentifier AttributeIdentifier,TArray<float> OutTimes,TArray<int> Values) { return default; }
}
