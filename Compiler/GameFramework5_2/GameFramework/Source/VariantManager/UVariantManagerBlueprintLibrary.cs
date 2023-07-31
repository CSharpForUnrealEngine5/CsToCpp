#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Library of functions that can be used by the Python API to trigger VariantManager operations</summary>
[CppInclude("VariantManagerBlueprintLibrary.h")]
public partial class UVariantManagerBlueprintLibrary : UBlueprintFunctionLibrary {
	///<summary>Creates a new LevelVariantSetsAsset named AssetName (e.g. &#39;MyLevelVariantSets&#39;) in the content path AssetPath (e.g. &#39;/Game&#39;)</summary>
	public static ULevelVariantSets CreateLevelVariantSetsAsset(string AssetName,string AssetPath) { return default; }
	///<summary>Creates a new ALevelVariantSetsActor in the current scene and assigns LevelVariantSetsAsset to it</summary>
	public static ALevelVariantSetsActor CreateLevelVariantSetsActor(ULevelVariantSets LevelVariantSetsAsset) { return default; }
	///<summary>Returns a property path for all the properties we can capture for an actor. Will also</summary>
	public static TArray<string> GetCapturableProperties(UObject ActorOrClass) { return default; }
	///<summary>Adds VariantSet to the LevelVariantSets&#39; list of VariantSets</summary>
	public static void AddVariantSet(ULevelVariantSets LevelVariantSets,UVariantSet VariantSet) {}
	///<summary>Adds Variant to the VariantSet&#39;s list of Variants</summary>
	public static void AddVariant(UVariantSet VariantSet,UVariant Variant) {}
	///<summary>Binds the Actor to the Variant, internally creating a VariantObjectBinding</summary>
	public static void AddActorBinding(UVariant Variant,AActor Actor) {}
	///<summary>Finds the actor binding to Actor within Variant and tries capturing a property with PropertyPath</summary>
	public static UPropertyValue CaptureProperty(UVariant Variant,AActor Actor,string PropertyPath) { return default; }
	///<summary>AddDependency</summary>
	public static int AddDependency(UVariant Variant,FVariantDependency Dependency) { return default; }
	///<summary>SetDependency</summary>
	public static void SetDependency(UVariant Variant,int Index,FVariantDependency Dependency) {}
	///<summary>DeleteDependency</summary>
	public static void DeleteDependency(UVariant Variant,int Index) {}
	///<summary>Returns which properties have been captured for this actor in Variant</summary>
	public static TArray<UPropertyValue> GetCapturedProperties(UVariant Variant,AActor Actor) { return default; }
	///<summary>Removes VariantSet from LevelVariantSets, if that is its parent</summary>
	public static void RemoveVariantSet(ULevelVariantSets LevelVariantSets,UVariantSet VariantSet) {}
	///<summary>Removes Variant from VariantSet, if that is its parent</summary>
	public static void RemoveVariant(UVariantSet VariantSet,UVariant Variant) {}
	///<summary>Removes an actor binding to Actor from Variant, if it exists</summary>
	public static void RemoveActorBinding(UVariant Variant,AActor Actor) {}
	///<summary>Removes a property capture from an actor binding within Variant, if it exists</summary>
	public static void RemoveCapturedProperty(UVariant Variant,AActor Actor,UPropertyValue Property) {}
	///<summary>Looks for a variant set with VariantSetName within LevelVariantSets and removes it, if it exists</summary>
	public static void RemoveVariantSetByName(ULevelVariantSets LevelVariantSets,string VariantSetName) {}
	///<summary>Looks for a variant with VariantName within VariantSet and removes it, if it exists</summary>
	public static void RemoveVariantByName(UVariantSet VariantSet,string VariantName) {}
	///<summary>Looks for an actor binding to an actor with ActorLabel within Variant and removes it, if it exists</summary>
	public static void RemoveActorBindingByName(UVariant Variant,string ActorName) {}
	///<summary>Removes property capture with PropertyPath from Actor&#39;s binding within Variant, if it exists</summary>
	public static void RemoveCapturedPropertyByName(UVariant Variant,AActor Actor,string PropertyPath) {}
	///<summary>Records new data for PropVal from the actor from which it was captured</summary>
	public static void Record(UPropertyValue PropVal) {}
	///<summary>Applies the recorded data from PropVal to the actor from which it was captured</summary>
	public static void Apply(UPropertyValue PropVal) {}
	///<summary>This allows the scripting language to get the type of the C++ property its dealing with</summary>
	public static string GetPropertyTypeString(UPropertyValue PropVal) { return default; }
	///<summary>SetValueBool</summary>
	public static void SetValueBool(UPropertyValue Property,bool InValue) {}
	///<summary>GetValueBool</summary>
	public static bool GetValueBool(UPropertyValue Property) { return default; }
	///<summary>SetValueInt</summary>
	public static void SetValueInt(UPropertyValue Property,int InValue) {}
	///<summary>GetValueInt</summary>
	public static int GetValueInt(UPropertyValue Property) { return default; }
	///<summary>SetValueFloat</summary>
	public static void SetValueFloat(UPropertyValue Property,float InValue) {}
	///<summary>GetValueFloat</summary>
	public static float GetValueFloat(UPropertyValue Property) { return default; }
	///<summary>SetValueObject</summary>
	public static void SetValueObject(UPropertyValue Property,UObject InValue) {}
	///<summary>GetValueObject</summary>
	public static UObject GetValueObject(UPropertyValue Property) { return default; }
	///<summary>SetValueString</summary>
	public static void SetValueString(UPropertyValue Property,string InValue) {}
	///<summary>GetValueString</summary>
	public static string GetValueString(UPropertyValue Property) { return default; }
	///<summary>SetValueRotator</summary>
	public static void SetValueRotator(UPropertyValue Property,FRotator InValue) {}
	///<summary>GetValueRotator</summary>
	public static FRotator GetValueRotator(UPropertyValue Property) { return default; }
	///<summary>SetValueColor</summary>
	public static void SetValueColor(UPropertyValue Property,FColor InValue) {}
	///<summary>GetValueColor</summary>
	public static FColor GetValueColor(UPropertyValue Property) { return default; }
	///<summary>SetValueLinearColor</summary>
	public static void SetValueLinearColor(UPropertyValue Property,FLinearColor InValue) {}
	///<summary>GetValueLinearColor</summary>
	public static FLinearColor GetValueLinearColor(UPropertyValue Property) { return default; }
	///<summary>SetValueVector</summary>
	public static void SetValueVector(UPropertyValue Property,FVector InValue) {}
	///<summary>GetValueVector</summary>
	public static FVector GetValueVector(UPropertyValue Property) { return default; }
	///<summary>SetValueQuat</summary>
	public static void SetValueQuat(UPropertyValue Property,FQuat InValue) {}
	///<summary>GetValueQuat</summary>
	public static FQuat GetValueQuat(UPropertyValue Property) { return default; }
	///<summary>SetValueVector4</summary>
	public static void SetValueVector4(UPropertyValue Property,FVector4 InValue) {}
	///<summary>GetValueVector4</summary>
	public static FVector4 GetValueVector4(UPropertyValue Property) { return default; }
	///<summary>SetValueVector2D</summary>
	public static void SetValueVector2D(UPropertyValue Property,FVector2D InValue) {}
	///<summary>GetValueVector2D</summary>
	public static FVector2D GetValueVector2D(UPropertyValue Property) { return default; }
	///<summary>SetValueIntPoint</summary>
	public static void SetValueIntPoint(UPropertyValue Property,FIntPoint InValue) {}
	///<summary>GetValueIntPoint</summary>
	public static FIntPoint GetValueIntPoint(UPropertyValue Property) { return default; }
}
