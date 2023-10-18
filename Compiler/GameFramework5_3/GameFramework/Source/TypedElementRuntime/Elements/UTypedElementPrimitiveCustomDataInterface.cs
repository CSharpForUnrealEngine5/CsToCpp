namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Interfaces/TypedElementPrimitiveCustomDataInterface.h")]
public partial class UTypedElementPrimitiveCustomDataInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Sets all Primitive&#39;s CustomData values</summary>
	public virtual void SetCustomData(FScriptTypedElementHandle InElementHandle,TArray<float> CustomDataFloats,bool bMarkRenderStateDirty/*=false*/) {}
	///<summary>Sets a single Primitive&#39;s CustomData value</summary>
	public virtual void SetCustomDataValue(FScriptTypedElementHandle InElementHandle,int CustomDataIndex,float CustomDataValue,bool bMarkRenderStateDirty/*=false*/) {}
}
