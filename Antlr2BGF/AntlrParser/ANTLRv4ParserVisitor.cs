//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\AntlrParser\ANTLRv4Parser.g4 by ANTLR 4.9

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ANTLRv4Parser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9")]
[System.CLSCompliant(false)]
public interface IANTLRv4ParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.grammarSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGrammarSpec([NotNull] ANTLRv4Parser.GrammarSpecContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.grammarDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGrammarDecl([NotNull] ANTLRv4Parser.GrammarDeclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.grammarType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGrammarType([NotNull] ANTLRv4Parser.GrammarTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.prequelConstruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrequelConstruct([NotNull] ANTLRv4Parser.PrequelConstructContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.optionsSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOptionsSpec([NotNull] ANTLRv4Parser.OptionsSpecContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOption([NotNull] ANTLRv4Parser.OptionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.optionValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOptionValue([NotNull] ANTLRv4Parser.OptionValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.delegateGrammars"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDelegateGrammars([NotNull] ANTLRv4Parser.DelegateGrammarsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.delegateGrammar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDelegateGrammar([NotNull] ANTLRv4Parser.DelegateGrammarContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.tokensSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTokensSpec([NotNull] ANTLRv4Parser.TokensSpecContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.channelsSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChannelsSpec([NotNull] ANTLRv4Parser.ChannelsSpecContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.idList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdList([NotNull] ANTLRv4Parser.IdListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.action_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAction_([NotNull] ANTLRv4Parser.Action_Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.actionScopeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitActionScopeName([NotNull] ANTLRv4Parser.ActionScopeNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.actionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitActionBlock([NotNull] ANTLRv4Parser.ActionBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.argActionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgActionBlock([NotNull] ANTLRv4Parser.ArgActionBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.modeSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModeSpec([NotNull] ANTLRv4Parser.ModeSpecContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.rules"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRules([NotNull] ANTLRv4Parser.RulesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.ruleSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRuleSpec([NotNull] ANTLRv4Parser.RuleSpecContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.parserRuleSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParserRuleSpec([NotNull] ANTLRv4Parser.ParserRuleSpecContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.exceptionGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExceptionGroup([NotNull] ANTLRv4Parser.ExceptionGroupContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.exceptionHandler"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExceptionHandler([NotNull] ANTLRv4Parser.ExceptionHandlerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.finallyClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFinallyClause([NotNull] ANTLRv4Parser.FinallyClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.rulePrequel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRulePrequel([NotNull] ANTLRv4Parser.RulePrequelContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.ruleReturns"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRuleReturns([NotNull] ANTLRv4Parser.RuleReturnsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.throwsSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitThrowsSpec([NotNull] ANTLRv4Parser.ThrowsSpecContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.localsSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLocalsSpec([NotNull] ANTLRv4Parser.LocalsSpecContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.ruleAction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRuleAction([NotNull] ANTLRv4Parser.RuleActionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.ruleModifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRuleModifiers([NotNull] ANTLRv4Parser.RuleModifiersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.ruleModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRuleModifier([NotNull] ANTLRv4Parser.RuleModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.ruleBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRuleBlock([NotNull] ANTLRv4Parser.RuleBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.ruleAltList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRuleAltList([NotNull] ANTLRv4Parser.RuleAltListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.labeledAlt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabeledAlt([NotNull] ANTLRv4Parser.LabeledAltContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.lexerRuleSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLexerRuleSpec([NotNull] ANTLRv4Parser.LexerRuleSpecContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.lexerRuleBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLexerRuleBlock([NotNull] ANTLRv4Parser.LexerRuleBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.lexerAltList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLexerAltList([NotNull] ANTLRv4Parser.LexerAltListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.lexerAlt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLexerAlt([NotNull] ANTLRv4Parser.LexerAltContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.lexerElements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLexerElements([NotNull] ANTLRv4Parser.LexerElementsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.lexerElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLexerElement([NotNull] ANTLRv4Parser.LexerElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.labeledLexerElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabeledLexerElement([NotNull] ANTLRv4Parser.LabeledLexerElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.lexerBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLexerBlock([NotNull] ANTLRv4Parser.LexerBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.lexerCommands"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLexerCommands([NotNull] ANTLRv4Parser.LexerCommandsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.lexerCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLexerCommand([NotNull] ANTLRv4Parser.LexerCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.lexerCommandName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLexerCommandName([NotNull] ANTLRv4Parser.LexerCommandNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.lexerCommandExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLexerCommandExpr([NotNull] ANTLRv4Parser.LexerCommandExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.altList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAltList([NotNull] ANTLRv4Parser.AltListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.alternative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlternative([NotNull] ANTLRv4Parser.AlternativeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElement([NotNull] ANTLRv4Parser.ElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.labeledElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabeledElement([NotNull] ANTLRv4Parser.LabeledElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.ebnf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEbnf([NotNull] ANTLRv4Parser.EbnfContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.blockSuffix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockSuffix([NotNull] ANTLRv4Parser.BlockSuffixContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.ebnfSuffix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEbnfSuffix([NotNull] ANTLRv4Parser.EbnfSuffixContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.lexerAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLexerAtom([NotNull] ANTLRv4Parser.LexerAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtom([NotNull] ANTLRv4Parser.AtomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.notSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotSet([NotNull] ANTLRv4Parser.NotSetContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.blockSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockSet([NotNull] ANTLRv4Parser.BlockSetContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.setElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetElement([NotNull] ANTLRv4Parser.SetElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] ANTLRv4Parser.BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.ruleref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRuleref([NotNull] ANTLRv4Parser.RulerefContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.characterRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCharacterRange([NotNull] ANTLRv4Parser.CharacterRangeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.terminal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTerminal([NotNull] ANTLRv4Parser.TerminalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.elementOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElementOptions([NotNull] ANTLRv4Parser.ElementOptionsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.elementOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElementOption([NotNull] ANTLRv4Parser.ElementOptionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ANTLRv4Parser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] ANTLRv4Parser.IdentifierContext context);
}