namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VariantManagerTestActor.h")]
public partial class AVariantManagerTestActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Captured byte property</summary>
	public EVariantManagerTestEnum EnumWithNoDefault;
	///<summary>Captured byte property</summary>
	public EVariantManagerTestEnum EnumWithSecondDefault;
	///<summary>Captured byte property</summary>
	public byte CapturedByteProperty;
	///<summary>Captured int32 property</summary>
	public int CapturedIntProperty;
	///<summary>Captured float property</summary>
	public float CapturedFloatProperty;
	///<summary>Captured boolean property</summary>
	public bool bCapturedBoolProperty;
	///<summary>Captured UObject property</summary>
	public UObject CapturedObjectProperty;
	///<summary>Captured UInterface property</summary>
	public object /*CapturedInterfaceProperty*/ CapturedInterfaceProperty;
	///<summary>Captured FName property</summary>
	public string CapturedNameProperty;
	///<summary>Captured FString property</summary>
	public string CapturedStrProperty;
	///<summary>Captured FText property</summary>
	public FText CapturedTextProperty;
	///<summary>Captured FRotator property</summary>
	public FRotator CapturedRotatorProperty;
	///<summary>Captured FColor property</summary>
	public FColor CapturedColorProperty;
	///<summary>Captured FLinearColor property</summary>
	public FLinearColor CapturedLinearColorProperty;
	///<summary>Captured FVector property</summary>
	public FVector CapturedVectorProperty;
	///<summary>Captured FQuat property</summary>
	public FQuat CapturedQuatProperty;
	///<summary>Captured FVector4 property</summary>
	public FVector4 CapturedVector4Property;
	///<summary>Captured FVector2D property</summary>
	public FVector2D CapturedVector2DProperty;
	///<summary>Captured FIntPoint property</summary>
	public FIntPoint CapturedIntPointProperty;
	///<summary>Captured UObject array property</summary>
	public TArray<UObject> CapturedUObjectArrayProperty;
	///<summary>Captured FVector array property</summary>
	public TArray<FVector> CapturedVectorArrayProperty;
}
