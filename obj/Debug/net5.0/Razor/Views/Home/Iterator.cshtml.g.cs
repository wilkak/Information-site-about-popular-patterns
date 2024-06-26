#pragma checksum "K:\универ\program\Основы программирования на платформе .NET\экзамен\итоговый проект сайта\WebApplication1\WebApplication1\Views\Home\Iterator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d961e907ccca38d9efe5e04ca0269133ac17e7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Iterator), @"mvc.1.0.view", @"/Views/Home/Iterator.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d961e907ccca38d9efe5e04ca0269133ac17e7d", @"/Views/Home/Iterator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Iterator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/code.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/iterator1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/iterator2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "K:\универ\program\Основы программирования на платформе .NET\экзамен\итоговый проект сайта\WebApplication1\WebApplication1\Views\Home\Iterator.cshtml"
  
    ViewBag.Title = "Итератор";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d961e907ccca38d9efe5e04ca0269133ac17e7d4966", async() => {
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
    <h1>Итератор (Iterator)</h1>
    <p class=""text-left"">Паттерн Итератор (Iterator) предоставляет абстрактный интерфейс для последовательного доступа ко всем элементам составного объекта без раскрытия его внутренней структуры.</p>
    <p class=""text-left"">Наверное, всем программистам, работающим с языком C#, приходилось иметь дело с циклом foreach, который перебирает объекты в массиве или коллекции. При этом встроенных классов коллекций существует множество, и каждая из них отличается по своей структуре и поведению.</p>
    <p class=""text-left"">Ключевым моментом, который позволяет осуществить перебор коллекций с помощью foreach, является применения этими классами коллекций паттерна итератор, или проще говоря пары интерфейсов IEnumerable / IEnumerator. Интерфейс IEnumerator определяет функционал для перебора внутренних объектов в контейнере:</p>
    <div id=""hler_501936"" class=""slgh""><ol class=""lines no-wrap""><li class=""alt1""><code class=""keyword"">public</code> <code class=""k");
            WriteLiteral(@"eyword"">interface</code> <code class=""plain"">IEnumerator</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">bool</code> <code class=""plain"">MoveNext(); </code><code class=""comments"">// перемещение на одну позицию вперед в контейнере элементов</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">object</code> <code class=""plain"">Current {</code><code class=""keyword"">get</code><code class=""plain"">;}&nbsp; </code><code class=""comments"">// текущий элемент в контейнере</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">void</code> <code class=""plain"">Reset(); </code><code class=""comments"">// перемещение в начало контейнера</code></li><li class=""alt2""><code class=""plain"">}</code></li></ol></div>
    <p class=""text-left"">А интерфейс IEnumerable использует IEnumerator для получения итератора для конкретного типа объекта:</p>
    <div id=""hler_368758"" class=""slgh""><ol class=""lines no-wrap""><li class=""");
            WriteLiteral(@"alt1""><code class=""keyword"">public</code> <code class=""keyword"">interface</code> <code class=""plain"">IEnumerable</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">IEnumerator GetEnumerator();</code></li><li class=""alt2""><code class=""plain"">}</code></li></ol></div>

    <p class=""text-left"">Используя данные интерфейсы, мы можем свести к одному шаблону - с помощью цикла foreach - любые составные объекты.</p>
    <h2>Когда использовать итераторы?</h2>
    <ul>
        <li class=""text-left"">Когда необходимо осуществить обход объекта без раскрытия его внутренней структуры</li>
        <li class=""text-left"">Когда имеется набор составных объектов, и надо обеспечить единый интерфейс для их перебора</li>
        <li class=""text-left"">Когда необходимо предоставить несколько альтернативных вариантов перебора одного и того же объекта </li>

    </ul>
    <p class=""text-left"">С помощью схем UML итераторы можно описать так:</p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3d961e907ccca38d9efe5e04ca0269133ac17e7d9301", async() => {
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
    <p class=""text-left"">Формальное определение паттерна на C# может выглядеть следующим образом:</p>
    <div id=""hler_825096"" class=""slgh""><ol class=""lines no-wrap""><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Client</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">Main()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Aggregate a = </code><code class=""keyword"">new</code> <code class=""plain"">ConcreteAggregate();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Iterator i = a.CreateIterator();</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&n");
            WriteLiteral(@"bsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">object</code> <code class=""plain"">item = i.First();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">while</code> <code class=""plain"">(!i.IsDone())</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">item = i.Next();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1""><code class=""keyword"">abstract</code> <code class=""keyword"">class</code> <code class=""plain"">Aggregate</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class");
            WriteLiteral(@"=""keyword"">abstract</code> <code class=""plain"">Iterator CreateIterator();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">int</code> <code class=""plain"">Count { </code><code class=""keyword"">get</code><code class=""plain"">; </code><code class=""keyword"">protected</code> <code class=""keyword"">set</code><code class=""plain"">; }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">object</code> <code class=""keyword"">this</code><code class=""plain"">[</code><code class=""keyword"">int</code> <code class=""plain"">index] { </code><code class=""keyword"">get</code><code class=""plain"">; </code><code class=""keyword"">set</code><code class=""plain"">; }</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;</li><li class=""alt2""><code class=""keyword"">class</code> <code class=""plain"">ConcreteAggregate ");
            WriteLiteral(@": Aggregate</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">private</code> <code class=""keyword"">readonly</code> <code class=""plain"">ArrayList _items = </code><code class=""keyword"">new</code> <code class=""plain"">ArrayList();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""plain"">Iterator CreateIterator()</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""keyword"">new</code> <code class=""plain"">ConcreteIterator(</code><code class=""keyword"">this</code><code class=""plain"">);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">publ");
            WriteLiteral(@"ic</code> <code class=""keyword"">override</code> <code class=""keyword"">int</code> <code class=""plain"">Count</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">get</code> <code class=""plain"">{ </code><code class=""keyword"">return</code> <code class=""plain"">_items.Count; }</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">protected</code> <code class=""keyword"">set</code> <code class=""plain"">{ }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">object</code> <code class=""keyword"">this</code><code class=""plain"">[</code><code class=""keyword"">int</code> <code class=""plain"">index]</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain");
            WriteLiteral(@""">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">get</code> <code class=""plain"">{ </code><code class=""keyword"">return</code> <code class=""plain"">_items[index]; }</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">set</code> <code class=""plain"">{ _items.Insert(index, value); }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1""><code class=""keyword"">abstract</code> <code class=""keyword"">class</code> <code class=""plain"">Iterator</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">object</code> <code class=""plain"">First();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">obje");
            WriteLiteral(@"ct</code> <code class=""plain"">Next();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">bool</code> <code class=""plain"">IsDone();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">object</code> <code class=""plain"">CurrentItem();</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;</li><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">ConcreteIterator : Iterator</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">private</code> <code class=""keyword"">readonly</code> <code class=""plain"">Aggregate _aggregate;</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">private</code> <code class=""keyword"">int</code> <code class=""plain"">_current;</code></li><li class=""alt1""");
            WriteLiteral(@">&nbsp;&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">ConcreteIterator(Aggregate aggregate)</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">this</code><code class=""plain"">._aggregate = aggregate;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">object</code> <code class=""plain"">First()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""plain"">_aggregate[0];</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbs");
            WriteLiteral(@"p;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">object</code> <code class=""plain"">Next()</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">object</code> <code class=""plain"">ret = </code><code class=""keyword"">null</code><code class=""plain"">;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">_current++;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">if</code> <code class=""plain"">(_current &lt; _aggregate.Count)</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=");
            WriteLiteral(@"""plain"">ret = _aggregate[_current];</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""plain"">ret;</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">object</code> <code class=""plain"">CurrentItem()</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""plain"">_aggregate[_current];</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code cla");
            WriteLiteral(@"ss=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">bool</code> <code class=""plain"">IsDone()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""plain"">_current &gt;= _aggregate.Count;</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li></ol></div>
    <h2>Участники</h2>
    <ul>
        <li class=""text-left"">Iterator: определяет интерфейс для обхода составных объектов</li>
        <li class=""text-left"">Aggregate: определяет интерфейс для создания объекта-итератора</li>
        <li class=""text-left"">ConcreteIterator: конкретная реализация итератора для обхода объекта Aggregate. Для фиксации индекса текущего перебираемого элемента использует целочисленную переменную _current </li>
        <li class=""text-left"">ConcreteAggregate: конкретная реал");
            WriteLiteral(@"изация Aggregate. Хранит элементы, которые надо будет перебирать </li>
        <li class=""text-left"">Client: использует объект Aggregate и итератор для его обхода </li>
    </ul>
    <p class=""text-left"">Теперь рассмотрим конкретный пример. Допустим, у нас есть классы книги и библиотеки:</p>
    <div id=""hler_844267"" class=""slgh""><ol class=""lines no-wrap""><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Book</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">string</code> <code class=""plain"">Name { </code><code class=""keyword"">get</code><code class=""plain"">; </code><code class=""keyword"">set</code><code class=""plain"">; }</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Library</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyw");
            WriteLiteral(@"ord"">private</code> <code class=""plain"">Book[] books;</code></li><li class=""alt2""><code class=""plain"">}</code></li></ol></div>
    <p class=""text-left"">И, допустим, у нас есть класс читателя, который хочет получить информацию о книгах, которые находятся в библиотеке. И для этого надо осуществить перебор объектов с помощью итератора:</p>
    <div id=""hler_230815"" class=""slgh""><ol class=""lines no-wrap""><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Program</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">static</code> <code class=""keyword"">void</code> <code class=""plain"">Main(</code><code class=""keyword"">string</code><code class=""plain"">[] args)</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Library library = </code><code class=""keyword"">new</code> <code class=""plain"">Library();</code></li>");
            WriteLiteral(@"<li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Reader reader = </code><code class=""keyword"">new</code> <code class=""plain"">Reader();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">reader.SeeBooks(library);</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.Read();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Reader</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">SeeBooks(Library library)</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp");
            WriteLiteral(@";&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">IBookIterator iterator = library.CreateNumerator();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">while</code><code class=""plain"">(iterator.HasNext())</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Book book = iterator.Next();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(book.Name);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2""><code class=""keyword"">interface</code> <code class=""plain"">IBookIterator</code></li><li c");
            WriteLiteral(@"lass=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">bool</code> <code class=""plain"">HasNext();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Book Next();</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1""><code class=""keyword"">interface</code> <code class=""plain"">IBookNumerable</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">IBookIterator CreateNumerator();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">int</code> <code class=""plain"">Count { </code><code class=""keyword"">get</code><code class=""plain"">; }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Book </code><code class=""keyword"">this</code><code class=""plain"">[</code><code class=""keyword"">int</code> <code class=""plain"">index] { </code><code class=""keyword"">get</code><code class=""plain"">;}</code></li><li class=""alt2""><code cl");
            WriteLiteral(@"ass=""plain"">}</code></li><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Book</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">string</code> <code class=""plain"">Name { </code><code class=""keyword"">get</code><code class=""plain"">; </code><code class=""keyword"">set</code><code class=""plain"">; }</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2""><code class=""keyword"">class</code> <code class=""plain"">Library : IBookNumerable</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">private</code> <code class=""plain"">Book[] books;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">Library()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;");
            WriteLiteral(@"&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">books = </code><code class=""keyword"">new</code> <code class=""plain"">Book[]</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">new</code> <code class=""plain"">Book{Name=</code><code class=""string"">""Война и мир""</code><code class=""plain"">},</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">new</code> <code class=""plain"">Book {Name=</code><code class=""string"">""Отцы и дети""</code><code class=""plain"">},</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">new</code> <code class=""plain"">Book {Name=</code><code class=""string"">""Вишневый сад""</code><code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""pl");
            WriteLiteral(@"ain"">};</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">int</code> <code class=""plain"">Count</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">get</code> <code class=""plain"">{ </code><code class=""keyword"">return</code> <code class=""plain"">books.Length; }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">Book </code><code class=""keyword"">this</code><code class=""plain"">[</code><code class=""keyword"">int</code> <code class=""plain"">index]</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=");
            WriteLiteral(@"""keyword"">get</code> <code class=""plain"">{ </code><code class=""keyword"">return</code> <code class=""plain"">books[index]; }</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">IBookIterator CreateNumerator()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""keyword"">new</code> <code class=""plain"">LibraryNumerator(</code><code class=""keyword"">this</code><code class=""plain"">);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2""><code class=""keyword"">class</code> <code class=""plain"">LibraryNumerator : IBookIterator</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">IBookNu");
            WriteLiteral(@"merable aggregate;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">int</code> <code class=""plain"">index=0;</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">LibraryNumerator(IBookNumerable a)</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">aggregate = a;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">bool</code> <code class=""plain"">HasNext()</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""plain"">index&lt;aggregate.Count;</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nb");
            WriteLiteral(@"sp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""plain"">Book Next()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">return</code> <code class=""plain"">aggregate[index++];</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li></ol></div>
    <h2>Результат работы программы:</h2>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3d961e907ccca38d9efe5e04ca0269133ac17e7d34141", async() => {
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
    <p class=""text-left"">Интерфейс IBookIterator представляет итератор наподобие интерфейса IEnumerator. Роль интерфейса составного агрегата представляет тип IBookNumerable. Клиентом здесь является класс Reader, который использует итератор для обхода объекта библиотеки.</p>




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
