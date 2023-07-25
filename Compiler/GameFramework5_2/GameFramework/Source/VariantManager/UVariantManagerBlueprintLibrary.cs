#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VariantManagerBlueprintLibrary.h")]
///<summary>Library of functions that can be used by the Python API to trigger VariantManager operations</summary>
public partial class UVariantManagerBlueprintLibrary : UBlueprintFunctionLibrary {
// VariantManagerBlueprintLibrary
	public UObject CreateLevelVariantSetsAsset(string AssetName,string AssetPath) { return default; }
	public UObject CreateLevelVariantSetsActor(UObject LevelVariantSetsAsset) { return default; }
	public TArray<string> GetCapturableProperties(UObject ActorOrClass) { return default; }
	public void AddVariantSet(UObject LevelVariantSets,UObject VariantSet) {}
	public void AddVariant(UObject VariantSet,UObject Variant) {}
	public void AddActorBinding(UObject Variant,UObject Actor) {}
	public UObject CaptureProperty(UObject Variant,UObject Actor,string PropertyPath) { return default; }
	public int AddDependency(UObject Variant,FVariantDependency Dependency) { return default; }
	public void SetDependency(UObject Variant,int Index,FVariantDependency Dependency) {}
	public void DeleteDependency(UObject Variant,int Index) {}
	public TArray<UObject> GetCapturedProperties(UObject Variant,UObject Actor) { return default; }
	public void RemoveVariantSet(UObject LevelVariantSets,UObject VariantSet) {}
	public void RemoveVariant(UObject VariantSet,UObject Variant) {}
	public void RemoveActorBinding(UObject Variant,UObject Actor) {}
	public void RemoveCapturedProperty(UObject Variant,UObject Actor,UObject Property) {}
	public void RemoveVariantSetByName(UObject LevelVariantSets,string VariantSetName) {}
	public void RemoveVariantByName(UObject VariantSet,string VariantName) {}
	public void RemoveActorBindingByName(UObject Variant,string ActorName) {}
	public void RemoveCapturedPropertyByName(UObject Variant,UObject Actor,string PropertyPath) {}
	public void Record(UObject PropVal) {}
	public void Apply(UObject PropVal) {}
	public string GetPropertyTypeString(UObject PropVal) { return default; }
	public void SetValueBool(UObject Property,bool InValue) {}
	public bool GetValueBool(UObject Property) { return default; }
	public void SetValueInt(UObject Property,int InValue) {}
	public int GetValueInt(UObject Property) { return default; }
	public void SetValueFloat(UObject Property,float InValue) {}
	public float GetValueFloat(UObject Property) { return default; }
	public void SetValueObject(UObject Property,UObject InValue) {}
	public UObject GetValueObject(UObject Property) { return default; }
	public void SetValueString(UObject Property,string InValue) {}
	public string GetValueString(UObject Property) { return default; }
	public void SetValueRotator(UObject Property,FRotator InValue) {}
	public FRotator GetValueRotator(UObject Property) { return default; }
	public void SetValueColor(UObject Property,FColor InValue) {}
	public FColor GetValueColor(UObject Property) { return default; }
	public void SetValueLinearColor(UObject Property,FLinearColor InValue) {}
	public FLinearColor GetValueLinearColor(UObject Property) { return default; }
	public void SetValueVector(UObject Property,FVector InValue) {}
	public FVector GetValueVector(UObject Property) { return default; }
	public void SetValueQuat(UObject Property,FQuat InValue) {}
	public FQuat GetValueQuat(UObject Property) { return default; }
	public void SetValueVector4(UObject Property,FVector4 InValue) {}
	public FVector4 GetValueVector4(UObject Property) { return default; }
	public void SetValueVector2D(UObject Property,FVector2D InValue) {}
	public FVector2D GetValueVector2D(UObject Property) { return default; }
	public void SetValueIntPoint(UObject Property,FIntPoint InValue) {}
	public FIntPoint GetValueIntPoint(UObject Property) { return default; }
}
