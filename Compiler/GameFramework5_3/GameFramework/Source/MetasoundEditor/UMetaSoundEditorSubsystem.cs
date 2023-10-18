namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The subsystem in charge of editor MetaSound functionality</summary>
[CppInclude("MetasoundEditorSubsystem.h")]
public partial class UMetaSoundEditorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Build the given builder to a MetaSound asset</summary>
	public object /*ReturnValue*/ BuildToAsset(UMetaSoundBuilderBase InBuilder,string Author,string AssetName,string PackagePath,EMetaSoundBuilderResult OutResult,USoundWave TemplateSoundWave/*=nullptr*/) { return default; }
	///<summary>Sets the visual location to InLocation of a given node InNode of a given builder&#39;s document.</summary>
	public void SetNodeLocation(UMetaSoundBuilderBase InBuilder,FMetaSoundNodeHandle InNode,FVector2D InLocation,EMetaSoundBuilderResult OutResult) {}
}
