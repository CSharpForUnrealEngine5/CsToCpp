namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Utils/RenderGridRemoteControlUtils.h")]
public partial class URenderGridRemoteControlUtils : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>ParseJsonAsByte</summary>
	public static void ParseJsonAsByte(string Json,byte DefaultValue,bool bSuccess,byte Value) {}
	///<summary>ParseJsonAsInt32</summary>
	public static void ParseJsonAsInt32(string Json,int DefaultValue,bool bSuccess,int Value) {}
	///<summary>ParseJsonAsInt64</summary>
	public static void ParseJsonAsInt64(string Json,long DefaultValue,bool bSuccess,long Value) {}
	///<summary>ParseJsonAsFloat</summary>
	public static void ParseJsonAsFloat(string Json,double DefaultValue,bool bSuccess,double Value) {}
	///<summary>ParseJsonAsBoolean</summary>
	public static void ParseJsonAsBoolean(string Json,bool DefaultValue,bool bSuccess,bool Value) {}
	///<summary>ParseJsonAsString</summary>
	public static void ParseJsonAsString(string Json,string DefaultValue,bool bSuccess,string Value) {}
	///<summary>ParseJsonAsName</summary>
	public static void ParseJsonAsName(string Json,FName DefaultValue,bool bSuccess,FName Value) {}
	///<summary>ParseJsonAsText</summary>
	public static void ParseJsonAsText(string Json,FText DefaultValue,bool bSuccess,FText Value) {}
	///<summary>ParseJsonAsObjectReference</summary>
	public static void ParseJsonAsObjectReference(string Json,UObject DefaultValue,bool bSuccess,UObject Value) {}
	///<summary>ParseJsonAsClassReference</summary>
	public static void ParseJsonAsClassReference(string Json,UClass DefaultValue,bool bSuccess,UClass Value) {}
	///<summary>ParseJsonAsStruct</summary>
	public static void ParseJsonAsStruct(string Json,FInstancedStruct DefaultValue,bool bSuccess,FInstancedStruct Value) {}
	///<summary>ParseJsonAsVector</summary>
	public static void ParseJsonAsVector(string Json,FVector DefaultValue,bool bSuccess,FVector Value) {}
	///<summary>ParseJsonAsRotator</summary>
	public static void ParseJsonAsRotator(string Json,FRotator DefaultValue,bool bSuccess,FRotator Value) {}
	///<summary>ParseJsonAsTransform</summary>
	public static void ParseJsonAsTransform(string Json,FTransform DefaultValue,bool bSuccess,FTransform Value) {}
	///<summary>ParseJsonAsColor</summary>
	public static void ParseJsonAsColor(string Json,FColor DefaultValue,bool bSuccess,FColor Value) {}
	///<summary>ParseJsonAsLinearColor</summary>
	public static void ParseJsonAsLinearColor(string Json,FLinearColor DefaultValue,bool bSuccess,FLinearColor Value) {}
	///<summary>ByteToJson</summary>
	public static void ByteToJson(byte Value,string Json) {}
	///<summary>Int32ToJson</summary>
	public static void Int32ToJson(int Value,string Json) {}
	///<summary>Int64ToJson</summary>
	public static void Int64ToJson(long Value,string Json) {}
	///<summary>FloatToJson</summary>
	public static void FloatToJson(double Value,string Json) {}
	///<summary>BooleanToJson</summary>
	public static void BooleanToJson(bool Value,string Json) {}
	///<summary>StringToJson</summary>
	public static void StringToJson(string Value,string Json) {}
	///<summary>NameToJson</summary>
	public static void NameToJson(FName Value,string Json) {}
	///<summary>TextToJson</summary>
	public static void TextToJson(FText Value,string Json) {}
	///<summary>ObjectReferenceToJson</summary>
	public static void ObjectReferenceToJson(UObject Value,string Json) {}
	///<summary>ClassReferenceToJson</summary>
	public static void ClassReferenceToJson(UClass Value,string Json) {}
	///<summary>StructToJson</summary>
	public static void StructToJson(FInstancedStruct Value,string Json) {}
	///<summary>VectorToJson</summary>
	public static void VectorToJson(FVector Value,string Json) {}
	///<summary>RotatorToJson</summary>
	public static void RotatorToJson(FRotator Value,string Json) {}
	///<summary>TransformToJson</summary>
	public static void TransformToJson(FTransform Value,string Json) {}
	///<summary>ColorToJson</summary>
	public static void ColorToJson(FColor Value,string Json) {}
	///<summary>LinearColorToJson</summary>
	public static void LinearColorToJson(FLinearColor Value,string Json) {}
}
