#pragma checksum "K:\универ\program\Основы программирования на платформе .NET\экзамен\итоговый проект сайта\WebApplication1\WebApplication1\Views\Home\Interpreter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6ac857d56a98b3360a58d67b2b562d466060652"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Interpreter), @"mvc.1.0.view", @"/Views/Home/Interpreter.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "K:\универ\program\Основы программирования на платформе .NET\экзамен\итоговый проект сайта\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "K:\универ\program\Основы программирования на платформе .NET\экзамен\итоговый проект сайта\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ac857d56a98b3360a58d67b2b562d466060652", @"/Views/Home/Interpreter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Interpreter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/code.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/interpreter1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/interpreter2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/interpreter3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "K:\универ\program\Основы программирования на платформе .NET\экзамен\итоговый проект сайта\WebApplication1\WebApplication1\Views\Home\Interpreter.cshtml"
  
    ViewBag.Title = "Интерпретатор";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b6ac857d56a98b3360a58d67b2b562d4660606525357", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""text-center"">
    <h1>Интерпретатор (Interpreter)</h1>
    <p class=""text-left"">Паттерн Интерпретатор (Interpreter) определяет представление грамматики для заданного языка и интерпретатор предложений этого языка. Как правило, данный шаблон проектирования применяется для часто повторяющихся операций. </p>
    <p class=""text-left"">Хотя паттерн требует понимания теории формальных языков и грамматик, на самом деле он не так сложен в понимании. </p>
    <p class=""text-left"">С помощью диаграмм UML паттерн можно описать так: </p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6ac857d56a98b3360a58d67b2b562d4660606527029", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <p class=""text-left"">На языке C# формальная структура программы могла бы выглядеть следующим образом:</p>

    <div id=""hler_460975"" class=""slgh""><ol class=""lines no-wrap""><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Client</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">void</code> <code class=""plain"">Main()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Context context = </code><code class=""keyword"">new</code> <code class=""plain"">Context();</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">var expression = </code><code class=""keyword"">new</code> <code class=""plain"">NonterminalExpression();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">expression.In");
            WriteLiteral(@"terpret(context);</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Context</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1""><code class=""keyword"">abstract</code> <code class=""keyword"">class</code> <code class=""plain"">AbstractExpression</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">void</code> <code class=""plain"">Interpret(Context context);</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2""><code class=""keyword"">class</code> <code class=""plain"">TerminalExpression : Abs");
            WriteLiteral(@"tractExpression</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">void</code> <code class=""plain"">Interpret(Context context)</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">NonterminalExpression : AbstractExpression</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">AbstractExpression expression1;</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">AbstractExpression expression2;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code cla");
            WriteLiteral(@"ss=""keyword"">void</code> <code class=""plain"">Interpret(Context context)</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li></ol></div>
    <h2>Участники</h2>
    <ul>
        <li class=""text-left"">AbstractExpression: определяет интерфейс выражения, объявляет метод Interpret()</li>
        <li class=""text-left"">TerminalExpression: терминальное выражение, реализует метод Interpret() для терминальных символов грамматики. Для каждого символа грамматики создается свой объект TerminalExpression</li>
        <li class=""text-left"">NonterminalExpression: нетерминальное выражение, представляет правило грамматики. Для каждого отдельного правила грамматики создается свой объект NonterminalExpression. </li>
        <li class=""text-left"">Context: содержит об");
            WriteLiteral(@"щую для интерпретатора информацию. Может использоваться объектами терминальных и нетерминальных выражений для сохранения состояния операций и последующего доступа к сохраненному состоянию</li>
        <li class=""text-left"">Client: строит предложения языка с данной грамматикой в виде абстрактного синтаксического дерева, узлами которого являются объекты TerminalExpression и NonterminalExpression</li>

    </ul>
    <p class=""text-left"">Методы Interpret в нетерминальных выражениях позволяют реализовать правила грамматики. При этом мы легко может добавить новые правила грамматики, определив новые объекты NonterminalExpression со своей реализацией метода Interpret. Однако данный паттерн подходит только для тех случаев, когда правила грамматики относительно простые. В более сложных случаях следует выбирать другие способы проектирования приложения. </p>
    <p class=""text-left"">Например, нам надо разработать программ для вычислений простейших операций сложения и вычитания с помощью переменных: x + y - z. Для эт");
            WriteLiteral(@"ого можно определить следующую грамматику: </p>
    <p class=""text-left"">
        IExpression ::= NumberExpression | Constant | AddExpression | SubtractExpression
        AddExpression ::= IExpression + IExpression
        SubtractExpression ::= IExpression - IExpression
        NumberExpression ::= [A-Z,a-z]+
        Constant ::= [1-9]+
    </p>
    <p class=""text-left"">Реализация этой грамматики на языке C# будет следующая программа: </p>
    <div id=""hler_399071"" class=""slgh""><ol class=""lines no-wrap""><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Program</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">static</code> <code class=""keyword"">void</code> <code class=""plain"">Main(</code><code class=""keyword"">string</code><code class=""plain"">[] args)</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code c");
            WriteLiteral(@"lass=""plain"">Context context = </code><code class=""keyword"">new</code> <code class=""plain"">Context();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// определяем набор переменных</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">int</code> <code class=""plain"">x = 5;</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">int</code> <code class=""plain"">y = 8;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">int</code> <code class=""plain"">z = 2;</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// добавляем переменные в контекст</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">context.SetVariable(</code><code class=""string"">""x""</code><code class=""p");
            WriteLiteral(@"lain"">, x);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">context.SetVariable(</code><code class=""string"">""y""</code><code class=""plain"">, y);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">context.SetVariable(</code><code class=""string"">""z""</code><code class=""plain"">, z);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// создаем объект для вычисления выражения x + y - z</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">IExpression expression = </code><code class=""keyword"">new</code> <code class=""plain"">SubtractExpression(</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">new</code> <code class=""plain"">AddExpression(</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code c");
            WriteLiteral(@"lass=""keyword"">new</code> <code class=""plain"">NumberExpression(</code><code class=""string"">""x""</code><code class=""plain"">), </code><code class=""keyword"">new</code> <code class=""plain"">NumberExpression(</code><code class=""string"">""y""</code><code class=""plain"">)</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">),</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">new</code> <code class=""plain"">NumberExpression(</code><code class=""string"">""z""</code><code class=""plain"">)</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">);</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">int</code> <code class=""plain"">result = expression.Interpret(context);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.Writ");
            WriteLiteral(@"eLine(</code><code class=""string"">""результат: {0}""</code><code class=""plain"">, result);</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.Read();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2""><code class=""keyword"">class</code> <code class=""plain"">Context</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Dictionary&lt;</code><code class=""keyword"">string</code><code class=""plain"">, </code><code class=""keyword"">int</code><code class=""plain"">&gt; variables;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">Context()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbs");
            WriteLiteral(@"p;<code class=""plain"">variables = </code><code class=""keyword"">new</code> <code class=""plain"">Dictionary&lt;</code><code class=""keyword"">string</code><code class=""plain"">, </code><code class=""keyword"">int</code><code class=""plain"">&gt;();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// получаем значение переменной по ее имени</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">int</code> <code class=""plain"">GetVariable(</code><code class=""keyword"">string</code> <code class=""plain"">name)</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""plain"">variables[name];</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp");
            WriteLiteral(@";&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">SetVariable(</code><code class=""keyword"">string</code> <code class=""plain"">name, </code><code class=""keyword"">int</code> <code class=""plain"">value)</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">if</code> <code class=""plain"">(variables.ContainsKey(name))</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">variables[name] = value;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">else</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">variables.Add(name, value);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=");
            WriteLiteral(@"""alt1""><code class=""comments"">// интерфейс интерпретатора</code></li><li class=""alt2""><code class=""keyword"">interface</code> <code class=""plain"">IExpression</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">int</code> <code class=""plain"">Interpret(Context context);</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2""><code class=""comments"">// терминальное выражение</code></li><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">NumberExpression : IExpression</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">string</code> <code class=""plain"">name; </code><code class=""comments"">// имя переменной</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">NumberExpression(</code><code class=""keyword"">string</code> <code class=""plain"">variableName)</code></li><li class=""alt1"">&");
            WriteLiteral(@"nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">name = variableName;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">int</code> <code class=""plain"">Interpret(Context context)</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""plain"">context.GetVariable(name);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1""><code class=""comments"">// нетерминальное выражение для сложения</code></li><li class=""alt2""><code class=""keyword"">class</code> <code class=""plain"">AddExpression : IExpression</code></li><li class=""alt1""><code class=""plain"">{</code></li");
            WriteLiteral(@"><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">IExpression leftExpression;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">IExpression rightExpression;</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">AddExpression(IExpression left, IExpression right)</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">leftExpression = left;</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">rightExpression = right;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">int</code> <code class=""plain"">Interpret(Context context)</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbs");
            WriteLiteral(@"p;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""plain"">leftExpression.Interpret(context) + rightExpression.Interpret(context);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2"">&nbsp;<code class=""comments"">// нетерминальное выражение для вычитания</code></li><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">SubtractExpression : IExpression</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">IExpression leftExpression;</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">IExpression rightExpression;</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">SubtractExpression(IExpression left, IExpression right)</code></");
            WriteLiteral(@"li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">leftExpression = left;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">rightExpression = right;</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">int</code> <code class=""plain"">Interpret(Context context)</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""plain"">leftExpression.Interpret(context) - rightExpression.Interpret(context);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2""><code class=""plain"">}</code></li></ol></div>
    <h2>Результа");
            WriteLiteral("т работы программы:</h2>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6ac857d56a98b3360a58d67b2b562d46606065226807", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <p class=\"text-left\">\r\n        В данном случае все действия интерпретатора можно описать следующим деревом:\r\n    </p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6ac857d56a98b3360a58d67b2b562d46606065227973", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <p class=""text-left"">Класс Context определяет методы для установки значений переменных и для получения их значений. </p>
    <p class=""text-left"">В качестве интерпретатора используется интерфейс IExpression. Его реализация - класс NumberExpression предназначен для выражения отдельных переменных - это терминальные объекты. </p>
    <p class=""text-left"">Другие реализации интерфейса - классы AddExpression и SubtractExpression представляют нетерминальные объекты. Они реализуют простейшие операции сложения и вычитания и могут рекурсивно обращаться к методам Interpret используемых терминальных и нетерминальных объектов. </p>
    <p class=""text-left"">Клиент, в роли которого выступает класс Program, инициализирует контекст и для вычисления выражения x + y - z создается объект SubtractExpression, который в качестве параметров принимает другие объекты IExpression. </p>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
