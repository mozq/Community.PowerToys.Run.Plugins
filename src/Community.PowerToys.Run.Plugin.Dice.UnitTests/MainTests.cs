using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RichardSzalay.MockHttp;
using Wox.Plugin;

namespace Community.PowerToys.Run.Plugin.Dice.UnitTests
{
    [TestClass]
    public class MainTests
    {
        private Main subject;

        [TestInitialize]
        public void TestInitialize()
        {
            var settings = new DiceSettings
            {
                RollOptions = new List<RollOption>
                {
                    new RollOption { Expression = "1d6" },
                }
            };

            var mockHttp = new MockHttpMessageHandler();
            mockHttp.When("http://localhost/api/?3d6.json")
                .Respond("application/json", "{\"input\":\"3d6\",\"result\":12,\"details\":\" (4 +4 +4) \",\"code\":\"\",\"illustration\":\"<span style=\\\"color: gray;\\\"><\\/span> <span class=\\\"dc_dice_a\\\">3<\\/span><span class=\\\"dc_dice_d\\\">D6<\\/span>\",\"timestamp\":1664220883,\"x\":1664220883}");
            mockHttp.When("http://localhost/api/?asd.json")
                    .Respond("", "");
            mockHttp.When("http://localhost/api/?+.json")
                    .Respond("application/json", "{\"input\":\"+\",\"result\":\"dice code error\",\"details\":\"+\",\"code\":\"\",\"illustration\":\" <span class=\\\"dc_operator\\\">+<\\/span> \",\"timestamp\":1664222083,\"x\":1664222083}");
            var httpClient = mockHttp.ToHttpClient();
            httpClient.BaseAddress = new Uri("http://localhost/api/");

            subject = new Main(settings, httpClient);
        }

        [TestMethod]
        public void Query_without_delayedExecution_should_return_empty_result()
        {
            subject.Query(new(""))
                .Should().BeEmpty();

            subject.Query(new(""), false)
                .Should().BeEmpty();
        }

        [TestMethod]
        public void Query_without_expression_should_return_RollOptions_result()
        {
            subject.Query(new(""), true)
                .Should().BeEquivalentTo(new[] { new Result { Title = "1d6", SubTitle = "Roll 1d6" } });
        }

        [TestMethod]
        public void Query_with_expression_should_return_Roll_result()
        {
            subject.Query(new("3d6"), true)
                .Should().BeEquivalentTo(new[] { new Result { Title = "12", SubTitle = "3d6 => (4 +4 +4) = 12" } });
        }

        [TestMethod]
        public void Query_should_return_empty_result_when_Rolz_response_is_empty()
        {
            subject.Query(new("asd"), true)
                .Should().BeEmpty();
        }

        [TestMethod]
        public void Query_should_return_empty_result_when_Rolz_response_is_error()
        {
            subject.Query(new("+"), true)
                .Should().BeEmpty();
        }

        [TestMethod]
        public void LoadContextMenus_with_no_ContextData_should_return_empty_result()
        {
            subject.LoadContextMenus(new Result())
                .Should().BeEmpty();
        }

        [TestMethod]
        public void LoadContextMenus_with_RollOption_should_return_menu_with_copy_result()
        {
            var result = new Result { ContextData = new RollOption() };
            subject.LoadContextMenus(result)
                .Should().HaveCount(1)
                .And.Contain(x => x.Title == "Copy result (Enter)");
        }

        [TestMethod]
        public void LoadContextMenus_with_Roll_should_return_menu_with_copy_result_and_copy_details()
        {
            var result = new Result { ContextData = new Roll() };
            subject.LoadContextMenus(result)
                .Should().HaveCount(2)
                .And.Contain(x => x.Title == "Copy result (Enter)")
                .And.Contain(x => x.Title == "Copy details (Ctrl+C)");
        }
    }
}
