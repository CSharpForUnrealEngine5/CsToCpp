#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCache.h")]
public partial class UNiagaraSimCache : UObject {
	///<summary>A valid cache is one that contains at least 1 frames worth of data.</summary>
	public  bool IsCacheValid() { return default; }
	///<summary>An empty cache contains no frame data and can not be used</summary>
	public  bool IsEmpty() { return default; }
	///<summary>How were the attributes captured for this sim cache.</summary>
	public  ENiagaraSimCacheAttributeCaptureMode GetAttributeCaptureMode() { return default; }
	///<summary>Get the time the simulation was at when recorded.</summary>
	public  float GetStartSeconds() { return default; }
	///<summary>Get number of frames stored in the cache.</summary>
	public  int GetNumFrames() { return default; }
	///<summary>Get number of emitters stored inside the cache.</summary>
	public  int GetNumEmitters() { return default; }
	///<summary>Get the emitter name at the provided index.</summary>
	public  string GetEmitterName(int EmitterIndex) { return default; }
	///<summary>Returns a list of emitters we have captured in the SimCache.</summary>
	public  TArray<string> GetEmitterNames() { return default; }
	///<summary>Reads Niagara int attributes by name from the cache frame and appends them into the OutValues array.</summary>
	public  void ReadIntAttribute(TArray<int> OutValues,string AttributeName,string EmitterName,int FrameIndex/*=0*/) {}
	///<summary>Reads Niagara float attributes by name from the cache frame and appends them into the OutValues array.</summary>
	public  void ReadFloatAttribute(TArray<float> OutValues,string AttributeName,string EmitterName,int FrameIndex/*=0*/) {}
	///<summary>Reads Niagara Vec2 attributes by name from the cache frame and appends them into the OutValues array.</summary>
	public  void ReadVector2Attribute(TArray<FVector2D> OutValues,string AttributeName,string EmitterName,int FrameIndex/*=0*/) {}
	///<summary>Reads Niagara Vec3 attributes by name from the cache frame and appends them into the OutValues array.</summary>
	public  void ReadVectorAttribute(TArray<FVector> OutValues,string AttributeName,string EmitterName,int FrameIndex/*=0*/) {}
	///<summary>Reads Niagara Vec4 attributes by name from the cache frame and appends them into the OutValues array.</summary>
	public  void ReadVector4Attribute(TArray<FVector4> OutValues,string AttributeName,string EmitterName,int FrameIndex/*=0*/) {}
	///<summary>Reads Niagara Color attributes by name from the cache frame and appends them into the OutValues array.</summary>
	public  void ReadColorAttribute(TArray<FLinearColor> OutValues,string AttributeName/*=new FName("Color")*/,string EmitterName/*=NAME_None*/,int FrameIndex/*=0*/) {}
	///<summary>Reads Niagara Position attributes by name from the cache frame and appends them into the OutValues array.</summary>
	public  void ReadPositionAttribute(TArray<FVector> OutValues,string AttributeName/*=new FName("Position")*/,string EmitterName/*=NAME_None*/,bool bLocalSpaceToWorld/*=true*/,int FrameIndex/*=0*/) {}
	///<summary>Reads Niagara Position attributes by name from the cache frame and appends them into the OutValues array.</summary>
	public  void ReadPositionAttributeWithRebase(TArray<FVector> OutValues,FTransform Transform,string AttributeName/*=new FName("Position")*/,string EmitterName/*=NAME_None*/,int FrameIndex/*=0*/) {}
	///<summary>Reads Niagara Quaternion attributes by name from the cache frame and appends them into the OutValues array.</summary>
	public  void ReadQuatAttribute(TArray<FQuat> OutValues,string AttributeName/*=new FName("MeshOrientation")*/,string EmitterName/*=NAME_None*/,bool bLocalSpaceToWorld/*=true*/,int FrameIndex/*=0*/) {}
	///<summary>Reads Niagara Quaternion attributes by name from the cache frame and appends them into the OutValues array.</summary>
	public  void ReadQuatAttributeWithRebase(TArray<FQuat> OutValues,FQuat Quat,string AttributeName/*=new FName("MeshOrientation")*/,string EmitterName/*=NAME_None*/,int FrameIndex/*=0*/) {}
	///<summary>CacheGuid</summary>
	public FGuid CacheGuid;
	///<summary>SoftNiagaraSystem</summary>
	public TSoftObjectPtr<UNiagaraSystem> SoftNiagaraSystem;
	///<summary>StartSeconds</summary>
	public float StartSeconds;
	///<summary>DurationSeconds</summary>
	public float DurationSeconds;
	///<summary>CreateParameters</summary>
	public FNiagaraSimCacheCreateParameters CreateParameters;
	///<summary>bNeedsReadComponentMappingRecache</summary>
	public bool bNeedsReadComponentMappingRecache;
	///<summary>CachedScriptVMIds</summary>
	public TArray<FNiagaraVMExecutableDataId> CachedScriptVMIds;
	///<summary>CacheLayout</summary>
	public FNiagaraSimCacheLayout CacheLayout;
	///<summary>CacheFrames</summary>
	public TArray<FNiagaraSimCacheFrame> CacheFrames;
	///<summary>DataInterfaceStorage</summary>
	public TMap<FNiagaraVariableBase,UObject> DataInterfaceStorage;
}
