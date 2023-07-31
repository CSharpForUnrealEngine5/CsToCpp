#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Initial simple API for reading and writing data in a data channel from game code / BP.</summary>
[CppInclude("NiagaraDataChannelAccessor.h")]
public partial class UNiagaraDataChannelReader : UObject {
	///<summary>Owner</summary>
	public UNiagaraDataChannelHandler Owner;
	///<summary>Call before each access to the data channel to grab the correct data to read.</summary>
	public  bool InitAccess(UActorComponent OwningComponent) { return default; }
	///<summary>Num</summary>
	public  int Num() { return default; }
	///<summary>ReadFloat</summary>
	public  double ReadFloat(string VarName,int Index) { return default; }
	///<summary>ReadVector2D</summary>
	public  FVector2D ReadVector2D(string VarName,int Index) { return default; }
	///<summary>ReadVector</summary>
	public  FVector ReadVector(string VarName,int Index) { return default; }
	///<summary>ReadVector4</summary>
	public  FVector4 ReadVector4(string VarName,int Index) { return default; }
	///<summary>ReadQuat</summary>
	public  FQuat ReadQuat(string VarName,int Index) { return default; }
	///<summary>ReadLinearColor</summary>
	public  FLinearColor ReadLinearColor(string VarName,int Index) { return default; }
	///<summary>ReadInt</summary>
	public  int ReadInt(string VarName,int Index) { return default; }
	///<summary>ReadBool</summary>
	public  bool ReadBool(string VarName,int Index) { return default; }
}
