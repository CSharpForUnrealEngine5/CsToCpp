namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Initial simple API for reading and writing data in a data channel from game code / BP.</summary>
[CppInclude("NiagaraDataChannelAccessor.h")]
public partial class UNiagaraDataChannelReader : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Owner</summary>
	public UNiagaraDataChannelHandler Owner;
	///<summary>Call before each access to the data channel to grab the correct data to read.</summary>
	public bool InitAccess(UActorComponent OwningComponent) { return default; }
	///<summary>Num</summary>
	public int Num() { return default; }
	///<summary>ReadFloat</summary>
	public double ReadFloat(FName VarName,int Index) { return default; }
	///<summary>ReadVector2D</summary>
	public FVector2D ReadVector2D(FName VarName,int Index) { return default; }
	///<summary>ReadVector</summary>
	public FVector ReadVector(FName VarName,int Index) { return default; }
	///<summary>ReadVector4</summary>
	public FVector4 ReadVector4(FName VarName,int Index) { return default; }
	///<summary>ReadQuat</summary>
	public FQuat ReadQuat(FName VarName,int Index) { return default; }
	///<summary>ReadLinearColor</summary>
	public FLinearColor ReadLinearColor(FName VarName,int Index) { return default; }
	///<summary>ReadInt</summary>
	public int ReadInt(FName VarName,int Index) { return default; }
	///<summary>ReadBool</summary>
	public bool ReadBool(FName VarName,int Index) { return default; }
}
