using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.Documents.Languages;

/// <summary>Asciidoc: its files, highlighting, comments and brackets.</summary>
public sealed class AsciiDocLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Asciidoc { get; } = new("asciidoc", "Asciidoc")
    {
        Extensions = [".adoc"],
        ScopeName = "document.adoc",
        LineComment = "//",
        BlockComment = ("////", "////"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition AsciidocGrammar { get; } = GrammarFiles.Find("document.adoc", "asciidoc/asciidoc.tmLanguage.json");
}
