#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VariantManagerBlueprintLibrary.h")]
///<summary>Library of functions that can be used by the Python API to trigger VariantManager operations</summary>
public partial class UVariantManagerBlueprintLibrary : UBlueprintFunctionLibrary {
// VariantManagerBlueprintLibrary
	public static ULevelVariantSets CreateLevelVariantSetsAsset(string AssetName,string AssetPath) { return default; }
	public static ALevelVariantSetsActor CreateLevelVariantSetsActor(ULevelVariantSets LevelVariantSetsAsset) { return default; }
	public static TArray<string> GetCapturableProperties(UObject ActorOrClass) { return default; }
	public static void AddVariantSet(ULevelVariantSets LevelVariantSets,UVariantSet VariantSet) {}
	public static void AddVariant(UVariantSet VariantSet,UVariant Variant) {}
	public static void AddActorBinding(UVariant Variant,AActor Actor) {}
	public static UPropertyValue CaptureProperty(UVariant Variant,AActor Actor,string PropertyPath) { return default; }
	public static int AddDependency(UVariant Variant,FVariantDependency Dependency) { return default; }
	public static void SetDependency(UVariant Variant,int Index,FVariantDependency Dependency) {}
	public static void DeleteDependency(UVariant Variant,int Index) {}
	public static TArray<UPropertyValue> GetCapturedProperties(UVariant Variant,AActor Actor) { return default; }
	public static void RemoveVariantSet(ULevelVariantSets LevelVariantSets,UVariantSet VariantSet) {}
	public static void RemoveVariant(UVariantSet VariantSet,UVariant Variant) {}
	public static void RemoveActorBinding(UVariant Variant,AActor Actor) {}
	public static void RemoveCapturedProperty(UVariant Variant,AActor Actor,UPropertyValue Property) {}
	public static void RemoveVariantSetByName(ULevelVariantSets LevelVariantSets,string VariantSetName) {}
	public static void RemoveVariantByName(UVariantSet VariantSet,string VariantName) {}
	public static void RemoveActorBindingByName(UVariant Variant,string ActorName) {}
	public static void RemoveCapturedPropertyByName(UVariant Variant,AActor Actor,string PropertyPath) {}
	public static void Record(UPropertyValue PropVal) {}
	public static void Apply(UPropertyValue PropVal) {}
	public static string GetPropertyTypeString(UPropertyValue PropVal) { return default; }
	public static void SetValueBool(UPropertyValue Property,bool InValue) {}
	public static bool GetValueBool(UPropertyValue Property) { return default; }
	public static void SetValueInt(UPropertyValue Property,int InValue) {}
	public static int GetValueInt(UPropertyValue Property) { return default; }
	public static void SetValueFloat(UPropertyValue Property,float InValue) {}
	public static float GetValueFloat(UPropertyValue Property) { return default; }
	public static void SetValueObject(UPropertyValue Property,UObject InValue) {}
	public static UObject GetValueObject(UPropertyValue Property) { return default; }
	public static void SetValueString(UPropertyValue Property,string InValue) {}
	public static string GetValueString(UPropertyValue Property) { return default; }
	public static void SetValueRotator(UPropertyValue Property,FRotator InValue) {}
	public static FRotator GetValueRotator(UPropertyValue Property) { return default; }
	public static void SetValueColor(UPropertyValue Property,FColor InValue) {}
	public static FColor GetValueColor(UPropertyValue Property) { return default; }
	public static void SetValueLinearColor(UPropertyValue Property,FLinearColor InValue) {}
	public static FLinearColor GetValueLinearColor(UPropertyValue Property) { return default; }
	public static void SetValueVector(UPropertyValue Property,FVector InValue) {}
	public static FVector GetValueVector(UPropertyValue Property) { return default; }
	public static void SetValueQuat(UPropertyValue Property,FQuat InValue) {}
	public static FQuat GetValueQuat(UPropertyValue Property) { return default; }
	public static void SetValueVector4(UPropertyValue Property,FVector4 InValue) {}
	public static FVector4 GetValueVector4(UPropertyValue Property) { return default; }
	public static void SetValueVector2D(UPropertyValue Property,FVector2D InValue) {}
	public static FVector2D GetValueVector2D(UPropertyValue Property) { return default; }
	public static void SetValueIntPoint(UPropertyValue Property,FIntPoint InValue) {}
	public static FIntPoint GetValueIntPoint(UPropertyValue Property) { return default; }
}
