namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/PropertyEditorTestObject.h")]
public partial class UPropertyEditorTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Int8Property</summary>
	public short Int8Property;
	///<summary>Int16Property</summary>
	public short Int16Property;
	///<summary>Int32Property</summary>
	public int Int32Property;
	///<summary>Int64Property</summary>
	public long Int64Property;
	///<summary>ByteProperty</summary>
	public byte ByteProperty;
	///<summary>UnsignedInt16Property</summary>
	public ushort UnsignedInt16Property;
	///<summary>UnsignedInt32Property</summary>
	public uint UnsignedInt32Property;
	///<summary>UnsignedInt64Property</summary>
	public ulong UnsignedInt64Property;
	///<summary>FloatProperty</summary>
	public float FloatProperty;
	///<summary>DoubleProperty</summary>
	public double DoubleProperty;
	///<summary>NameProperty</summary>
	public string NameProperty;
	///<summary>BoolProperty</summary>
	public bool BoolProperty;
	///<summary>StringProperty</summary>
	public string StringProperty;
	///<summary>TextProperty</summary>
	public FText TextProperty;
	///<summary>IntPointProperty</summary>
	public FIntPoint IntPointProperty;
	///<summary>Vector3Property</summary>
	public FVector Vector3Property;
	///<summary>Vector2Property</summary>
	public FVector2D Vector2Property;
	///<summary>Vector4Property</summary>
	public FVector4 Vector4Property;
	///<summary>RotatorProperty</summary>
	public FRotator RotatorProperty;
	///<summary>ObjectProperty</summary>
	public UObject ObjectProperty;
	///<summary>LinearColorProperty</summary>
	public FLinearColor LinearColorProperty;
	///<summary>ColorProperty</summary>
	public FColor ColorProperty;
	///<summary>EnumByteProperty</summary>
	public EPropertyEditorTestEnum EnumByteProperty;
	///<summary>EnumProperty</summary>
	public EPropertyEditorTestEditColor EnumProperty;
	///<summary>EnumUnderscores</summary>
	public EPropertyEditorTestUnderscores EnumUnderscores;
	///<summary>MatrixProperty</summary>
	public FMatrix MatrixProperty;
	///<summary>TransformProperty</summary>
	public FTransform TransformProperty;
	///<summary>GigabyteProperty</summary>
	public double GigabyteProperty;
	///<summary>ClassProperty</summary>
	public UClass ClassProperty;
	///<summary>ClassPropertyWithAllowed</summary>
	public UClass ClassPropertyWithAllowed;
	///<summary>ClassPropertyWithDisallowed</summary>
	public UClass ClassPropertyWithDisallowed;
	///<summary>SubclassOfTexture</summary>
	public UClass SubclassOfTexture;
	///<summary>SubclassOfWithAllowed</summary>
	public UClass SubclassOfWithAllowed;
	///<summary>SubclassOfWithDisallowed</summary>
	public UClass SubclassOfWithDisallowed;
	///<summary>AssetPointerWithAllowedAndWhitespace</summary>
	public TSoftObjectPtr<UObject> AssetPointerWithAllowedAndWhitespace;
	///<summary>Integer</summary>
	public TArray<int> IntProperty32Array;
	///<summary>Byte</summary>
	public TArray<byte> BytePropertyArray;
	///<summary>FloatPropertyArray</summary>
	public TArray<float> FloatPropertyArray;
	///<summary>NamePropertyArray</summary>
	public TArray<string> NamePropertyArray;
	///<summary>BoolPropertyArray</summary>
	public TArray<bool> BoolPropertyArray;
	///<summary>StringPropertyArray</summary>
	public TArray<string> StringPropertyArray;
	///<summary>TextPropertyArray</summary>
	public TArray<FText> TextPropertyArray;
	///<summary>Vector3PropertyArray</summary>
	public TArray<FVector> Vector3PropertyArray;
	///<summary>Vector2PropertyArray</summary>
	public TArray<FVector2D> Vector2PropertyArray;
	///<summary>Vector4PropertyArray</summary>
	public TArray<FVector4> Vector4PropertyArray;
	///<summary>RotatorPropertyArray</summary>
	public TArray<FRotator> RotatorPropertyArray;
	///<summary>ObjectPropertyArray</summary>
	public TArray<UObject> ObjectPropertyArray;
	///<summary>ActorPropertyArray</summary>
	public TArray<AActor> ActorPropertyArray;
	///<summary>LinearColorPropertyArray</summary>
	public TArray<FLinearColor> LinearColorPropertyArray;
	///<summary>ColorPropertyArray</summary>
	public TArray<FColor> ColorPropertyArray;
	///<summary>TimecodePropertyArray</summary>
	public TArray<FTimecode> TimecodePropertyArray;
	///<summary>EnumPropertyArray</summary>
	public TArray<EPropertyEditorTestEnum> EnumPropertyArray;
	///<summary>StructPropertyArray</summary>
	public TArray<FPropertyEditorTestBasicStruct> StructPropertyArray;
	///<summary>StructPropertyArrayWithTitle</summary>
	public TArray<FPropertyEditorTestBasicStruct> StructPropertyArrayWithTitle;
	///<summary>StructPropertyArrayWithFormattedTitle</summary>
	public TArray<FPropertyEditorTestBasicStruct> StructPropertyArrayWithFormattedTitle;
	///<summary>StructPropertyArrayWithTitleError</summary>
	public TArray<FPropertyEditorTestBasicStruct> StructPropertyArrayWithTitleError;
	///<summary>StructPropertyArrayWithFormattedTitleError</summary>
	public TArray<FPropertyEditorTestBasicStruct> StructPropertyArrayWithFormattedTitleError;
	///<summary>InstancedStructArray</summary>
	public TArray<FPropertyEditorTestInstancedStruct> InstancedStructArray;
	///<summary>ObjectPropertyArrayWithTitle</summary>
	public TArray<UPropertyEditorTestInstancedObject> ObjectPropertyArrayWithTitle;
	///<summary>InstancedUObjectArray</summary>
	public TArray<UPropertyEditorTestInstancedObject> InstancedUObjectArray;
	///<summary>FixedArrayOfInts</summary>
	public TArray<int> FixedArrayOfInts;
	///<summary>StaticArrayOfInts</summary>
	public int StaticArrayOfInts;
	///<summary>StaticArrayOfIntsWithEnumLabels</summary>
	public int StaticArrayOfIntsWithEnumLabels;
	///<summary>FloatRange</summary>
	public FFloatRange FloatRange;
	///<summary>This is a custom tooltip that should be shown</summary>
	public float FloatPropertyWithClampedRange;
	///<summary>IntPropertyWithClampedRange</summary>
	public int IntPropertyWithClampedRange;
	///<summary>IntThatCannotBeChanged</summary>
	public int IntThatCannotBeChanged;
	///<summary>StringThatCannotBeChanged</summary>
	public string StringThatCannotBeChanged;
	///<summary>ObjectThatCannotBeChanged</summary>
	public UPrimitiveComponent ObjectThatCannotBeChanged;
	///<summary>EnumBitflags</summary>
	public int EnumBitflags;
	///<summary>StringPasswordProperty</summary>
	public string StringPasswordProperty;
	///<summary>TextPasswordProperty</summary>
	public FText TextPasswordProperty;
	///<summary>ThisIsBrokenIfItsVisibleInADetailsView</summary>
	public FPropertyEditorTestBasicStruct ThisIsBrokenIfItsVisibleInADetailsView;
	///<summary>StructWithMultipleInstances1</summary>
	public FPropertyEditorTestBasicStruct StructWithMultipleInstances1;
	///<summary>bEditConditionStructWithMultipleInstances2</summary>
	public bool bEditConditionStructWithMultipleInstances2;
	///<summary>StructWithMultipleInstances2</summary>
	public FPropertyEditorTestBasicStruct StructWithMultipleInstances2;
	///<summary>RichCurve</summary>
	public FRichCurve RichCurve;
	///<summary>SoftObjectPath</summary>
	public FSoftObjectPath SoftObjectPath;
	///<summary>PrimaryAssetId</summary>
	public FPrimaryAssetId PrimaryAssetId;
	///<summary>PrimaryAssetIdWithoutThumbnail</summary>
	public FPrimaryAssetId PrimaryAssetIdWithoutThumbnail;
	///<summary>AssetReferenceCustomStructWithThumbnail</summary>
	public FSoftObjectPath AssetReferenceCustomStructWithThumbnail;
	///<summary>ExactlyPointLightActorReference</summary>
	public FSoftObjectPath ExactlyPointLightActorReference;
	///<summary>LightActorReference</summary>
	public FSoftObjectPath LightActorReference;
	///<summary>ExactPointOrSpotLightActorReference</summary>
	public FSoftObjectPath ExactPointOrSpotLightActorReference;
	///<summary>NOTE: intentionally misplaced space in AllowedClasses</summary>
	public FSoftObjectPath LightOrStaticMeshActorReference;
	///<summary>NotLightActorReference</summary>
	public FSoftObjectPath NotLightActorReference;
	///<summary>MaterialOrTextureAssetReference</summary>
	public FSoftObjectPath MaterialOrTextureAssetReference;
	///<summary>ActorWithMetaClass</summary>
	public FSoftObjectPath ActorWithMetaClass;
	///<summary>DisabledByCanEditChange</summary>
	public FSoftObjectPath DisabledByCanEditChange;
	///<summary>ComponentReference</summary>
	public FComponentReference ComponentReference;
	///<summary>bEditCondition</summary>
	public bool bEditCondition;
	///<summary>SimplePropertyWithEditCondition</summary>
	public int SimplePropertyWithEditCondition;
	///<summary>bEditConditionAssetReferenceCustomStructWithEditCondition</summary>
	public bool bEditConditionAssetReferenceCustomStructWithEditCondition;
	///<summary>AssetReferenceCustomStructWithEditCondition</summary>
	public FSoftObjectPath AssetReferenceCustomStructWithEditCondition;
	///<summary>ArrayOfStructs</summary>
	public TArray<FPropertyEditorTestBasicStruct> ArrayOfStructs;
	///<summary>Struct</summary>
	public FPropertyEditTestTextStruct Struct;
	///<summary>EditInlineNewStaticMeshComponent</summary>
	public UStaticMeshComponent EditInlineNewStaticMeshComponent;
	///<summary>ArrayOfEditInlineNewSMCs</summary>
	public TArray<UStaticMeshComponent> ArrayOfEditInlineNewSMCs;
	///<summary>TextureProp</summary>
	public UTexture TextureProp;
	///<summary>StaticMeshProp</summary>
	public UStaticMesh StaticMeshProp;
	///<summary>AnyMaterialInterface</summary>
	public UMaterialInterface AnyMaterialInterface;
	///<summary>MaterialNoThumbnail</summary>
	public UMaterialInterface MaterialNoThumbnail;
	///<summary>OnlyActorsAllowed</summary>
	public AActor OnlyActorsAllowed;
	///<summary>Int32Set</summary>
	public TSet<int> Int32Set;
	///<summary>FloatSet</summary>
	public TSet<float> FloatSet;
	///<summary>StringSet</summary>
	public TSet<string> StringSet;
	///<summary>ObjectSet</summary>
	public TSet<UObject> ObjectSet;
	///<summary>ActorSet</summary>
	public TSet<AActor> ActorSet;
	///<summary>EditColorSet</summary>
	public TSet<EPropertyEditorTestEditColor> EditColorSet;
	///<summary>NameSet</summary>
	public TSet<string> NameSet;
	///<summary>Int32ToStringMap</summary>
	public TMap<int,string> Int32ToStringMap;
	///<summary>StringToMultilineTextMap</summary>
	public TMap<string,FText> StringToMultilineTextMap;
	///<summary>StringToColorMap</summary>
	public TMap<string,FLinearColor> StringToColorMap;
	///<summary>Int32ToStructMap</summary>
	public TMap<int,FPropertyEditorTestBasicStruct> Int32ToStructMap;
	///<summary>StringToFloatMap</summary>
	public TMap<string,float> StringToFloatMap;
	///<summary>StringToObjectMap</summary>
	public TMap<string,UObject> StringToObjectMap;
	///<summary>StringToActorMap</summary>
	public TMap<string,AActor> StringToActorMap;
	///<summary>ObjectToInt32Map</summary>
	public TMap<UObject,int> ObjectToInt32Map;
	///<summary>ObjectToColorMap</summary>
	public TMap<UObject,FLinearColor> ObjectToColorMap;
	///<summary>IntToEnumMap</summary>
	public TMap<int,EPropertyEditorTestEnum> IntToEnumMap;
	///<summary>NameToNameMap</summary>
	public TMap<string,string> NameToNameMap;
	///<summary>NameToObjectMap</summary>
	public TMap<string,UObject> NameToObjectMap;
	///<summary>NameToCustomMap</summary>
	public TMap<string,FPropertyEditorTestBasicStruct> NameToCustomMap;
	///<summary>NameToColorMap</summary>
	public TMap<string,FLinearColor> NameToColorMap;
	///<summary>IntToCustomMap</summary>
	public TMap<int,FPropertyEditorTestBasicStruct> IntToCustomMap;
	///<summary>IntToSubStructMap</summary>
	public TMap<int,FPropertyEditorTestSubStruct> IntToSubStructMap;
	///<summary>LinearColorSet</summary>
	public TSet<FLinearColor> LinearColorSet;
	///<summary>VectorSet</summary>
	public TSet<FVector> VectorSet;
	///<summary>LinearColorToStringMap</summary>
	public TMap<FLinearColor,string> LinearColorToStringMap;
	///<summary>VectorToFloatMap</summary>
	public TMap<FVector,float> VectorToFloatMap;
	///<summary>LinearColorToVectorMap</summary>
	public TMap<FLinearColor,FVector> LinearColorToVectorMap;
	///<summary>BlendableInterface</summary>
	public object /*BlendableInterface*/ BlendableInterface;
	///<summary>AnimClassInterface</summary>
	public object /*AnimClassInterface*/ AnimClassInterface;
	///<summary>This is an IBlendableInterface that only allows for ULightPropagationVolumeBlendable objects</summary>
	public object /*LightPropagationVolumeBlendable*/ LightPropagationVolumeBlendable;
	///<summary>Allows either an object that&#39;s derived from UTexture or IBlendableInterface, to ensure that Object Property handles know how to</summary>
	public UObject TextureOrBlendableInterface;
	///<summary>bSubcategory</summary>
	public bool bSubcategory;
	///<summary>bSubcategoryAdvanced</summary>
	public bool bSubcategoryAdvanced;
	///<summary>bSubcategoryFooSimple</summary>
	public bool bSubcategoryFooSimple;
	///<summary>bSubcategoryFooAdvanced</summary>
	public bool bSubcategoryFooAdvanced;
	///<summary>bSubcategoryBarSimple</summary>
	public bool bSubcategoryBarSimple;
	///<summary>bSubcategoryBarAdvanced</summary>
	public bool bSubcategoryBarAdvanced;
	///<summary>bSubcategoryLast</summary>
	public bool bSubcategoryLast;
	///<summary>bEnablesNext</summary>
	public bool bEnablesNext;
	///<summary>bEnabledByPrevious</summary>
	public bool bEnabledByPrevious;
	///<summary>EnumEditCondition</summary>
	public EPropertyEditorTestEditColor EnumEditCondition;
	///<summary>bEnabledWhenBlue</summary>
	public bool bEnabledWhenBlue;
	///<summary>bEnabledWhenPink</summary>
	public bool bEnabledWhenPink;
	///<summary>EnumAsByteEditCondition</summary>
	public EPropertyEditorTestEnum EnumAsByteEditCondition;
	///<summary>bEnabledWhenEnumIs2</summary>
	public bool bEnabledWhenEnumIs2;
	///<summary>bEnabledWhenEnumIs4</summary>
	public bool bEnabledWhenEnumIs4;
	///<summary>IntegerEditCondition</summary>
	public int IntegerEditCondition;
	///<summary>bEnabledWhenIntGreaterOrEqual5</summary>
	public bool bEnabledWhenIntGreaterOrEqual5;
	///<summary>bEnabledWhenIntLessOrEqual10</summary>
	public bool bEnabledWhenIntLessOrEqual10;
	///<summary>FloatEditCondition</summary>
	public float FloatEditCondition;
	///<summary>bEnabledWhenFloatGreaterThan5</summary>
	public bool bEnabledWhenFloatGreaterThan5;
	///<summary>bEnabledWhenFloatLessThan10</summary>
	public bool bEnabledWhenFloatLessThan10;
	///<summary>bEditConditionForArrays</summary>
	public bool bEditConditionForArrays;
	///<summary>ArrayWithEditCondition</summary>
	public TArray<UTexture2D> ArrayWithEditCondition;
	///<summary>ArrayOfStructsWithEditCondition</summary>
	public TArray<FPropertyEditorTestBasicStruct> ArrayOfStructsWithEditCondition;
	///<summary>bEditConditionForFixedArray</summary>
	public bool bEditConditionForFixedArray;
	///<summary>FixedArrayWithEditCondition</summary>
	public string FixedArrayWithEditCondition;
	///<summary>bEditConditionForDirectoryPath</summary>
	public bool bEditConditionForDirectoryPath;
	///<summary>DirectoryPath</summary>
	public FDirectoryPath DirectoryPath;
	///<summary>EditConditionFlags</summary>
	public long EditConditionFlags;
	///<summary>bEnabledWhenFlagsHasTwoOrFour</summary>
	public bool bEnabledWhenFlagsHasTwoOrFour;
	///<summary>bDisabledWhenFlagsIsOdd</summary>
	public bool bDisabledWhenFlagsIsOdd;
	///<summary>AlwaysDisabled</summary>
	public int AlwaysDisabled;
	///<summary>bCategoryInlineEditCondition</summary>
	public bool bCategoryInlineEditCondition;
	///<summary>EnabledWhenCategoryChecked</summary>
	public float EnabledWhenCategoryChecked;
	///<summary>InlineProperty</summary>
	public EComponentMobility InlineProperty;
	///<summary>PropertyThatHides</summary>
	public EComponentMobility PropertyThatHides;
	///<summary>bVisibleWhenStatic</summary>
	public bool bVisibleWhenStatic;
	///<summary>VisibleWhenStationary</summary>
	public int VisibleWhenStationary;
	///<summary>DateTime</summary>
	public FDateTime DateTime;
	///<summary>Timespan</summary>
	public FTimespan Timespan;
	///<summary>Guid</summary>
	public FGuid Guid;
	///<summary>PerPlatformFloat</summary>
	public FPerPlatformFloat PerPlatformFloat;
	///<summary>PerPlatformInt</summary>
	public FPerPlatformInt PerPlatformInt;
	///<summary>bInlineEditConditionWithoutMetaToggle</summary>
	public bool bInlineEditConditionWithoutMetaToggle;
	///<summary>InlineEditConditionWithoutMeta</summary>
	public float InlineEditConditionWithoutMeta;
	///<summary>bInlineEditConditionWithMetaToggle</summary>
	public bool bInlineEditConditionWithMetaToggle;
	///<summary>InlineEditConditionWithMeta</summary>
	public float InlineEditConditionWithMeta;
	///<summary>bInlineEditConditionNotEditable</summary>
	public bool bInlineEditConditionNotEditable;
	///<summary>HasNonEditableInlineCondition</summary>
	public float HasNonEditableInlineCondition;
	///<summary>bSharedEditCondition</summary>
	public bool bSharedEditCondition;
	///<summary>UsesSharedEditCondition1</summary>
	public float UsesSharedEditCondition1;
	///<summary>UsesSharedEditCondition2</summary>
	public float UsesSharedEditCondition2;
	///<summary>StructWithInlineCondition</summary>
	public FPropertyEditorTestEditCondition StructWithInlineCondition;
	///<summary>ArrayOfStructsWithInlineCondition</summary>
	public TArray<FPropertyEditorTestEditCondition> ArrayOfStructsWithInlineCondition;
	///<summary>NestedArrayOfInts</summary>
	public int NestedArrayOfInts;
}
