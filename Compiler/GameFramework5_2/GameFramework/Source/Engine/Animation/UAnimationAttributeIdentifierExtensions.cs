namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script-exposed functionality for wrapping native functionality and constructing valid FAnimationAttributeIdentifier instances</summary>
[CppInclude("Animation/AnimData/AttributeIdentifier.h")]
public partial class UAnimationAttributeIdentifierExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Constructs a valid FAnimationAttributeIdentifier instance. Ensuring that the underlying BoneName exists on the Skeleton for the provided AnimationAsset.</summary>
	public static FAnimationAttributeIdentifier CreateAttributeIdentifier(UAnimationAsset AnimationAsset,string AttributeName,string BoneName,UScriptStruct AttributeType,bool bValidateExistsOnAsset/*=false*/) { return default; }
	///<summary>@return       Whether or not the Attribute Identifier is valid</summary>
	public static bool IsValid(FAnimationAttributeIdentifier Identifier) { return default; }
}
