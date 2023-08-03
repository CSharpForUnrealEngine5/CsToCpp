#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithFileProducer.h")]
public partial class UDatasmithFileProducer : UDataprepContentProducer {
	public static UClass StaticClass() {return default;}
	///<summary>End UDataprepContentProducer overrides</summary>
	public string FilePath;
	///<summary>DatasmithScene</summary>
	public UDatasmithScene DatasmithScene;
	///<summary>TransientPackage</summary>
	public UPackage TransientPackage;
	///<summary>TranslatorImportOptions</summary>
	public TArray<UDatasmithOptionsBase> TranslatorImportOptions;
	///<summary>bTranslatorImportOptionsInitialized</summary>
	public bool bTranslatorImportOptionsInitialized;
}
