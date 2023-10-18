namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Builder in charge of building a MetaSound Source</summary>
[CppInclude("MetasoundBuilderSubsystem.h")]
public partial class UMetaSoundSourceBuilder : UMetaSoundBuilderBase {
	public static UClass StaticClass() {return default;}
	///<summary>Audition</summary>
	public void Audition(UObject Parent,UAudioComponent AudioComponent,FOnCreateAuditionGeneratorHandleDelegate OnCreateGenerator,bool bLiveUpdatesEnabled/*=false*/) {}
	///<summary>Build</summary>
	public virtual object /*ReturnValue*/ Build(UObject Parent,FMetaSoundBuilderOptions Options) { return default; }
	///<summary>Returns whether or not live updates are both globally enabled (via cvar) and are enabled on this builder&#39;s last built sound, which may or may not still be playing.</summary>
	public bool GetLiveUpdatesEnabled() { return default; }
	///<summary>Sets the output audio format of the source</summary>
	public void SetFormat(EMetaSoundOutputAudioFormat OutputFormat,EMetaSoundBuilderResult OutResult) {}
}
