namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayerAsset.h")]
public partial class UDataLayerAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetType</summary>
	public EDataLayerType GetType() { return default; }
	///<summary>IsRuntime</summary>
	public bool IsRuntime() { return default; }
	///<summary>GetDebugColor</summary>
	public FColor GetDebugColor() { return default; }
	///<summary>Whether the Data Layer affects actor runtime loading</summary>
	public EDataLayerType DataLayerType;
	///<summary>DebugColor</summary>
	public FColor DebugColor;
}
