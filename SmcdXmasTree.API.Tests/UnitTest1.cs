using System.Net;
using NHamcrest.Core;
using static RestAssured.Dsl;

namespace SmcdXmasTree.API.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ServerIsRunning()
        {
            Given()
                .When()
                .Get("http://localhost:5202/SmcdXmasTree")
                .Then()
                .StatusCode(HttpStatusCode.OK);
        }

        [Fact]
        public void ServerGivesTreeWithoutParameter()
        {
            Given()
                .When()
                .Get("http://localhost:5202/SmcdXmasTree")
                .Then()
                .Body("tree", NHamcrest.Is.EqualTo("*"));
        }

        [Fact]
        public void ServerGivesTreeWithParameter1()
        {
            Given()
                .When()
                .Get("http://localhost:5202/SmcdXmasTree/1")
                .Then()
                .Body("tree", NHamcrest.Is.EqualTo("*"));
        }

        [Fact]
        public void ServerGivesTreeWithParameter2()
        {
            Given()
                .When()
                .Get("http://localhost:5202/SmcdXmasTree/2")
                .Then()
                .Body("tree", NHamcrest.Is.EqualTo(" * \n***"));
        }
    }
}
