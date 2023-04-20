using System.Net;
using NHamcrest.Core;
using static RestAssured.Dsl;

namespace SmcdXmasTree.API.Tests
{
    public class SmcdXmasTreeApiControllerTest
    {
        // A test case without assertions ensures only that no exceptions are thrown.
        // Beyond basic runnability, it ensures nothing about the behavior of the code under test.
        // This rule raises an exception when no assertions from supported frameworks.
        // The Rest.Assured.Net we are using is none of them
        #pragma warning disable S2699

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
        #pragma warning restore S2699
    }
}
