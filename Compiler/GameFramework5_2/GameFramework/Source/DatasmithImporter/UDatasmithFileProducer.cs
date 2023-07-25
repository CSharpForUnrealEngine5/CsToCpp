#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithFileProducer.h")]
public partial class UDatasmithFileProducer : UDataprepContentProducer {
// DatasmithFileProducer
	public string FilePath;
	public UDatasmithScene DatasmithScene;
	public UPackage TransientPackage;
	public TArray<UDatasmithOptionsBase> TranslatorImportOptions;
	public bool bTranslatorImportOptionsInitialized;
}
