#pragma checksum "K:\универ\program\Основы программирования на платформе .NET\экзамен\итоговый проект сайта\WebApplication1\WebApplication1\Views\Home\Memento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a658e3cd307ca6e2b168c1e7cec6a11250f1254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Memento), @"mvc.1.0.view", @"/Views/Home/Memento.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a658e3cd307ca6e2b168c1e7cec6a11250f1254", @"/Views/Home/Memento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Memento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/code.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/memento1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/memento2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "K:\универ\program\Основы программирования на платформе .NET\экзамен\итоговый проект сайта\WebApplication1\WebApplication1\Views\Home\Memento.cshtml"
  
    ViewBag.Title = "Хранитель";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a658e3cd307ca6e2b168c1e7cec6a11250f12544959", async() => {
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
    <h1>Хранитель (Memento)</h1>
    <p class=""text-left"">Паттерн Хранитель (Memento) позволяет выносить внутреннее состояние объекта за его пределы для последующего возможного восстановления объекта без нарушения принципа инкапсуляции. </p>
    <p class=""text-left"">Когда использовать Memento?</p>
    <ul>
        <li class=""text-left"">Когда нужно сохранить состояние объекта для возможного последующего восстановления</li>
        <li class=""text-left"">Когда сохранение состояния должно проходить без нарушения принципа инкапсуляции</li>

    </ul>
    <p class=""text-left"">То есть ключевыми понятиями для данного паттерна являются сохранение внутреннего состояния и инкапсуляция, и важно соблюсти баланс между ними. Ведь, как правило, если мы не нарушаем инкапсуляцию, то состояние объекта хранится в объекте в приватных переменных. И не всегда для доступа к этим переменным есть методы или свойства с сеттерами и геттерами. Например, в игре происходит управление героем, все состоян");
            WriteLiteral(@"ие которого заключено в нем самом - оружие героя, показатель жизней, силы, какие-то другие показатели. И нередко может возникнуть ситуация, сохранить все эти показатели во вне, чтобы в будущем можно было откатиться к предыдущему уровню и начать игру заново. В этом случае как раз и может помочь паттерн Хранитель.</p>
    <p class=""text-left"">
        С помощью диаграмм структуру паттерна можно изобразить следующим образом:
    </p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a658e3cd307ca6e2b168c1e7cec6a11250f12547584", async() => {
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
    <p class=""text-left"">Формальная структура паттерна на языке C#:</p>
    <div id=""hler_225206"" class=""slgh""><ol class=""lines no-wrap""><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Memento</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">string</code> <code class=""plain"">State { </code><code class=""keyword"">get</code><code class=""plain"">; </code><code class=""keyword"">private</code> <code class=""keyword"">set</code><code class=""plain"">;}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">Memento(</code><code class=""keyword"">string</code> <code class=""plain"">state)</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">this</code><code class=""plain"">.State = state;</code></li><li class=""alt1"">&nbsp;&nb");
            WriteLiteral(@"sp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2""><code class=""keyword"">class</code> <code class=""plain"">Caretaker</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">Memento Memento { </code><code class=""keyword"">get</code><code class=""plain"">; </code><code class=""keyword"">set</code><code class=""plain"">; }</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Originator</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">string</code> <code class=""plain"">State { </code><code class=""keyword"">get</code><code class=""plain"">; </code><code class=""keyword"">set</code><code class=""plain"">; }</code>");
            WriteLiteral(@"</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">SetMemento(Memento memento)</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">State = memento.State;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">Memento CreateMemento()</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""keyword"">new</code> <code class=""plain"">Memento(State);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2""><code class=""plain"">}</code></li></ol></div>
    <h2>Участники</h2>
    <ul>
        <li class=""text-");
            WriteLiteral(@"left"">Memento: хранитель, который сохраняет состояние объекта Originator и предоставляет полный доступ только этому объекту Originator</li>
        <li class=""text-left"">Originator: создает объект хранителя для сохранения своего состояния</li>
        <li class=""text-left"">Caretaker: выполняет только функцию хранения объекта Memento, в то же время у него нет полного доступа к хранителю и никаких других операций над хранителем, кроме собственно сохранения, он не производит</li>

    </ul>
    <p class=""text-left"">Теперь рассмотрим реальный пример: нам надо сохранять состояние игрового персонажа в игре:</p>
    <div id=""hler_509051"" class=""slgh""><ol class=""lines no-wrap""><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Program</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">static</code> <code class=""keyword"">void</code> <code class=""plain"">Main(</code><code class=""keyword"">string</code><code class=""plain"">[");
            WriteLiteral(@"] args)</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Hero hero = </code><code class=""keyword"">new</code> <code class=""plain"">Hero();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">hero.Shoot(); </code><code class=""comments"">// делаем выстрел, осталось 9 патронов</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">GameHistory game = </code><code class=""keyword"">new</code> <code class=""plain"">GameHistory();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">game.History.Push(hero.SaveState()); </code><code class=""comments"">// сохраняем игру</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
            WriteLiteral(@"<code class=""plain"">hero.Shoot(); </code><code class=""comments"">//делаем выстрел, осталось 8 патронов</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">hero.RestoreState(game.History.Pop());</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">hero.Shoot(); </code><code class=""comments"">//делаем выстрел, осталось 8 патронов</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.Read();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1""><code class=""comments"">// Originator</code></li><li class=""alt2""><code class=""keyword"">class</code> <code class=""plain"">Hero</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;");
            WriteLiteral(@"&nbsp;&nbsp;&nbsp;<code class=""keyword"">private</code> <code class=""keyword"">int</code> <code class=""plain"">patrons=10; </code><code class=""comments"">// кол-во патронов</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">private</code> <code class=""keyword"">int</code> <code class=""plain"">lives=5; </code><code class=""comments"">// кол-во жизней</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">Shoot()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">if</code> <code class=""plain"">(patrons &gt; 0)</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">patrons--;</code></li><li class=""alt");
            WriteLiteral(@"2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">""Производим выстрел. Осталось {0} патронов""</code><code class=""plain"">, patrons);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">else</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">""Патронов больше нет""</code><code class=""plain"">);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// сохранение состояния</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">HeroMemento SaveState()</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</cod");
            WriteLiteral(@"e></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">""Сохранение игры. Параметры: {0} патронов, {1} жизней""</code><code class=""plain"">, patrons, lives);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""keyword"">new</code> <code class=""plain"">HeroMemento(patrons, lives);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// восстановление состояния</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">RestoreState(HeroMemento memento)</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">this</code><code class=""plain"">.p");
            WriteLiteral(@"atrons=memento.Patrons;</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">this</code><code class=""plain"">.lives = memento.Lives;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">""Восстановление игры. Параметры: {0} патронов, {1} жизней""</code><code class=""plain"">, patrons, lives);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2""><code class=""comments"">// Memento</code></li><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">HeroMemento</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">int</code> <code class=""plain"">Patrons { </code><code class=""keyword"">get</code><code class=""plain"">; </code><code class=""keyword"">private</code> <code class=""k");
            WriteLiteral(@"eyword"">set</code><code class=""plain"">; }</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">int</code> <code class=""plain"">Lives { </code><code class=""keyword"">get</code><code class=""plain"">; </code><code class=""keyword"">private</code> <code class=""keyword"">set</code><code class=""plain"">; }</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">HeroMemento(</code><code class=""keyword"">int</code> <code class=""plain"">patrons, </code><code class=""keyword"">int</code> <code class=""plain"">lives)</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">this</code><code class=""plain"">.Patrons = patrons;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">this</code><code class=""plain"">.Lives = lives;</code></li><li");
            WriteLiteral(@" class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">} </code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;</li><li class=""alt1""><code class=""comments"">// Caretaker</code></li><li class=""alt2""><code class=""keyword"">class</code> <code class=""plain"">GameHistory</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">Stack&lt;HeroMemento&gt; History { </code><code class=""keyword"">get</code><code class=""plain"">; </code><code class=""keyword"">private</code> <code class=""keyword"">set</code><code class=""plain"">; }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">GameHistory()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">History = </code><code class=""keyword"">new</code> <code class=");
            WriteLiteral("\"plain\">Stack&lt;HeroMemento&gt;();</code></li><li class=\"alt2\">&nbsp;&nbsp;&nbsp;&nbsp;<code class=\"plain\">}</code></li><li class=\"alt1\"><code class=\"plain\">}</code></li></ol></div>\r\n    <p class=\"text-left\">Консольный вывод программы:</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a658e3cd307ca6e2b168c1e7cec6a11250f125422136", async() => {
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
            WriteLiteral(@"
    <p class=""text-left"">Здесь в роли Originator выступает класс Hero, состояние которого описывается количество патронов и жизней. Для хранения состояния игрового персонажа предназначен класс HeroMemento. С помощью метода SaveState() объект Hero может сохранить свое состояние в HeroMemento, а с помощью метода RestoreState() - восстановить.</p>
    <p class=""text-left"">Для хранения состояний предназначен класс GameHistory, причем все состояния хранятся в стеке, что позволяет с легкостью извлекать последнее сохраненное состояние.</p>
    <p class=""text-left"">Использование паттерна Memento дает нам следующие преимущества:</p>
    <ul>
        <li class=""text-left"">Уменьшение связанности системы</li>
        <li class=""text-left"">Сохранение инкапсуляции информации</li>
        <li class=""text-left"">Определение простого интерфейса для сохранения и восстановления состояния</li>

    </ul>
    <p class=""text-left"">В то же время мы можем столкнуться с недостатками, в частности, если требуется сохранение б");
            WriteLiteral("ольшого объема информации, то возрастут издержки на хранение всего объема состояния.</p>\r\n\r\n</div>");
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